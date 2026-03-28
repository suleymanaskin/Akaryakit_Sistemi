using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakit_Sistemi
{
    public partial class Akaryakit_Kapanis : Form
    {
        public Akaryakit_Kapanis()
        {
            InitializeComponent();
        }
        private void Akaryakit_Kapanis_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            lbl_odemeAl.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_odemeAl.Text = "Odeme Alınıyor";
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_odemeAl.Text = "Ödeme İşlemi Tamamlandı";
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbl_odemeAl.Text = "İşlem Başarılı";
            lbl_odemeAl.ForeColor = Color.Green;    
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lbl_odemeAl.Text = "Fiş Yazdırılıyor";
            lbl_odemeAl.ForeColor = Color.Green;
            timer4.Stop();
            

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
