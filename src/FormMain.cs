using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MySQL bağlantısı için 
// http://net-informations.com/q/faq/mysql.html
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DovizOtomasyon
{

    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();


            // Form

            // ControlBox'u kaldır.
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        MySqlConnection baglan;
        public void Kur()
        {
            string bag;

            MySqlConnectionStringBuilder kur = new MySqlConnectionStringBuilder();

            kur.UserID = "root";
            kur.Password = "12345";
            kur.Database = "dovizotomasyon";
            kur.Server = "localhost";
            kur.PersistSecurityInfo = true;

            bag = kur.ToString();
            baglan = new MySqlConnection(bag);

        }

        public void dovizDoldur()
        {
            
            try
            {
                baglan.Open();
                string selectQuery = "SELECT * FROM dovizotomasyon.doviz";
                MySqlCommand command = new MySqlCommand(selectQuery, baglan);
                MySqlDataReader okuDoviz = command.ExecuteReader();
                
                // Listedeki her bir veriyi oku
                //using (MySqlDataReader oku = command.ExecuteReader())
                //{
                    while (okuDoviz.Read())
                    {
                        string tam_ad = okuDoviz.GetString("doviz_logo");
                        string logo = okuDoviz.GetString("doviz_tam_adi");

                        dovizCinsicomboBox.Items.Add(tam_ad + " - " + logo);
                    }
                //}
                okuDoviz.Close();
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Döviz türü listesinde hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                baglan.Close();
            }
        }

        List<string> doviz_id_liste = new List<string>();
        List<string> doviz_adi_liste = new List<string>();
        List<string> doviz_tam_adi_liste = new List<string>();
        List<string> doviz_logo_liste = new List<string>();

        public void dovizBilgiAl()
        {

            try
            {
                baglan.Open();
                string selectQuery = "SELECT * FROM dovizotomasyon.doviz";
                MySqlCommand command = new MySqlCommand(selectQuery, baglan);
                MySqlDataReader oku = command.ExecuteReader();
                
                

                while (oku.Read())
                {
                    string doviz_id = oku.GetString("doviz_id");
                    string doviz_adi = oku.GetString("doviz_adi");
                    string doviz_tam_adi = oku.GetString("doviz_tam_adi");
                    string doviz_logo = oku.GetString("doviz_logo");

                    doviz_id_liste.Add(doviz_id);
                    doviz_adi_liste.Add(doviz_adi);
                    doviz_tam_adi_liste.Add(doviz_tam_adi);
                    doviz_logo_liste.Add(doviz_logo);

                }

                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Döviz türü listesinde hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglan.Close();
            }
        }

        string sec_doviz_id;
        string sec_doviz_adi;
        string sec_doviz_tam_adi;
        string sec_doviz_logo;


        public void dovizAlisSatisDegisim()
        {
            //sil
        }

        public void seciliDovizAyikla()
        {
            // Seçili dövizden ilk karakteri (logoyu) al
            //https://stackoverflow.com/questions/3878820/c-how-to-get-first-char-of-a-string
            string seciliDovizLogo = dovizCinsicomboBox.SelectedText.ToString();
            seciliDovizLogo = seciliDovizLogo.Substring(0, 1);

            //https://stackoverflow.com/questions/6481823/find-index-of-an-int-in-a-list
            int seciliDovizIndex = doviz_logo_liste.FindIndex(x => x == seciliDovizLogo);

            sec_doviz_id = doviz_id_liste[seciliDovizIndex];
            sec_doviz_adi = doviz_adi_liste[seciliDovizIndex];
            sec_doviz_tam_adi = doviz_tam_adi_liste[seciliDovizIndex];
            sec_doviz_logo = doviz_logo_liste[seciliDovizIndex];


            // Seçili dövizi liste içinde arat

        }

        public void islemDoldur()
        {

            
            try
            {
                baglan.Open();
                string selectQuery = "SELECT * FROM dovizotomasyon.islem";
                MySqlCommand command = new MySqlCommand(selectQuery, baglan);

                MySqlDataReader okuIslem = command.ExecuteReader();
                //using (MySqlDataReader oku = command.ExecuteReader())
                //{
                // Listedeki her bir veriyi oku
                while (okuIslem.Read())
                    {
                        islemTurucomboBox.Items.Add(okuIslem.GetString("islem_adi"));
                    }
                //}
                okuIslem.Close();
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem listesinde hata: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                baglan.Close();
            }
        }

        public void APIcalistir()
        {

            System.Diagnostics.Process api = new System.Diagnostics.Process();
            api.StartInfo.FileName = @"E:\İşler\Dersler\VeritabaniYonetimSistemleri_SerdarSolak_2\Döviz Otomasyon\api\start.bat";
            api.StartInfo.WorkingDirectory = @"E:\İşler\Dersler\VeritabaniYonetimSistemleri_SerdarSolak_2\Döviz Otomasyon\api\";

            //https://stackoverflow.com/questions/5377423/hide-console-window-from-process-start-c-sharp
            // Console penceresini gizle
            api.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            api.Start();
            //Dosya yolunu değiştir
            //System.Diagnostics.Process.Start(@"E:\İşler\Dersler\VeritabaniYonetimSistemleri_SerdarSolak_2\Döviz Otomasyon\api\start.bat");

            /*
            Process proc = null;
            try
            {
                string batDir = string.Format(@"E:\İşler\Dersler\VeritabaniYonetimSistemleri_SerdarSolak_2\Döviz Otomasyon\api\start.bat");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "start.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                MessageBox.Show("Bat file executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            */

        }

        public void guncelKurGetir()
        {
            string kurKomut = "SELECT doviz.doviz_logo, doviz.doviz_tam_adi, deger.satis_fiyat, deger.alis_fiyat FROM deger INNER JOIN  doviz ON deger.doviz_id = doviz.doviz_id;";

            baglan.Open();
            MySqlCommand kurCommand = new MySqlCommand(kurKomut, baglan);
            MySqlDataAdapter kurDataAdapter = new MySqlDataAdapter(kurCommand);

            DataTable kurTable = new DataTable();
            kurDataAdapter.Fill(kurTable);
            kurlarDataGridView.DataSource = kurTable;
            baglan.Close();

        }


        private void FormMain_Load(object sender, EventArgs e)
        {

            // https://stackoverflow.com/questions/9160059/set-up-dot-instead-of-comma-in-numeric-values
            // Türkiye'de ondalık sayılardan önce virgül kullanılırken, SQL'de bu noktadır. Ondalıklı sayıların insert edilmesi sırasında sorun yaşamamak için
            // özelleştirilmiş bir kültür sınıfı yaratıp decimal ayracını virgülden noktaya çeviriyoruz.
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // API erişimi için
            APIcalistir();
            Kur();
            //Baglan();
            
            dovizDoldur();
            islemDoldur();
            dovizBilgiAl();
            guncelKurGetir();

            //ChartDoldur       
        }
        private void alisSatisButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            alisSatisMainPanel.Visible = true;
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            //TopBPanel.BackColor = System.Drawing.Color.FromArgb(255, 0, 0); // 27; 79; 143
            alisSatisButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
            //alisSatisButton.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);//105, 157, 240
            //alisSatisButton.IconColor = System.Drawing.Color.Gold;
        }

        private void muhasebeButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            muhasebePanel.Visible = true;
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            muhasebeButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
    
            string muhasebeKomut = "SELECT alısveris.a_id, alısveris.tarih, alısveris.miktar, islem.islem_adi, doviz.doviz_tam_adi, personel.ad, personel.soyad FROM alısveris INNER JOIN  doviz ON alısveris.doviz_id = doviz.doviz_id INNER JOIN  islem ON alısveris.islem_id = islem.islem_id INNER JOIN  personel ON alısveris.personel_id = personel.personel_id";

            baglan.Open();
            MySqlCommand muhasebeCommand = new MySqlCommand(muhasebeKomut, baglan);
            MySqlDataAdapter muhasebeDataAdapter = new MySqlDataAdapter(muhasebeCommand);

            DataTable muhasebeTable = new DataTable();
            muhasebeDataAdapter.Fill(muhasebeTable);
            muhasebeDataGridView.DataSource = muhasebeTable;
            baglan.Close();

            /*
                SELECT alısveris.a_id, alısveris.tarih, alısveris.miktar, islem.islem_adi, doviz.doviz_tam_adi, personel.ad, personel.soyad
                FROM alısveris
                INNER JOIN  doviz ON alısveris.doviz_id=doviz.doviz_id
                INNER JOIN  islem ON alısveris.islem_id=islem.islem_id
                INNER JOIN  personel ON alısveris.personel_id=personel.personel_id
            */

        }

        private void kurlarButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            kurlarPanel.Visible = true;

            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            kurlarButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        private void bankaButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            bankaKurlarPanel.Visible = true;

            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            bankaButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        // Tüm butonların biçimlendirmelerini sıfırla
        private void allTopButtons_Default()
        {
            alisSatisButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            muhasebeButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            kurlarButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            bankaButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);

            TopBPanel.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);

            alisSatisButton.IconColor = System.Drawing.Color.WhiteSmoke;
        }

        // Tüm ekranları kapat
        private void allMainPanels_Invisible()
        {
            alisSatisMainPanel.Visible = false;
            muhasebePanel.Visible = false;
            kurlarPanel.Visible = false;
            bankaKurlarPanel.Visible = false;
        }

        private void kullaniciButon_Sifirla()
        {
            kullaniciTextBox.Text = "";
            sifreTextBox.Text = "";

        }

        private void kullaniciButon_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            girisYapPanel.Enabled = true;
            allMainPanels_Invisible();
            TopPanel.Visible = false;
            TopBPanel.BackColor = System.Drawing.Color.DarkGray;
            girisYapPanel.Visible = true;

        }


        private void alisverisMiktarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //
            // TextBox'a sadece sayı yazılabilmesi için yapılan kontroller
            //

            // Anlık tuşlanan karakteri tutan değişken
            char ch = e.KeyChar;

            // ASCII'de 8 = backspace
            // https://stackoverflow.com/questions/20421083/textbox-numbers-only-with
            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dovizCinsicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliDovizLogo = null;

            if (dovizCinsicomboBox.SelectedIndex != -1)
            {
                seciliDovizLogo = dovizCinsicomboBox.SelectedItem.ToString();
                seciliDovizLogo = seciliDovizLogo[0].ToString();
            }

            if (islemTurucomboBox.Text == "Alış")
            {
                if (dovizCinsicomboBox.SelectedIndex != -1)
                {
                    donusturLabel2.Text = "Türk Lirası - ₺";
                    donusturLabel1.Text = "" + dovizCinsicomboBox.SelectedItem;

                    miktarLogo.Text = seciliDovizLogo;
                    karsilikLogo.Text = "₺";
                }
                else
                {
                    donusturLabel1.Text = "Birim seç";
                    donusturLabel2.Text = "Birim seç";
                }
            }

            else if (islemTurucomboBox.Text == "Satış")
            {

                if (dovizCinsicomboBox.SelectedIndex != -1)
                {
                    donusturLabel1.Text = "Türk Lirası - ₺";
                    donusturLabel2.Text = "" + dovizCinsicomboBox.SelectedItem;

                    karsilikLogo.Text = seciliDovizLogo;
                    miktarLogo.Text = "₺";
                }
                else
                {
                    donusturLabel1.Text = "Birim seç";
                    donusturLabel2.Text = "Birim seç";
                }

            }
            else
            {

            }

        }

        private void islemTurucomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliDovizLogo = null;

            if (dovizCinsicomboBox.SelectedIndex != -1)
            {
                seciliDovizLogo = dovizCinsicomboBox.SelectedItem.ToString();
                seciliDovizLogo = seciliDovizLogo[0].ToString();
            }
   
            if (islemTurucomboBox.Text == "Alış")
            {
                if (dovizCinsicomboBox.SelectedIndex != -1)
                {

                    miktarLogo.Text = seciliDovizLogo;
                    karsilikLogo.Text = "₺";

                    donusturLabel2.Text = "Türk Lirası - ₺";
                    donusturLabel1.Text = "" + dovizCinsicomboBox.SelectedItem;
                }
                else
                {
                    donusturLabel1.Text = "Birim seç";
                    donusturLabel2.Text = "Birim seç";
                }


            }

            else if (islemTurucomboBox.Text == "Satış")
            {
                
                if (dovizCinsicomboBox.SelectedIndex != -1)
                {
                    miktarLogo.Text = "₺";
                    karsilikLogo.Text = seciliDovizLogo;

                    donusturLabel1.Text = "Türk Lirası - ₺";
                    donusturLabel2.Text = "" + dovizCinsicomboBox.SelectedItem;
                }
                else
                {
                    donusturLabel1.Text = "Birim seç";
                    donusturLabel2.Text = "Birim seç";
                }

            }
            else
            {

            }

        }

        bool kilit = false;

        private void kilitAc()
        {
            // Combobox'lar çalışıyor
            dovizCinsicomboBox.Enabled = true;
            islemTurucomboBox.Enabled = true;
            alisverisMiktarTextBox.Enabled = false;
            alisverisMiktarOndalikTextBox.Enabled = false;

            // Buton simgesi = kapalı kilit
            kilitleButton.IconChar = FontAwesome.Sharp.IconChar.Lock;

            // Tamamla buton simgesi devre dışı
            tamamlaButton.Enabled = false;
            kilit = false;
        }

        /*
        public string, string seciliIslem()
        {
            string seciliDoviz = dovizCinsicomboBox.SelectedItem.ToString();
            string seciliIslem = islemTurucomboBox.SelectedItem.ToString();

            return (seciliDoviz, seciliIslem);
        }
        */
        private void kilitleButton_Click(object sender, EventArgs e)
        {
            // İkisi de boş ise
            if (islemTurucomboBox.SelectedIndex == -1 && dovizCinsicomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Döviz ve işlem türü seçiniz", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // İşlem türü boş ise
            else if (islemTurucomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("İşlem türü seçiniz", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Döviz cinsi boş ise
            else if (dovizCinsicomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Döviz türü seçiniz", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // İki combobox seçili ise
            else
            {   
                // İşlemi, geri sayımı başlat
                if (kilit == false)
                {
                    // Buraya logoların yerleşim fonksiyonunu ekle //
                    // Combobox'lar devre dışı
                    dovizCinsicomboBox.Enabled = false;
                    islemTurucomboBox.Enabled = false;
                    alisverisMiktarTextBox.Enabled = true;
                    alisverisMiktarOndalikTextBox.Enabled = true;

                    // Buton simgesi = açık kilit
                    kilitleButton.IconChar = FontAwesome.Sharp.IconChar.LockOpen;

                    // Tamamla buton simgesi devrede
                    tamamlaButton.Enabled = true;

                    islemGeriSayim.Stop();
                    geriSayimLabel.Text = "-"; // Saniye label'ını sıfırla

                    kilit = true;

                    //Zamanlayıcıyı başlat
                    geriSayimLabel.Text = "60"; // 60 saniyeden geri say
                    islemGeriSayim.Start();

                    //seciliIslem();
                }

                else
                {   // Eğer kilit açılır (işlem sonlandırılırsa) geri sayımı durdur
                    geriSayimLabel.Text = "-";
                    islemGeriSayim.Stop();
                    kilitAc();
                }
            }


        }

        private void yeniIslemFormTemizle()
        {
            // Döviz ve işlem combobox'larını temizle
            dovizCinsicomboBox.Items.Clear();
            islemTurucomboBox.Items.Clear();

            // Listeleri yeniden doldur, güncelle
            dovizDoldur();
            islemDoldur();

            //Textbox'u temizle
            alisverisMiktarTextBox.ResetText();
            alisverisMiktarOndalikTextBox.ResetText();

            //Gerisayım'ı durdur, temizle
            islemGeriSayim.Stop();
            geriSayimLabel.Text = "-";

            //Miktar ve karşılığın solundaki logoları temizle
            karsilikLogo.Text = "-";
            miktarLogo.Text = "-";

            // Birim seç yazılarını temizle
            donusturLabel1.Text = "Birim seç";
            donusturLabel2.Text = "Birim seç";

            // Kilidi aç, combobox'ları erişilebilir hale getir.
            kilitAc();

        }

        private void yeniIslemButton_Click(object sender, EventArgs e)
        {
            if (islemTurucomboBox.SelectedIndex != -1 || dovizCinsicomboBox.SelectedIndex != -1)
            {

                DialogResult cikisYap = new DialogResult();
                cikisYap = MessageBox.Show("Kaydedilmemiş veriniz var, silmek ve yeni bir işlem başlatmak istediğinize emin misiniz?", "Yeni işlem", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (cikisYap == DialogResult.OK)
                {
                    // Temizle
                    yeniIslemFormTemizle();
                }
                else
                {
                    // Doldur
                }
            }
        }

        // Düzenlenecek

        string doviz_id;
        string doviz_adi;
        string doviz_tam_adi;
        string doviz_logo;

        string donustur_deger;

        public void islemTamamla()
        {   

            try
            {   //// where kullanici_adi='" + kullanici_adi + "'
                
                // İşlem türünü tespit et kaydet
                string islemTuruIndex;
                if (islemTurucomboBox.Text == "Alış")
                {
                    islemTuruIndex = Convert.ToString(1);
                }
                else
                {
                    islemTuruIndex = Convert.ToString(2);
                }

                //Döviz türünü tespit et

                baglan.Open();
                string selectQuery = "SELECT * FROM dovizotomasyon.doviz";
                MySqlCommand komut3 = new MySqlCommand(selectQuery, baglan);
                string seciliDovizLogo = dovizCinsicomboBox.SelectedItem.ToString();
                seciliDovizLogo = seciliDovizLogo[0].ToString();
                komut3.CommandText = "SELECT * FROM doviz WHERE doviz_logo = '" + seciliDovizLogo + "'";
                oku = komut3.ExecuteReader();

                while (oku.Read())
                {
                    doviz_id = Convert.ToString(oku["doviz_id"]);
                    doviz_adi = Convert.ToString(oku["doviz_adi"]);
                    doviz_tam_adi = Convert.ToString(oku["doviz_tam_adi"]);
                    doviz_logo = Convert.ToString(oku["doviz_logo"]);
                }
                oku.Close();
                baglan.Close();

                // Döviz türünü tespit et tamamlandı


                // Alış satış fiyatını al ve işlem yap
                /* ************
                baglan.Open();
                string degerQuery = "SELECT * FROM dovizotomasyon.deger";
                MySqlCommand komut4 = new MySqlCommand(degerQuery, baglan);
                oku = komut4.ExecuteReader();

                while (oku.Read())
                {
                    if (islemTurucomboBox.Text == "Alış")
                    {
                        komut4.CommandText = "SELECT * FROM deger.alis_fiyat WHERE doviz_id = '" + doviz_id + "'";
                        donustur_deger = Convert.ToString(oku["alis_fiyat"]);
                    }
                    else
                    {
                        komut4.CommandText = "SELECT * FROM deger.satis_fiyat WHERE doviz_id = '" + doviz_id + "'";
                        donustur_deger = Convert.ToString(oku["satis_fiyat"]);
                    }
                }

                oku.Close();
                baglan.Close();

                // *********** 
                */

                // Miktarı kaydet
                baglan.Open();

                decimal tam_kisim = Convert.ToDecimal(alisverisMiktarTextBox.Text);
                decimal ondalik_kisim = Convert.ToDecimal(alisverisMiktarOndalikTextBox.Text);

                // https://stackoverflow.com/questions/4483886/how-can-i-get-a-count-of-the-total-number-of-digits-in-a-number
                // Log10(sayı) bize "sayı"nın kaç basamaklı olduğunu verir (yukarı yuvarlanırsa) 
                double bolme_islemi = Math.Floor(Math.Log10(Convert.ToDouble(ondalik_kisim)) + 1);

                // Örnek : Ondalık sayı 23, karakter sayısı = 2
                // 23 / 10 ^ karakter_sayısı = 0.23
                ondalik_kisim = (ondalik_kisim / Convert.ToInt32(Math.Pow(10,Convert.ToInt32(bolme_islemi))));
                decimal alisverisMiktar = tam_kisim + ondalik_kisim;

                alisverisTest.Text = alisverisMiktar.ToString();
                string insertIslem = "INSERT INTO alısveris(tarih,islem_id, doviz_id, personel_id, miktar) VALUES(NOW()," + islemTuruIndex + "," + doviz_id + "," + personel_id + "," + alisverisMiktar + ");";
                MySqlCommand command = new MySqlCommand(insertIslem, baglan);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                baglan.Close();

                yeniIslemFormTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Döviz türü listesinde hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                baglan.Close();
            }
        }


        private void tamamlaButton_Click(object sender, EventArgs e)
        {
            // https://www.codeproject.com/Questions/496674/EmptyplusTextboxplusValidationplusinplusC-23
            if (alisverisMiktarTextBox.Text.Trim() == string.Empty || alisverisMiktarOndalikTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("İşlem yapabilmek için miktar giriniz", "Tamamla", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Tamamlama işlemlerini burada yap
            else
            {
                islemTamamla();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void islemGeriSayim_Tick(object sender, EventArgs e)
        {
            // https://codingvision.net/miscellaneous/c-countdown-timer
            if (geriSayimLabel.Text == "1")
            {
                //Eğer süre biterse durdur
                islemGeriSayim.Stop();

                MessageBox.Show("Geçerli kur ile işlem yapma süresi aşıldı. İşlem sıfırlanacak.","Zaman aşımı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                yeniIslemFormTemizle();
                geriSayimLabel.Text = "-";
            }

            geriSayimLabel.Text = Convert.ToString((int.Parse(geriSayimLabel.Text) - 1));
        }

        private void alisverisMiktarTextBox_TextChanged(object sender, EventArgs e)
        {
            alisverisMiktarTextBox.Text = alisverisMiktarTextBox.Text.Replace(" ", "");
            alisverisMiktarOndalikTextBox.Text = alisverisMiktarOndalikTextBox.Text.Replace(" ", "");
            //yeni bir değer girildiğinde karşılığını hesapla
            karsilikDegerLabel.Text = "";
        }

        // KULLANICI GİRİŞ FORM VERİLERİ

        bool goster = true;
        private void sifreGosterButton_Click(object sender, EventArgs e)
        {


            if (goster == false)
            {
                sifreGosterButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                goster = true;
                sifreTextBox.PasswordChar = '*';
            }

            else
            {
                sifreGosterButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                goster = false;
                sifreTextBox.PasswordChar = '\0';
            }

        }

        public void KullaniciSQLBaglan()
        {
            string bag;

            MySqlConnectionStringBuilder kur = new MySqlConnectionStringBuilder();

            kur.UserID = "root";
            kur.Password = "12345";
            kur.Database = "dovizotomasyon";
            kur.Server = "localhost";
            kur.PersistSecurityInfo = true;

            bag = kur.ToString();
            baglan = new MySqlConnection(bag);

            baglan.Open();


        }

        MySqlDataReader oku;

        private string kullanici_adi;
        private string sifre;

        private string personel_id;
        private string yetki_id;
        private string ad;
        private string soyad;
        private string kullanici_adi_kaydet;


        public bool KullaniciSifre()
        {

            try
            {   // https://www.yazilimkodlama.com/c-2/c-mysql-baglantisi-ile-basit-login-form-ornegi/
                KullaniciSQLBaglan();
                string selectQuery = "SELECT * FROM dovizotomasyon.personel";
                MySqlCommand komut = new MySqlCommand(selectQuery, baglan);

                kullanici_adi = kullaniciTextBox.Text;
                // Boşlukları sil
                kullanici_adi = kullanici_adi.Replace(" ", String.Empty);
                sifre = sifreTextBox.Text;

                komut.CommandText = "SELECT * FROM dovizotomasyon.personel where kullanici_adi='" + kullanici_adi + "' AND sifre='" + sifre + "'";

                oku = komut.ExecuteReader();

                // Şifre ve kullanıcı adı doğruysa
                if (oku.Read())
                {   
                    
                    MessageBox.Show("Giriş başarılı", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglan.Close();
                    baglan.Open();
                    MySqlCommand komut2 = new MySqlCommand(selectQuery, baglan);
                    komut2.CommandText = "SELECT * FROM personel WHERE kullanici_adi = '" + kullanici_adi + "'";
                    MySqlDataReader oku;
                    oku = komut2.ExecuteReader();
                    //***
                    while (oku.Read())
                    {
                        personel_id = Convert.ToString(oku["personel_id"]);
                        yetki_id = Convert.ToString(oku["yetki_id"]);
                        ad = Convert.ToString(oku["ad"]);
                        soyad = Convert.ToString(oku["personel_id"]);
                        kullanici_adi_kaydet = Convert.ToString(oku["kullanici_adi"]);

                    }
                    oku.Close();
                    //**

                    BasariliGiris();
                    baglan.Close();

                    TopPanel.Visible = true;
                    //alisSatisMainPanel.Visible = true;
                    kullaniciButon_Sifirla();
                    return true;
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglan.Close();
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanında hata! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            finally
            {
                baglan.Close();
            }

        }

        public void BasariliGiris()
        {
            this.girisYapPanel.Visible = false;
            this.girisYapPanel.Enabled = false;
            kullaniciAdiTopLabel.Text = kullanici_adi_kaydet;
            TopPanel.Visible = true; 
        }

        private void girisButton_Click(object sender, EventArgs e)
        {


            // https://www.codeproject.com/Questions/496674/EmptyplusTextboxplusValidationplusinplusC-23
            if (kullaniciTextBox.Text.Trim() == string.Empty && sifreTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (sifreTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Şifre giriniz", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (kullaniciTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı giriniz", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                KullaniciSQLBaglan();
                KullaniciSifre();
            }

        }

        // Boşluklara izin verme
        private void kullaniciTextBox_TextChanged(object sender, EventArgs e)
        {
            kullaniciTextBox.Text = kullaniciTextBox.Text.Replace(" ", "");
        }

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {
            sifreTextBox.Text = sifreTextBox.Text.Replace(" ", "");
        }

        // KULLANICI GİRİŞ FORM VERİLERİ

    }
}



        