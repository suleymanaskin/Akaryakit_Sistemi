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
    public partial class Akaryakit_Secim : Form
    {
        public Akaryakit_Secim()
        {
            InitializeComponent();
        }
        double benzin,mazot,lpg;

        private void Akaryakit_Secim_Load(object sender, EventArgs e)
        {
            benzin = 63.76;
            mazot = 76.27;
            lpg = 30.29;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplamTutar = 0;
            if (!int.TryParse(tbx_girilenLitre.Text, out int girilenMiktar))
            {
                MessageBox.Show("Lütfen geçerli bir litre miktarı giriniz!");
                return;
            }


            if (rb_benzin.Checked)
            {
                toplamTutar = benzin * girilenMiktar;
            }
            else if (rb_mazot.Checked)
            {
                toplamTutar = mazot * girilenMiktar;
            }
            else if (rb_lpg.Checked)
            {
                toplamTutar = lpg * girilenMiktar;
            }
            else
            {
                MessageBox.Show("Lütfen bir yakıt türü seçiniz!");
                return; 
            }
            Akaryakit_Yukleme yakitForm = new Akaryakit_Yukleme(toplamTutar);
            yakitForm.ShowDialog();
            this.Hide();

        }
    }
}
