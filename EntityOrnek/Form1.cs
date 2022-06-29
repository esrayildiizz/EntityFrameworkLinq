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

namespace EntityOrnek
{
    public partial class Form1 : Form
    {

        
 
         Form2 frm = new Form2();  //Öncelikle bir değişken tanımlıyoruz...

        //Yeni Form eklemek Project Menüsünden Add Windows Form'a tıklıyoruz,
        //karşımıza gelen ekranda Add diyerek yeni bir Form ekliyoruz
        //Project/Add Windows Form//Add

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz

           
        }



        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnDersListele_Click(object sender, EventArgs e)
        {

            // En üstte DbSinavOgrenciEntities bizim modelimiz ve bu model aracılığıyla db isimli bir nesne oluşturduk.

            dataGridView1.DataSource = db.TBLDERSLER.ToList();
            //db nesnemizin aracılığıyla da dersler listesini  dataGridView kaynağına akatarmış olduk.
        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.TBLOGRENCİ.ToList();

            //Öğrenci listesi geldiğinde fotoğraf ve tblnotlar kısmının gözükmesini istemiyorum. O halde şunları uygulayalım.
            dataGridView1.Columns[3].Visible = false; //3 fotoğraflar kısmını temsil ediyor.
            dataGridView1.Columns[4].Visible = false; //4 tblnotlar kısmını temsil ediyor.

        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNOTLAR
                        select new { item.NOTID, item.OGR, item.DERS, item.SINAV1, item.SINAV2, item.SINAV3, item.ORTALAMA, item.DURUM };
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource=db.TBLNOTLAR.ToList();

        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCİ t = new TBLOGRENCİ();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            db.TBLOGRENCİ.Add(t);
            db.SaveChanges();   //Değişiklikleri kaydedip bunları veri tabanına yansıt.
            MessageBox.Show("Öğrenci Listeye Eklenmiştir.");

        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.TBLOGRENCİ.Find(id); // veri tabanında id ile ilgili alanı bulma.

            db.TBLOGRENCİ.Remove(x); //silme işlemi
            db.SaveChanges(); //Değişiklikleri kaydedip bunları veri tabanına yansıt.
            MessageBox.Show("Öğrenci Listeden Silinmiştir.");

        }


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.TBLOGRENCİ.Find(id);

            x.AD = TxtAd.Text;
            x.SOYAD = TxtSoyad.Text;
            x.FOTOGRAF = TxtFoto.Text;

            db.SaveChanges(); //Değişiklikleri kaydedip bunları veri tabanına yansıt.
            MessageBox.Show("Öğrenci Listesi Güncellenmiştir."); //Ekranda gözükecek olan kutucuğun içinde yazan.
        }







        // Buraya rosedür komutlarını eklemeden önce sql de komutları şu şekilde yazdık.

        //CREATE PROCEDURE NOTLİSTESİ
        // AS
        //select   NOTID ,AD+ ' ' + SOYAD AS 'AD-SOYAD' , DERSAD, DERS, SINAV1, SINAV2, SINAV3, ORTALAMA, DURUM from TBLNOTLAR inner join TBLOGRENCİ
        //ON TBLOGRENCİ.ID=TBLNOTLAR.OGR
        //inner join TBLDERSLER ON TBLDERSLER.DERSID=TBLNOTLAR.DERS
        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLİSTESİ();
        }



        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCİ.Where(x => x.AD == TxtAd.Text | x.SOYAD == TxtSoyad.Text).ToList();
        }


        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

            string aranan = TxtAd.Text;
            var degerler = from item in db.TBLOGRENCİ
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();


            //aranan textbox ıma eşit olan item ları getir bu item ları değerlere aktar daha sonra datagrid de bu değerleri listele.

            //Ogrenci de ad kısmına ne yazarsam onunla es deger olan ifadeler dataGridView1 de önümüze gelecektir.(Harf bile olsa es deger karşımıza gelir.)      
        }



        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) //Eğerki radiobutton işaretlenmiş ise ;
            {
                //Asc-Ascending  (A dan Zye)
                List<TBLOGRENCİ> liste1 = db.TBLOGRENCİ.OrderBy(x => x.AD).ToList();
                //Burada ad'a göre a dan z ye sıralama işlemi yapıldı.
                dataGridView1.DataSource = liste1.ToList();
            }

            if (radioButton2.Checked == true)
            {
                //Dsc-Descending (Z den A ya)
                List<TBLOGRENCİ> liste2 = db.TBLOGRENCİ.OrderByDescending(x => x.AD).ToList();
                dataGridView1.DataSource = liste2.ToList();
            }

            if (radioButton3.Checked == true)
            {
                //İlk 3 kaydın gelmesi için gerekli komutlar.
                List<TBLOGRENCİ> liste3 = db.TBLOGRENCİ.OrderBy(x => x.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3.ToList();
            }

            if (radioButton4.Checked == true)
            {
                //ID ye göre veri getir.
                List<TBLOGRENCİ> liste4 = db.TBLOGRENCİ.Where(x => x.ID == 5).ToList();
                dataGridView1.DataSource = liste4.ToList();
            }

            if (radioButton5.Checked == true)
            {
                //Adı a ile başlayanları listele.
                List<TBLOGRENCİ> liste5 = db.TBLOGRENCİ.Where(x => x.AD.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5.ToList();
            }

            if (radioButton6.Checked == true)
            {
                //Adı a ile bitenleri listele.
                List<TBLOGRENCİ> liste6 = db.TBLOGRENCİ.Where(x => x.AD.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste6.ToList();
            }

            if (radioButton7.Checked == true)
            {
                //TBLKULUPLER'de değer varmı varsa ekranda true yazsın yoksa ekranda false yazsın.
                //TBLKULUPLER yazdığımızda ekranda false yazıyor.Çünkü kulupler tablosuna değer girişi yapmadık.
                //TBLOGRENCİ yazdığımızda ekranda true yazıyor.
                bool deger = db.TBLKULUPLER.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            if(radioButton8.Checked == true)
            {
                //Count =say demek.
                int toplam = db.TBLOGRENCİ.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if( radioButton9.Checked == true)
            {
                //Sum= topla demek.
                var toplam = db.TBLNOTLAR.Sum(x => x.SINAV1);
                MessageBox.Show(toplam.ToString(), "SINAV1 PUAN TOPLAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton10.Checked == true)
            {
                //Average=ortalama al deme.
                var ortalama = db.TBLNOTLAR.Average(x => x.SINAV1);
                MessageBox.Show(ortalama.ToString(), "SINAV1 PUAN ORTALAMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCİ
                        on d1.OGR equals d2.ID
                        select new
                        {
                            ÖğrenciAd=d2.AD,
                            ÖğrenciSoyad=d2.SOYAD,
                            SINAV1=d1.SINAV1,
                            SINAV2=d1.SINAV2,
                            SINAV3=d1.SINAV3,
                            Ortalama=d1.ORTALAMA,

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

       
    }


}
