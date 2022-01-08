using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kaptan_Pansiyon_v1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        /*SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog =KaptanHotel; Integrated Security = True);
         */

  
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }
        
        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan Sonuc; 
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = Ucret.ToString();
             
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //baglanti.Open();
            /*SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi" 
             * values('"+TxtAdi.Text+ "','"+TxtSoyadi.Text+"',
             * '"+comboBox1.Text+"',
             * '"+MskTxtTelefon.Text+"',
             * '"+TxtMail.Text+"',
             * '"+TxtTC.Text+"',
             * '"+TxtOdaNo+"',
             * '"+TxtUcret.Text+"',
             * '"+DtpGirisTarihi.Value.ToString ("yyyy-MM-dd")+"',
             * '"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')",baglanti);
             * 
             * komut.ExecuteNonQuery();
             * baglanti.Close();
             * 
             * Message.Box("Müşteri kaydı yapıldı.");
             */
        }
    }
}
