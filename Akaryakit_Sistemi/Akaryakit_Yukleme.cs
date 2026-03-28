using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakit_Sistemi
{
    public partial class Akaryakit_Yukleme : Form
    {
        double gelenTutar;
        public Akaryakit_Yukleme(double tutar)
        {
            InitializeComponent();
            gelenTutar = tutar;
        }
        private void Akaryakit_Yukleme_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            btn_odeme.Enabled = false;  
            label2.Text = "Yakıt Yükleniyor";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Yakıt Yükleniyor %25";
            label2.ForeColor = Color.Green; 
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "Yakıt Yükleniyor %50";
            label2.ForeColor = Color.Green;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = "Yakıt Yükleniyor %75";
            label2.ForeColor = Color.Green;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = "Yakıt Başarıyla Yüklendi";
            label2.ForeColor = Color.Green;
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label3.Text = "Yakıt Tutarınız Aşağıdadır";
            lbl_yakitTutar.Text = gelenTutar.ToString() + " TL";
            btn_odeme.Enabled = true;  
        }

        private void btn_odeme_Click(object sender, EventArgs e)
        {
            Akaryakit_Odeme yakitForm = new Akaryakit_Odeme();
            yakitForm.ShowDialog();
            this.Hide();
        }
    }
}
