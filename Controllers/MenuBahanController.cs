using System;
using System.Collections.Generic;
using System.Linq;
using SiBadir.Model;
using SiBadir.Repositories;

namespace SiBadir.Controllers
{ 
        public class StokBahanController
        {
            private static BahanRepository _bahanRepo = new ();
            private static HistoryRepository _historyRepo = new ();
            private static NotifikasiRepository _notifikasiRepo = new();

        // Metode untuk mendapatkan data stok bahan beserta nama kategori untuk tampilan DataGridView
        public static List<Bahan> GetDataStokBahan()
            {
                try
                {
                    // Memanggil metode GetAllBahanDisplay dari BahanRepository
                    return _bahanRepo.GetAll();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat mengambil data stok bahan: {ex.Message}");
                    // Melempar exception agar error dapat ditangkap dan ditampilkan di UI
                    throw new Exception($"Gagal mengambil data stok bahan: {ex.Message}");
                }
            }

            // Metode untuk menambahkan bahan baru dan mencatat riwayat
            public static bool TambahBahan(string namaBahan, string satuanBahan, int idKategori, int stokBahan, int idUser)
            {
                // Validasi input dasar sebelum mencoba operasi database
                if (string.IsNullOrWhiteSpace(namaBahan) || string.IsNullOrWhiteSpace(satuanBahan) || idKategori <= 0)
                {
                    Console.WriteLine("Validasi input gagal: Nama bahan, satuan, atau kategori tidak valid.");
                    return false; // Mengembalikan false jika validasi input tidak terpenuhi
                }

                try
                {
                    // Membuat objek Bahan baru dari data input
                    Bahan newBahan = new Bahan
                    {
                        NamaBahan = namaBahan.Trim(),
                        SatuanBahan = satuanBahan.Trim(),
                        IdKategori = idKategori,
                        StokBahan = stokBahan, // Stok awal diambil dari parameter
                        IsActive = 1
                    };


                // Memasukkan bahan ke database dan mendapatkan ID yang baru di-generate
                int newBahanId = _bahanRepo.Add(newBahan);

                if (newBahan.StokBahan <= 10)
                {
                    // Jika stok baru <= 10, tambahkan notifikasi
                    _notifikasiRepo.insertNotifikasi(new NotifikasiStok
                    {
                        IdBahan = newBahanId,
                        IsRead = 0,
                        TanggalNotifikasi = DateTime.Now
                    });
                }

                    // Mencatat riwayat penambahan bahan
                    _historyRepo.Insert(new HistoryStokBahan
                    {
                        IdBahan = newBahanId, // Menggunakan ID bahan yang baru didapat
                        IdUser = idUser,
                        StokSebelum = 0, // Stok sebelum penambahan bahan baru (biasanya 0)
                        StokSesudah = stokBahan, // Stok sesudah penambahan, sesuai inputan
                        JenisPerubahan = "Penambahan",
                        Keterangan = $"Menambah bahan baru: '{namaBahan.Trim()}' dengan satuan '{satuanBahan.Trim()}' dan stok awal {stokBahan}."
                    });

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat menambahkan bahan: {ex.Message}");
                    // Melempar exception  error dapat ditangkap dan ditampilkan di UI
                    throw new Exception($"Gagal menambahkan bahan: {ex.Message}");
                }
            }

            // Metode untuk mengedit data bahan yang sudah ada dan mencatat riwayat
            public static bool EditBahan(Bahan bahan, int idUser)
            {
                // Validasi input dasar
                if (bahan == null || bahan.IdBahan <= 0 || string.IsNullOrWhiteSpace(bahan.NamaBahan) ||
                    string.IsNullOrWhiteSpace(bahan.SatuanBahan) || bahan.IdKategori <= 0)
                {
                    Console.WriteLine("Validasi input gagal: Objek bahan tidak valid atau ID bahan <= 0.");
                    return false;
                }

                try
                {
                    // Mengambil data bahan lama sebelum diupdate untuk perbandingan riwayat
                    Bahan oldBahan = _bahanRepo.GetById(bahan.IdBahan);
                    if (oldBahan == null)
                    {
                        Console.WriteLine($"Bahan dengan ID {bahan.IdBahan} tidak ditemukan untuk diedit.");
                        // Melempar exception jika bahan tidak ditemukan
                        throw new Exception($"Bahan dengan ID {bahan.IdBahan} tidak ditemukan.");
                    }

                    // Melakukan update data bahan di database
                    _bahanRepo.Update(bahan);

                    // Membangun string perubahan untuk keterangan riwayat
                    string changes = "";
                    if (oldBahan.NamaBahan != bahan.NamaBahan)
                    {
                        changes += $"Nama dari '{oldBahan.NamaBahan}' menjadi '{bahan.NamaBahan}'. ";
                    }
                    if (oldBahan.SatuanBahan != bahan.SatuanBahan)
                    {
                        changes += $"Satuan dari '{oldBahan.SatuanBahan}' menjadi '{bahan.SatuanBahan}'. ";
                    }
                    if (oldBahan.IdKategori != bahan.IdKategori)
                    {
                        changes += $"ID Kategori dari '{oldBahan.IdKategori}' menjadi '{bahan.IdKategori}'. ";
                    }
                    if (oldBahan.StokBahan != bahan.StokBahan)
                    {
                        changes += $"Stok dari {oldBahan.StokBahan} menjadi {bahan.StokBahan}. ";
                        if (bahan.StokBahan <= 10) 
                        {
                            // Jika stok baru <= 10, tambahkan notifikasi
                            _notifikasiRepo.insertNotifikasi(new NotifikasiStok
                            {
                                IdBahan = bahan.IdBahan,
                                IsRead = 0,
                                TanggalNotifikasi = DateTime.Now
                            });
                        }
                    }

                    // Menentukan keterangan akhir untuk riwayat
                    string finalKeterangan = string.IsNullOrEmpty(changes) ?
                                             $"Tidak ada perubahan data spesifik untuk bahan '{bahan.NamaBahan}'." :
                                             $"Mengubah data bahan '{bahan.NamaBahan}': {changes.Trim()}";

                    string jenisPerubahan = "Perubahan Data";
                    if (oldBahan.StokBahan > bahan.StokBahan)
                    {
                        jenisPerubahan = "Pengurangan";
                    }
                    else if (oldBahan.StokBahan < bahan.StokBahan)
                    {
                        jenisPerubahan = "Penambahan";
                    }
                    // Mencatat riwayat perubahan data bahan
                    _historyRepo.Insert(new HistoryStokBahan
                    {
                        IdBahan = bahan.IdBahan,
                        IdUser = idUser,
                        StokSebelum = oldBahan.StokBahan,
                        StokSesudah = bahan.StokBahan,
                        JenisPerubahan = jenisPerubahan,
                        Keterangan = finalKeterangan
                    });

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat mengedit bahan: {ex.Message}");
                    // Melempar exception agar error dapat ditangkap dan ditampilkan di UI
                    throw new Exception($"Gagal mengedit bahan: {ex.Message}");
                }
            }

            // Metode untuk mengupdate stok bahan secara spesifik dan mencatat riwayat
            public static bool UpdateStokBahan(int idBahan, int newStok, int idUser)
            {
                // Validasi input dasar
                if (idBahan <= 0 || newStok < 0)
                {
                    Console.WriteLine("Validasi input gagal: ID bahan tidak valid atau stok baru negatif.");
                    return false;
                }

                try
                {
                    // Mengambil data bahan yang akan diupdate stoknya
                    Bahan bahanToUpdate = _bahanRepo.GetById(idBahan);
                    if (bahanToUpdate == null)
                    {
                        Console.WriteLine($"Bahan dengan ID {idBahan} tidak ditemukan untuk update stok.");
                        // Melempar exception jika bahan tidak ditemukan
                        throw new Exception($"Bahan dengan ID {idBahan} tidak ditemukan.");
                    }

                    int oldStok = bahanToUpdate.StokBahan; // Menyimpan stok lama
                    bahanToUpdate.StokBahan = newStok; // Mengatur stok baru

                    // Melakukan update stok di database
                    _bahanRepo.Update(bahanToUpdate);

                    // Menentukan keterangan untuk riwayat
                    string finalKeterangan = $"Mengubah stok bahan '{bahanToUpdate.NamaBahan}' dari {oldStok} menjadi {newStok}.";

                    // Mencatat riwayat perubahan stok
                    _historyRepo.Insert(new HistoryStokBahan
                    {
                        IdBahan = idBahan,
                        IdUser = idUser,
                        StokSebelum = oldStok,
                        StokSesudah = newStok,
                        JenisPerubahan = "Perubahan Stok",
                        Keterangan = finalKeterangan
                    });

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat mengupdate stok bahan: {ex.Message}");
                    // Melempar exception agar error dapat ditangkap dan ditampilkan di UI
                    throw new Exception($"Gagal mengupdate stok bahan: {ex.Message}");
                }
            }

            // Metode untuk menghapus (menonaktifkan) bahan dan mencatat riwayat
            public static bool HapusBahan(int idBahan, int idUser)
            {
                // Validasi input dasar
                if (idBahan <= 0)
                {
                    Console.WriteLine("Validasi input gagal: ID bahan tidak valid.");
                    return false;
                }

                try
                {
                    // Mengambil data bahan yang akan dihapus untuk keterangan riwayat
                    Bahan bahanToDelete = _bahanRepo.GetById(idBahan);
                    if (bahanToDelete == null)
                    {
                        Console.WriteLine($"Bahan dengan ID {idBahan} tidak ditemukan untuk dihapus.");
                        // Melempar exception jika bahan tidak ditemukan
                        throw new Exception($"Bahan dengan ID {idBahan} tidak ditemukan.");
                    }

                    // Melakukan logical delete (menonaktifkan) bahan di database
                    _bahanRepo.Delete(idBahan);

                    // Menentukan keterangan untuk riwayat
                    string finalKeterangan = $"Menonaktifkan bahan: '{bahanToDelete.NamaBahan}'.";

                    // Mencatat riwayat penonaktifan bahan
                    _historyRepo.Insert(new HistoryStokBahan
                    {
                        IdBahan = idBahan,
                        IdUser = idUser,
                        StokSebelum = bahanToDelete.StokBahan,
                        StokSesudah = bahanToDelete.StokBahan, // Stok secara fungsional tidak berubah saat dinonaktifkan
                        JenisPerubahan = "Penonaktifan Bahan",
                        Keterangan = finalKeterangan
                    });

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saat menghapus (menonaktifkan) bahan: {ex.Message}");
                    // Melempar exception agar error dapat ditangkap dan ditampilkan di UI
                    throw new Exception($"Gagal menghapus bahan: {ex.Message}");
                }
            }
        }
    }

