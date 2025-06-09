using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Controller
{
    public class FormController
    {
        public static void LoadFormInPanel(Panel containerPanel, Form form) // Ubah jadi public static
        {
            if (containerPanel == null)
            {
                throw new ArgumentNullException(nameof(containerPanel), "Panel kontainer tidak boleh null!");
            }

            if (form == null)
            {
                throw new ArgumentNullException(nameof(form), "Form yang akan dimuat tidak boleh null!");
            }

            // Clear kontrol yang ada di dalam panel dulu
            containerPanel.Controls.Clear();

            // Atur properti form
            form.TopLevel = false; 
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.Fill; 

            form.BringToFront(); 
            containerPanel.Refresh();

            // Tambahkan form ke kontrol panel
            containerPanel.Controls.Add(form);

            form.Show();
        }

        public static void CloseForm(Panel containerPanel)
        {
            if (containerPanel == null)
            {
                throw new ArgumentNullException(nameof(containerPanel), "Panel kontainer tidak boleh null!");
            }
            // Tutup semua form yang ada di dalam panel
            foreach (Control control in containerPanel.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                }
            }
        }
    }
}