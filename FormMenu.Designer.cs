namespace Celikoor_Kelompok8
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCinema = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuJenisStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuKelompok = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAktors = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuPegawai = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuKonsumen = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarSistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.labelKodePegawai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMaster,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem1,
            this.keluarSistemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 26);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemMaster
            // 
            this.ToolStripMenuItemMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuCinema,
            this.ToolStripMenuStudio,
            this.ToolStripMenuJenisStudio,
            this.ToolStripMenuGenre,
            this.ToolStripMenuKelompok,
            this.ToolStripMenuAktors,
            this.ToolStripMenuPegawai,
            this.ToolStripMenuKonsumen});
            this.ToolStripMenuItemMaster.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemMaster.Name = "ToolStripMenuItemMaster";
            this.ToolStripMenuItemMaster.Size = new System.Drawing.Size(80, 22);
            this.ToolStripMenuItemMaster.Text = "Master";
            // 
            // ToolStripMenuCinema
            // 
            this.ToolStripMenuCinema.Name = "ToolStripMenuCinema";
            this.ToolStripMenuCinema.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuCinema.Text = "Cinema";
            this.ToolStripMenuCinema.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // ToolStripMenuStudio
            // 
            this.ToolStripMenuStudio.Name = "ToolStripMenuStudio";
            this.ToolStripMenuStudio.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuStudio.Text = "Studio";
            // 
            // ToolStripMenuJenisStudio
            // 
            this.ToolStripMenuJenisStudio.Name = "ToolStripMenuJenisStudio";
            this.ToolStripMenuJenisStudio.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuJenisStudio.Text = "Jenis Studio";
            // 
            // ToolStripMenuGenre
            // 
            this.ToolStripMenuGenre.Name = "ToolStripMenuGenre";
            this.ToolStripMenuGenre.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuGenre.Text = "Genre";
            // 
            // ToolStripMenuKelompok
            // 
            this.ToolStripMenuKelompok.Name = "ToolStripMenuKelompok";
            this.ToolStripMenuKelompok.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuKelompok.Text = "Kelompok";
            this.ToolStripMenuKelompok.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // ToolStripMenuAktors
            // 
            this.ToolStripMenuAktors.Name = "ToolStripMenuAktors";
            this.ToolStripMenuAktors.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuAktors.Text = "Aktors";
            // 
            // ToolStripMenuPegawai
            // 
            this.ToolStripMenuPegawai.Name = "ToolStripMenuPegawai";
            this.ToolStripMenuPegawai.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuPegawai.Text = "Pegawai";
            // 
            // ToolStripMenuKonsumen
            // 
            this.ToolStripMenuKonsumen.Name = "ToolStripMenuKonsumen";
            this.ToolStripMenuKonsumen.Size = new System.Drawing.Size(196, 22);
            this.ToolStripMenuKonsumen.Text = "Konsumen";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembelianToolStripMenuItem});
            this.transaksiToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // pembelianToolStripMenuItem
            // 
            this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pembelianToolStripMenuItem.Text = "Pembelian";
            // 
            // laporanToolStripMenuItem1
            // 
            this.laporanToolStripMenuItem1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanToolStripMenuItem1.Name = "laporanToolStripMenuItem1";
            this.laporanToolStripMenuItem1.Size = new System.Drawing.Size(90, 22);
            this.laporanToolStripMenuItem1.Text = "Laporan";
            // 
            // keluarSistemToolStripMenuItem
            // 
            this.keluarSistemToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluarSistemToolStripMenuItem.Name = "keluarSistemToolStripMenuItem";
            this.keluarSistemToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.keluarSistemToolStripMenuItem.Text = "Keluar Sistem";
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPegawai.Location = new System.Drawing.Point(485, 9);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(43, 13);
            this.labelNamaPegawai.TabIndex = 14;
            this.labelNamaPegawai.Text = "Nama ";
            // 
            // labelKodePegawai
            // 
            this.labelKodePegawai.AutoSize = true;
            this.labelKodePegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodePegawai.Location = new System.Drawing.Point(426, 9);
            this.labelKodePegawai.Name = "labelKodePegawai";
            this.labelKodePegawai.Size = new System.Drawing.Size(36, 13);
            this.labelKodePegawai.TabIndex = 12;
            this.labelKodePegawai.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Anda login sebagai: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Pegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Anda login sebagai: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "-";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Celikoor_Kelompok8.Properties.Resources.FormUtama;
            this.ClientSize = new System.Drawing.Size(890, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelNamaPegawai);
            this.Controls.Add(this.labelKodePegawai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormMenu";
            this.Text = "Celikoor 21 Cineplex";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMaster;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuCinema;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuStudio;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuJenisStudio;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuGenre;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuKelompok;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarSistemToolStripMenuItem;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.Label labelKodePegawai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAktors;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuPegawai;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuKonsumen;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

