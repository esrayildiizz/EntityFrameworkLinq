using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //GroupBy
            //var degerler = db.TBLOGRENCİ.OrderBy(x => x.SEHİR).GroupBy(y => y.SEHİR).
            //    Select(z => new { Sehir = z.Key, Toplam = z.Count() });
            //dataGridView1.DataSource = degerler.ToList();



            //Max|Min
            // label1.Text = db.TBLNOTLAR.Max(x => x.ORTALAMA).ToString(); 
            //label1.Text = db.TBLNOTLAR.Min(x => x.SINAV1).ToString();



            //Count
            //label1.Text = db.TBLURUN.Count().ToString();
            //label1.Text=db.TBLURUN.Count(x=>x.AD=="BUZDOLABI").ToString();



            //Sum
            //label1.Text=db.TBLURUN.Sum(x=>x.STOK).ToString();   



            //Average
            label1.Text=db.TBLURUN.Average(x=>x.FIYAT).ToString();  






        }


    }
}
