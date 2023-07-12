using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntityProjeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBL_KATEGORİ.ToList();
            dataGridView1.DataSource = kategoriler; 
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBL_KATEGORİ t = new TBL_KATEGORİ();
            t.AD = textBox2.Text;
            db.TBL_KATEGORİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBL_KATEGORİ.Find(x);                   
            db.TBL_KATEGORİ.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kaydınız Silinmiştir.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBL_KATEGORİ.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapılmıştır.");
        }
    }
}
