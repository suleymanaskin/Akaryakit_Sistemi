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
    public partial class Akaryakit_Odeme : Form
    {
        public Akaryakit_Odeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_ad.Text) == true)
            {
                MessageBox.Show("Ad Soyad Boş Geçilemez");
                return;
            }
            if (mtbx_kartNumarasi.MaskFull == false)
            {
                MessageBox.Show("Kart Numarası Eksik");
                return;
            }
            if (mtbx_cvv.MaskFull == false)
            {
                MessageBox.Show("CVV Eksik");
                return;
            }
            Akaryakit_Kapanis yakitForm = new Akaryakit_Kapanis();
            yakitForm.ShowDialog();
            this.Hide();
        }

        private void Akaryakit_Odeme_Load(object sender, EventArgs e)
        {

        }
    }
}
