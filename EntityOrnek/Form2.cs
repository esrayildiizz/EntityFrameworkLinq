using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DbSinavOgrenciEntities db=new DbSinavOgrenciEntities(); 
        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //TBLNOTLAR tablosuna kısıtlama getirdik.
                var degerler = db.TBLNOTLAR.Where(x => x.SINAV1 < 50);
                dataGridView1.DataSource=degerler.ToList();
            }

            if (radioButton2.Checked == true)
            {

               //TBLOGRENCİ tablosundan adı ali olanı getir.
                var degerler = db.TBLOGRENCİ.Where(x => x.AD=="Ali");
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton3.Checked == true)
            {
                //Adı veya Soyadı textbox dan al.
                var degerler = db.TBLOGRENCİ.Where(x => x.AD == textBox1.Text || x.SOYAD==textBox1.Text);
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton4.Checked == true)
            {
                //sadece soyadı getir. new tanımladık.
                var degerler = db.TBLOGRENCİ.Select(x => new { Soyadı = x.SOYAD });
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton5.Checked == true)
            {
                //Adı büyük soyadı küçük getir.
                var degerler = db.TBLOGRENCİ.Select(x => new {Ad=x.AD.ToUpper(), Soyad = x.SOYAD.ToLower() });
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton6.Checked == true)
            {
                //Adı büyük soyadı küçük getir.ve şartımşu ali haricindekileri getir.
                var degerler = db.TBLOGRENCİ.Select(x => new { Ad = x.AD.ToUpper(), Soyad = x.SOYAD.ToLower() }).Where(x=>x.Ad !="ali");
                dataGridView1.DataSource = degerler.ToList();
            }
        }
    }
}
