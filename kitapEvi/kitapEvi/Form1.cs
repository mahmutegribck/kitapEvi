using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapEvi
{
    public partial class KitapEvi : Form
    {
        public KitapEvi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=kitapEvi; user ID=postgres; password=147852");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kitap_siparis order by siparis_no";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from odeme_turu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxOdemeTuru.DisplayMember = "odeme_turu";
            comboBoxOdemeTuru.ValueMember = "odeme_turu_no";
            comboBoxOdemeTuru.DataSource = dt;

            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from odeme_yontemi", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBoxOdemeYontemi.DisplayMember = "odeme_yontemi";
            comboBoxOdemeYontemi.ValueMember = "odeme_yontemi_no";
            comboBoxOdemeYontemi.DataSource = dt1;

            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from satis_personeli", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxSatisPersoneli.DisplayMember = "satis_personeli_adi";
            comboBoxSatisPersoneli.ValueMember = "satis_personeli_no";
            comboBoxSatisPersoneli.DataSource = dt2;

            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from kitap", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBoxKitapTuru.DisplayMember = "kitap_turu";
            comboBoxKitapTuru.ValueMember = "yayinevi_no";
            comboBoxKitapTuru.DataSource = dt3;

            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("select * from meslek", baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            comboBoxMeslekler.DisplayMember = "meslek_adi";
            comboBoxMeslekler.ValueMember = "meslek_no";
            comboBoxMeslekler.DataSource = dt4;

            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter("select * from adres", baglanti);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            comboBoxIller.DisplayMember = "il_adi";
            comboBoxIller.ValueMember = "adres_no";
            comboBoxIller.DataSource = dt5;

            NpgsqlDataAdapter da6 = new NpgsqlDataAdapter("select * from yayinevi", baglanti);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            comboBoxYayineviAdi.DisplayMember = "yayinevi_adi";
            comboBoxYayineviAdi.ValueMember = "yayinevi_no";
            comboBoxYayineviAdi.DataSource = dt6;
            baglanti.Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand ekle = new NpgsqlCommand(@"insert into kitap_siparis(""siparis_no"",""kitap_adi"",""kitap_turu"",""yazar_adi"",""yazar_soyadi"",""yayinevi_adi"",""siparis_tarihi"",""siparis_ucreti"",""odeme_turu"",""il_adi"",""musteri_adi"",""musteri_soyadi"",""meslek_adi"",""odeme_yontemi"",""satis_personeli_adi"") values (@siparis_no,@kitap_adi,@kitap_turu,@yazar_adi,@yazar_soyadi,@yayinevi_adi,@siparis_tarihi,@siparis_ucreti,@odeme_turu,@il_adi,@musteri_adi,@musteri_soyadi,@meslek_adi,@odeme_yontemi,@satis_personeli)", baglanti);

            ekle.Parameters.AddWithValue("@siparis_no", int.Parse(textBoxSiparisNo.Text));
            ekle.Parameters.AddWithValue("@kitap_adi", textBoxKitapAdi.Text);
            ekle.Parameters.AddWithValue("@kitap_turu", comboBoxKitapTuru.Text);
            ekle.Parameters.AddWithValue("@yazar_adi", textBoxYazarAdi.Text);
            ekle.Parameters.AddWithValue("@yazar_soyadi", textBoxYazarSoyadi.Text);
            ekle.Parameters.AddWithValue("@yayinevi_adi", comboBoxYayineviAdi.Text);
            ekle.Parameters.AddWithValue("@siparis_tarihi", textBoxSiparisTarihi.Text);
            ekle.Parameters.AddWithValue("@siparis_ucreti", int.Parse(textBoxSiparisUcreti.Text));
            ekle.Parameters.AddWithValue("@odeme_turu", comboBoxOdemeTuru.Text);
            ekle.Parameters.AddWithValue("@il_adi", comboBoxIller.Text);
            ekle.Parameters.AddWithValue("@musteri_adi", textBoxMusteriAdi.Text);
            ekle.Parameters.AddWithValue("@musteri_soyadi", textBoxMusteriSoyadi.Text);
            ekle.Parameters.AddWithValue("@meslek_adi", comboBoxMeslekler.Text);
            ekle.Parameters.AddWithValue("@odeme_yontemi", comboBoxOdemeYontemi.Text);
            ekle.Parameters.AddWithValue("@satis_personeli", comboBoxSatisPersoneli.Text);

            ekle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt Ekleme Islemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sil = new NpgsqlCommand("Delete from kitap_siparis where siparis_no = @siparis_no", baglanti);
            sil.Parameters.AddWithValue("@siparis_no", int.Parse(textBoxSiparisNo.Text));
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayit Silme Islemi Basarili Bir Sekilde Gerceklesti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand(@"Update kitap_siparis set ""kitap_adi""= @kitap_adi,""kitap_turu""= @kitap_turu,""siparis_ucreti""=  @siparis_ucreti,""odeme_turu""= @odeme_turu,""il_adi""= @il_adi,""musteri_adi""= @musteri_adi,""musteri_soyadi""= @musteri_soyadi,""meslek_adi""= @meslek_adi,""odeme_yontemi""= @odeme_yontemi,""satis_personeli_adi""= @satis_personeli_adi where ""siparis_no""= @siparis_no", baglanti);

            guncelle.Parameters.AddWithValue("@siparis_no", int.Parse(textBoxSiparisNo.Text));
            guncelle.Parameters.AddWithValue("@kitap_adi", textBoxKitapAdi.Text);
            guncelle.Parameters.AddWithValue("@kitap_turu", comboBoxKitapTuru.Text);
            guncelle.Parameters.AddWithValue("@yazar_adi", textBoxYazarAdi.Text);
            guncelle.Parameters.AddWithValue("@yazar_soyadi", textBoxYazarSoyadi.Text);
            guncelle.Parameters.AddWithValue("@yayinevi_adi", comboBoxYayineviAdi.Text);
            guncelle.Parameters.AddWithValue("@siparis_tarihi", textBoxSiparisTarihi.Text);
            guncelle.Parameters.AddWithValue("@siparis_ucreti", int.Parse(textBoxSiparisUcreti.Text));
            guncelle.Parameters.AddWithValue("@odeme_turu", comboBoxOdemeTuru.Text);
            guncelle.Parameters.AddWithValue("@il_adi", comboBoxIller.Text);
            guncelle.Parameters.AddWithValue("@musteri_adi", textBoxMusteriAdi.Text);
            guncelle.Parameters.AddWithValue("@musteri_soyadi", textBoxMusteriSoyadi.Text);
            guncelle.Parameters.AddWithValue("@meslek_adi", comboBoxMeslekler.Text);
            guncelle.Parameters.AddWithValue("@odeme_yontemi", comboBoxOdemeYontemi.Text);
            guncelle.Parameters.AddWithValue("@satis_personeli_adi", comboBoxSatisPersoneli.Text);

            guncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayit Güncelleme Islemi Basarili Bir Sekilde Gerceklesti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ara = new NpgsqlCommand(@"select*from kitap_siparis where ""musteri_adi"" = @musteri_adi ", baglanti);
            ara.Parameters.AddWithValue("@musteri_adi", textBoxMusteriAdi.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(ara);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void buttonSilinenKayitlar_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from silinen_kayitlar order by siparis_no";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttonKayitSayisi_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from siparis_sayisi";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttonIndirimUygula_Click(object sender, EventArgs e)
        {
            string sorgu = "select siparis_ucreti, indirimli_fiyat(siparis_ucreti) from kitap_siparis";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttonZamUygula_Click(object sender, EventArgs e)
        {
            string sorgu = "select siparis_ucreti, kdvli_ucret(siparis_ucreti) from kitap_siparis";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
