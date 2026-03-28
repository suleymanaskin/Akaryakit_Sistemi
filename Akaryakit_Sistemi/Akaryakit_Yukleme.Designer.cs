namespace Akaryakit_Sistemi
{
    partial class Akaryakit_Yukleme
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lbl_yakitTutar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.btn_odeme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yakıtınız Yükleniyor .....";
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 2500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 3500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lbl_yakitTutar
            // 
            this.lbl_yakitTutar.AutoSize = true;
            this.lbl_yakitTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yakitTutar.Location = new System.Drawing.Point(337, 153);
            this.lbl_yakitTutar.Name = "lbl_yakitTutar";
            this.lbl_yakitTutar.Size = new System.Drawing.Size(0, 20);
            this.lbl_yakitTutar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(270, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 3;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // timer5
            // 
            this.timer5.Interval = 4000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btn_odeme
            // 
            this.btn_odeme.Location = new System.Drawing.Point(341, 226);
            this.btn_odeme.Name = "btn_odeme";
            this.btn_odeme.Size = new System.Drawing.Size(92, 44);
            this.btn_odeme.TabIndex = 4;
            this.btn_odeme.Text = "Odeme Yap";
            this.btn_odeme.UseVisualStyleBackColor = true;
            this.btn_odeme.Click += new System.EventHandler(this.btn_odeme_Click);
            // 
            // Akaryakit_Yukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_odeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_yakitTutar);
            this.Controls.Add(this.label2);
            this.Name = "Akaryakit_Yukleme";
            this.Text = "Akaryakit_Yukleme";
            this.Load += new System.EventHandler(this.Akaryakit_Yukleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lbl_yakitTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button btn_odeme;
    }
}