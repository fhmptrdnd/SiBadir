using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Controller;

namespace SiBadir
{
    public partial class MainMenu : Form
    {
        //private void LoadFormInPanel(Form form)
        //{
        //    mainContainer.Controls.Clear();
        //    form.TopLevel = false;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;
        //    mainContainer.Controls.Add(form);
        //    form.Show();
        //}
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoadFormInPanel(new FormMenuKaryawan());
            SiBadir.Controller.FormController.LoadFormInPanel(this.mainContainer, new FormMenuKaryawan());
        }

        private void HistoryStokBahanBtn_click(object sender, EventArgs e)
        {

        }
    }
}
