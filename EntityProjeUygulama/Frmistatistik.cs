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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBL_KATEGORİ.Count().ToString();
            label3.Text = db.TBL_URUN.Count().ToString();
            label5.Text = db.TBL_MUSTERI.Count(x => x.DURUM == true).ToString();
            label7.Text = db.TBL_MUSTERI.Count(x => x.DURUM == false).ToString();
            label13.Text = db.TBL_URUN.Sum(y => y.STOK).ToString();
            label21.Text = db.TBL_SATIS.Sum(z => z.FİYAT).ToString() + " TL ";
            label11.Text = (from x in db.TBL_URUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            label9.Text = (from x in db.TBL_URUN orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            label15.Text = db.TBL_URUN.Count(x => x.KATEGORİ == 1).ToString();
            label17.Text = db.TBL_URUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.TBL_MUSTERI select x.SEHİR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETİR().FirstOrDefault();
            
            
        }
    }
}
