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
    public partial class Akaryakit_Sistemi_PlakaGiris : Form
    {
        public Akaryakit_Sistemi_PlakaGiris()
        {
            InitializeComponent();
        }
        List<string> plakaVeritabani = new List<string> { "34ABC123", "06ANK06" };
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string girilenPlaka =tbx_plakaGiris.Text.Trim().ToUpper();

            
            if (string.IsNullOrEmpty(girilenPlaka))
            {
                MessageBox.Show("Lütfen bir plaka giriniz!");
                return;
            }

            
            if (!plakaVeritabani.Contains(girilenPlaka))
            {
                
                plakaVeritabani.Add(girilenPlaka);
                MessageBox.Show(girilenPlaka + " plakası ilk kez görüldü. Yeni kayıt oluşturuldu");
            }
            else
            {
                MessageBox.Show(girilenPlaka + " plakası sistemde kayıtlı Hoş geldiniz");
            }
            Akaryakit_Secim yakitForm = new Akaryakit_Secim();
            yakitForm.Show();
            this.Hide();
        }

        private void Akaryakit_Sistemi_PlakaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
