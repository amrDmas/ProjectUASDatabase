using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Koneksi
    {
        #region Data Member
        private MySqlConnection koneksiDB;
        #endregion

        #region Constructor
        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pServer + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword;

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;
            //panggil method connect yang sudah kita buat tadi
            Connect();
        }

        public Koneksi()
        {
            //Buka configurasi App.Config
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Ambil section userSettings yang otomatis dibuat berdasarkan file.settings
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            //Ambil bagian setting SIJualBeliForm.db
            var settingSection = userSettings.Sections["Celikoor_Kelompok8.db"] as ClientSettingsSection;

            //Ambil tiap variabel setting
            string DbServer = settingSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;
            //panggil method connect yang sudah kita buat tadi
            Connect();
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Method
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();

            return hasil;
        }

        public static int JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();

            //Buat MySqlCommand
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            //Gunakan ExecuteNonQuery untuk menjalankan perintah DML (Insert/delete/update)
            return c.ExecuteNonQuery();
        }
        #endregion
    }
}
