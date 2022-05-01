
namespace kitapEvi
{
    partial class KitapEvi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSiparisUcreti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSiparisTarihi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxYazarSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxSiparisNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.comboBoxOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.comboBoxSatisPersoneli = new System.Windows.Forms.ComboBox();
            this.comboBoxKitapTuru = new System.Windows.Forms.ComboBox();
            this.comboBoxMeslekler = new System.Windows.Forms.ComboBox();
            this.comboBoxIller = new System.Windows.Forms.ComboBox();
            this.comboBoxYayineviAdi = new System.Windows.Forms.ComboBox();
            this.buttonSilinenKayitlar = new System.Windows.Forms.Button();
            this.buttonKayitSayisi = new System.Windows.Forms.Button();
            this.buttonIndirimUygula = new System.Windows.Forms.Button();
            this.buttonZamUygula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(31, 493);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(137, 62);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(230, 493);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(137, 62);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(621, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "İL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(381, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "MESLEKLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(575, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ÖDEME TÜRÜ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "SATIŞ PERSONELİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ÖDEME YÖNTEMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(744, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "YAYINEVİ ADI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(213, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "KİTAP ADI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(381, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "KİTAP TÜRÜ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(213, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "SİPARİŞ TARİHİ";
            // 
            // textBoxSiparisUcreti
            // 
            this.textBoxSiparisUcreti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxSiparisUcreti.ForeColor = System.Drawing.Color.White;
            this.textBoxSiparisUcreti.Location = new System.Drawing.Point(385, 312);
            this.textBoxSiparisUcreti.Name = "textBoxSiparisUcreti";
            this.textBoxSiparisUcreti.Size = new System.Drawing.Size(100, 20);
            this.textBoxSiparisUcreti.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(381, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "SİPARİŞ ÜCRETİ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(744, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "MÜŞTERİ ADI";
            // 
            // textBoxMusteriAdi
            // 
            this.textBoxMusteriAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxMusteriAdi.ForeColor = System.Drawing.Color.White;
            this.textBoxMusteriAdi.Location = new System.Drawing.Point(748, 313);
            this.textBoxMusteriAdi.Name = "textBoxMusteriAdi";
            this.textBoxMusteriAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxMusteriAdi.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(35, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "MÜŞTERİ SOYADI";
            // 
            // textBoxMusteriSoyadi
            // 
            this.textBoxMusteriSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxMusteriSoyadi.ForeColor = System.Drawing.Color.White;
            this.textBoxMusteriSoyadi.Location = new System.Drawing.Point(36, 401);
            this.textBoxMusteriSoyadi.Name = "textBoxMusteriSoyadi";
            this.textBoxMusteriSoyadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxMusteriSoyadi.TabIndex = 31;
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAra.Location = new System.Drawing.Point(827, 493);
            this.buttonAra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(137, 63);
            this.buttonAra.TabIndex = 32;
            this.buttonAra.Text = "ARA";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.Location = new System.Drawing.Point(628, 493);
            this.buttonGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(137, 63);
            this.buttonGüncelle.TabIndex = 33;
            this.buttonGüncelle.Text = "GÜNCELLE";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(429, 493);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(137, 63);
            this.buttonSil.TabIndex = 34;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // textBoxSiparisTarihi
            // 
            this.textBoxSiparisTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxSiparisTarihi.ForeColor = System.Drawing.Color.White;
            this.textBoxSiparisTarihi.Location = new System.Drawing.Point(217, 312);
            this.textBoxSiparisTarihi.Name = "textBoxSiparisTarihi";
            this.textBoxSiparisTarihi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSiparisTarihi.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(575, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "YAZAR ADI";
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxYazarAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxYazarAdi.Location = new System.Drawing.Point(579, 227);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxYazarAdi.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(744, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "YAZAR SOYADI";
            // 
            // textBoxYazarSoyadi
            // 
            this.textBoxYazarSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxYazarSoyadi.ForeColor = System.Drawing.Color.White;
            this.textBoxYazarSoyadi.Location = new System.Drawing.Point(748, 228);
            this.textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            this.textBoxYazarSoyadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxYazarSoyadi.TabIndex = 51;
            // 
            // textBoxSiparisNo
            // 
            this.textBoxSiparisNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxSiparisNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxSiparisNo.Location = new System.Drawing.Point(39, 227);
            this.textBoxSiparisNo.Name = "textBoxSiparisNo";
            this.textBoxSiparisNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSiparisNo.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(35, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "SİPARİŞ NO";
            // 
            // comboBoxOdemeTuru
            // 
            this.comboBoxOdemeTuru.FormattingEnabled = true;
            this.comboBoxOdemeTuru.Location = new System.Drawing.Point(579, 313);
            this.comboBoxOdemeTuru.Name = "comboBoxOdemeTuru";
            this.comboBoxOdemeTuru.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOdemeTuru.TabIndex = 54;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.textBoxKitapAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxKitapAdi.Location = new System.Drawing.Point(217, 227);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKitapAdi.TabIndex = 15;
            // 
            // comboBoxOdemeYontemi
            // 
            this.comboBoxOdemeYontemi.FormattingEnabled = true;
            this.comboBoxOdemeYontemi.Location = new System.Drawing.Point(217, 401);
            this.comboBoxOdemeYontemi.Name = "comboBoxOdemeYontemi";
            this.comboBoxOdemeYontemi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOdemeYontemi.TabIndex = 55;
            // 
            // comboBoxSatisPersoneli
            // 
            this.comboBoxSatisPersoneli.FormattingEnabled = true;
            this.comboBoxSatisPersoneli.Location = new System.Drawing.Point(39, 313);
            this.comboBoxSatisPersoneli.Name = "comboBoxSatisPersoneli";
            this.comboBoxSatisPersoneli.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSatisPersoneli.TabIndex = 56;
            // 
            // comboBoxKitapTuru
            // 
            this.comboBoxKitapTuru.FormattingEnabled = true;
            this.comboBoxKitapTuru.Location = new System.Drawing.Point(385, 227);
            this.comboBoxKitapTuru.Name = "comboBoxKitapTuru";
            this.comboBoxKitapTuru.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKitapTuru.TabIndex = 57;
            // 
            // comboBoxMeslekler
            // 
            this.comboBoxMeslekler.FormattingEnabled = true;
            this.comboBoxMeslekler.Location = new System.Drawing.Point(385, 401);
            this.comboBoxMeslekler.Name = "comboBoxMeslekler";
            this.comboBoxMeslekler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMeslekler.TabIndex = 58;
            // 
            // comboBoxIller
            // 
            this.comboBoxIller.FormattingEnabled = true;
            this.comboBoxIller.Location = new System.Drawing.Point(579, 400);
            this.comboBoxIller.Name = "comboBoxIller";
            this.comboBoxIller.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIller.TabIndex = 59;
            // 
            // comboBoxYayineviAdi
            // 
            this.comboBoxYayineviAdi.FormattingEnabled = true;
            this.comboBoxYayineviAdi.Location = new System.Drawing.Point(748, 401);
            this.comboBoxYayineviAdi.Name = "comboBoxYayineviAdi";
            this.comboBoxYayineviAdi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYayineviAdi.TabIndex = 60;
            // 
            // buttonSilinenKayitlar
            // 
            this.buttonSilinenKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonSilinenKayitlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSilinenKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSilinenKayitlar.Location = new System.Drawing.Point(1173, 288);
            this.buttonSilinenKayitlar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSilinenKayitlar.Name = "buttonSilinenKayitlar";
            this.buttonSilinenKayitlar.Size = new System.Drawing.Size(138, 62);
            this.buttonSilinenKayitlar.TabIndex = 61;
            this.buttonSilinenKayitlar.Text = "SİLİNEN KAYITLAR";
            this.buttonSilinenKayitlar.UseVisualStyleBackColor = false;
            this.buttonSilinenKayitlar.Click += new System.EventHandler(this.buttonSilinenKayitlar_Click);
            // 
            // buttonKayitSayisi
            // 
            this.buttonKayitSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonKayitSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitSayisi.Location = new System.Drawing.Point(1028, 288);
            this.buttonKayitSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKayitSayisi.Name = "buttonKayitSayisi";
            this.buttonKayitSayisi.Size = new System.Drawing.Size(137, 62);
            this.buttonKayitSayisi.TabIndex = 62;
            this.buttonKayitSayisi.Text = "KAYIT SAYISI";
            this.buttonKayitSayisi.UseVisualStyleBackColor = false;
            this.buttonKayitSayisi.Click += new System.EventHandler(this.buttonKayitSayisi_Click);
            // 
            // buttonIndirimUygula
            // 
            this.buttonIndirimUygula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonIndirimUygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndirimUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIndirimUygula.Location = new System.Drawing.Point(1028, 376);
            this.buttonIndirimUygula.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIndirimUygula.Name = "buttonIndirimUygula";
            this.buttonIndirimUygula.Size = new System.Drawing.Size(137, 63);
            this.buttonIndirimUygula.TabIndex = 64;
            this.buttonIndirimUygula.Text = "İNDİRİM UYGULA";
            this.buttonIndirimUygula.UseVisualStyleBackColor = false;
            this.buttonIndirimUygula.Click += new System.EventHandler(this.buttonIndirimUygula_Click);
            // 
            // buttonZamUygula
            // 
            this.buttonZamUygula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.buttonZamUygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonZamUygula.Location = new System.Drawing.Point(1174, 374);
            this.buttonZamUygula.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZamUygula.Name = "buttonZamUygula";
            this.buttonZamUygula.Size = new System.Drawing.Size(137, 65);
            this.buttonZamUygula.TabIndex = 65;
            this.buttonZamUygula.Text = "KDV/ZAM UYGULA";
            this.buttonZamUygula.UseVisualStyleBackColor = false;
            this.buttonZamUygula.Click += new System.EventHandler(this.buttonZamUygula_Click);
            // 
            // KitapEvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.buttonZamUygula);
            this.Controls.Add(this.buttonIndirimUygula);
            this.Controls.Add(this.buttonKayitSayisi);
            this.Controls.Add(this.buttonSilinenKayitlar);
            this.Controls.Add(this.comboBoxYayineviAdi);
            this.Controls.Add(this.comboBoxIller);
            this.Controls.Add(this.comboBoxMeslekler);
            this.Controls.Add(this.comboBoxKitapTuru);
            this.Controls.Add(this.comboBoxSatisPersoneli);
            this.Controls.Add(this.comboBoxOdemeYontemi);
            this.Controls.Add(this.comboBoxOdemeTuru);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxSiparisNo);
            this.Controls.Add(this.textBoxYazarSoyadi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxYazarAdi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSiparisTarihi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxMusteriSoyadi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxMusteriAdi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSiparisUcreti);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKitapAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "KitapEvi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEvi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSiparisUcreti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMusteriAdi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMusteriSoyadi;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSiparisTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxYazarAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxYazarSoyadi;
        private System.Windows.Forms.TextBox textBoxSiparisNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxOdemeTuru;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.ComboBox comboBoxOdemeYontemi;
        private System.Windows.Forms.ComboBox comboBoxSatisPersoneli;
        private System.Windows.Forms.ComboBox comboBoxKitapTuru;
        private System.Windows.Forms.ComboBox comboBoxMeslekler;
        private System.Windows.Forms.ComboBox comboBoxIller;
        private System.Windows.Forms.ComboBox comboBoxYayineviAdi;
        private System.Windows.Forms.Button buttonSilinenKayitlar;
        private System.Windows.Forms.Button buttonKayitSayisi;
        private System.Windows.Forms.Button buttonIndirimUygula;
        private System.Windows.Forms.Button buttonZamUygula;
    }
}

