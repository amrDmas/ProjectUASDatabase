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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelNamaPegawai_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();

                Pegawai p = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                

                if(!(p is null))
                {
                    FormMenu formMenu = (FormMenu)this.Owner;
                    formMenu.pegawai = p;
                    MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Username tidak ditemukan atau password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Admin")
            {
                linkLabelBuyHere.Visible = false;
                labelTdkPunyaAkun.Visible = false;
            }
            else if (comboBox1.Text == "Operator")
            {
                linkLabelBuyHere.Visible = false;
                labelTdkPunyaAkun.Visible = false;
            }
            else if(comboBox1.Text == "Kasir")
            {
                linkLabelBuyHere.Visible = false;
                labelTdkPunyaAkun.Visible = false;
            }
            else
            {
                linkLabelBuyHere.Visible = true;
                labelTdkPunyaAkun.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelRegistrasi_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelBuyHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Owner = this;
            formRegister.Show();

        }
    }
}
