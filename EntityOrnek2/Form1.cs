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
            var degerler = db.TBLOGRENCİ.OrderBy(x => x.SEHİR).GroupBy(y => y.SEHİR).
                Select(z => new { Sehir = z.Key, Toplam = z.Count() });
            dataGridView1.DataSource = degerler.ToList();
        }
    }
}
