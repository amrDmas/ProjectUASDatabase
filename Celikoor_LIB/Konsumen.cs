using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Konsumen
    {
        private int id;
        private string nama;
        private string email;
        private string noHp;
        private string gender;
        private DateTime tglLahir;
        private double saldo;
        private string username;
        private string password;

        public Konsumen(int id, string nama, string email, string noHp, string gender, DateTime tglLahir, double saldo, string username, string password)
        {
            Id = id;
            Nama = nama;
            Email = email;
            NoHp = noHp;
            Gender = gender;
            TglLahir = tglLahir;
            Saldo = saldo;
            Username = username;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static List<Konsumen> BacaData()
        {
            List<Konsumen> listKonsumen = new List<Konsumen>();
            return listKonsumen;
        }
    }
}
