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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void BtnDersListele_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db=new DbSinavOgrenciEntities();
           // DbSinavOgrenciEntities bizim modelimiz ve bu model aracılığıyla db isimli bir nesne oluşturduk.

            dataGridView1.DataSource = db.TBLDERSLER.ToList();
            //db nesnemizin aracılığıyla da dersler listesini  dataGridView kaynağına akatarmış olduk.
        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db= new DbSinavOgrenciEntities();    
            dataGridView1.DataSource= db.TBLOGRENCİ.ToList();

            //Öğrenci listesi geldiğinde fotoğraf ve tblnotlar kısmının gözükmesini istemiyorum. O halde şunları uygulayalım.
            dataGridView1.Columns[3].Visible = false; //3 fotoğraflar kısmını temsil ediyor.
            dataGridView1.Columns[4].Visible = false; //4 tblnotlar kısmını temsil ediyor.
            
        }














        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
