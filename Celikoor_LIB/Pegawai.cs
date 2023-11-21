using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Pegawai
    {
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string roles;

        public Pegawai(int id, string nama, string email, string username, string password, string roles)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Roles = roles;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles { get => roles; set => roles = value; }

        public static Pegawai CekLogin(string username, string password)
        {
            string sql = "";
            sql = "select id, nama, email, username, password, roles" +
                " from pegawai " +
                " where Username='" + username + "' AND Password = SHA2('" + password + "', 512)";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)//selama masih ada data atau masih bisa membaca data
            {
                Pegawai p = new Pegawai(Convert.ToInt32(hasil.GetValue(0)), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(),
                   hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString());
                return p;
            }
            return null;
        }
    }
}
