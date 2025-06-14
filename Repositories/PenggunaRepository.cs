using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SiBadir.Interfaces;
using SiBadir.Model;

namespace SiBadir.Repositories
{
    public class PenggunaRepository : IPenggunaRepository
    {
        public int Insert(Pengguna user)
        {
            int newId = 0;
            newId = DatabaseRepository.Insert("pengguna",
                new[] { "nama_user", "alamat_user", "role", "username", "password", "is_active" },
                new object[] { user.NamaUser, user.AlamatUser, user.Role, user.Username, user.Password, user.IsActive },
                true);
            return newId;
        }

        public bool Update(Pengguna user, bool new_data = false)
        {
            if (new_data)
            {
                if (DatabaseRepository.Update("pengguna",
                    new[] { "username", "password" },
                    new object[] { user.Username, user.Password },
                    "id_user = @c0", new object[] { user.IdUser }))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (DatabaseRepository.Update("pengguna",
                    new[] { "nama_user", "alamat_user" },
                    new object[] { user.NamaUser, user.AlamatUser },
                    "id_user = @c0", new object[] { user.IdUser }))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Delete(int idUser)
        {
            DatabaseRepository.Update("pengguna",
            new[] { "is_active" },
            new object[] { 0 },
                "id_user = @c0", new object[] { idUser });
        }

        public List<Pengguna> GetAll()
        {
            var dt = DatabaseRepository.Select("SELECT * FROM pengguna WHERE is_active = @p0", new object[] { 1 });
            var list = new List<Pengguna>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(RowToPengguna(row));
            }

            return list;
        }

        public Pengguna GetByUsernameAndPassword(string username, string password)
        {
            var dt = DatabaseRepository.Select(
                "SELECT * FROM pengguna WHERE username = @p0 AND password = @p1",
                new object[] { username, password });

            if (dt.Rows.Count > 0)
            {
                return RowToPengguna(dt.Rows[0]);
            }

            return null;
        }

        public Pengguna RowToPengguna(DataRow row)
        {
            return new Pengguna
            {
                IdUser = Convert.ToInt32(row["id_user"]),
                NamaUser = row["nama_user"].ToString(),
                AlamatUser = row["alamat_user"].ToString(),
                Role = row["role"].ToString(),
                Username = row["username"].ToString(),
                Password = row["password"].ToString(),
                IsActive = row.IsNull("is_active") ? null : (int?)Convert.ToInt32(row["is_active"])
            };
        }
    }
}
