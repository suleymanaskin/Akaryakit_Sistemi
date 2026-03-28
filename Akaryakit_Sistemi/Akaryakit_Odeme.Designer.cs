namespace Akaryakit_Sistemi
{
    partial class Akaryakit_Odeme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_ad = new System.Windows.Forms.TextBox();
            this.mtbx_kartNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_cvv = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odeme Sayfasına Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(118, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kart Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Güvenlik Kodu / CVV";
            // 
            // tbx_ad
            // 
            this.tbx_ad.Location = new System.Drawing.Point(236, 98);
            this.tbx_ad.Name = "tbx_ad";
            this.tbx_ad.Size = new System.Drawing.Size(100, 20);
            this.tbx_ad.TabIndex = 4;
            // 
            // mtbx_kartNumarasi
            // 
            this.mtbx_kartNumarasi.Location = new System.Drawing.Point(236, 125);
            this.mtbx_kartNumarasi.Mask = "0000000000000000";
            this.mtbx_kartNumarasi.Name = "mtbx_kartNumarasi";
            this.mtbx_kartNumarasi.Size = new System.Drawing.Size(100, 20);
            this.mtbx_kartNumarasi.TabIndex = 5;
            // 
            // mtbx_cvv
            // 
            this.mtbx_cvv.Location = new System.Drawing.Point(236, 154);
            this.mtbx_cvv.Mask = "000";
            this.mtbx_cvv.Name = "mtbx_cvv";
            this.mtbx_cvv.Size = new System.Drawing.Size(27, 20);
            this.mtbx_cvv.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(181, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Akaryakit_Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbx_cvv);
            this.Controls.Add(this.mtbx_kartNumarasi);
            this.Controls.Add(this.tbx_ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Akaryakit_Odeme";
            this.Text = "Akaryakit_Odeme";
            this.Load += new System.EventHandler(this.Akaryakit_Odeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_ad;
        private System.Windows.Forms.MaskedTextBox mtbx_kartNumarasi;
        private System.Windows.Forms.MaskedTextBox mtbx_cvv;
        private System.Windows.Forms.Button button1;
    }
}