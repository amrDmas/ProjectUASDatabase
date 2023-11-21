using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Kelompok8
{
    public partial class FormMenu : Form
    {
        public Pegawai pegawai;
        public Konsumen konsumen;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            FormLogin frmLogin = new  FormLogin();
            frmLogin.Owner= this;
            frmLogin.Show();
            //try
            //{
            //    Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
            //    MessageBox.Show("Koneksi berhasil", "Informasi");

            //    // tampilkan form login
            //    FormLogin formLogin = new FormLogin();
            //    formLogin.Owner = this;

            //    if(formLogin.ShowDialog() == DialogResult.OK) // jika login sukses
            //    {
            //        label4.Text = pegawai.Id.ToString();
            //        label1.Text = pegawai.Nama;
            //        label4.Text = konsumen.Id.ToString();
            //        label1.Text = konsumen.Nama;
            //    }
            //    else //jika gagal login
            //    {
            //        MessageBox.Show("Gagal Login");
            //        Application.Exit();
            //    }

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Koneksi Gagal. Pesan kesalahan : " + ex.Message);
            //}
        }
    }
}
