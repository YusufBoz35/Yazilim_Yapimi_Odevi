
namespace Yazilim_Yapimi
{
    partial class Form4
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
            this.BtnParaEkle = new System.Windows.Forms.Button();
            this.BtnAlim = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnParaEkle
            // 
            this.BtnParaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnParaEkle.Location = new System.Drawing.Point(71, 260);
            this.BtnParaEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnParaEkle.Name = "BtnParaEkle";
            this.BtnParaEkle.Size = new System.Drawing.Size(212, 59);
            this.BtnParaEkle.TabIndex = 0;
            this.BtnParaEkle.Text = "Hesabınıza Para Ekleme";
            this.BtnParaEkle.UseVisualStyleBackColor = true;
            this.BtnParaEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAlim
            // 
            this.BtnAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlim.Location = new System.Drawing.Point(71, 196);
            this.BtnAlim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAlim.Name = "BtnAlim";
            this.BtnAlim.Size = new System.Drawing.Size(212, 59);
            this.BtnAlim.TabIndex = 1;
            this.BtnAlim.Text = "Alım Yapma";
            this.BtnAlim.UseVisualStyleBackColor = true;
            this.BtnAlim.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunEkle.Location = new System.Drawing.Point(71, 324);
            this.BtnUrunEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(212, 59);
            this.BtnUrunEkle.TabIndex = 2;
            this.BtnUrunEkle.Text = "Hesabınıza Ürün Ekleme";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Maroon;
            this.BtnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Location = new System.Drawing.Point(637, 12);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(149, 62);
            this.BtnKapat.TabIndex = 3;
            this.BtnKapat.Text = "Güvenli Çıkış";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hosgeldiniz";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.BtnAlim);
            this.Controls.Add(this.BtnParaEkle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnParaEkle;
        private System.Windows.Forms.Button BtnAlim;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Label label1;
    }
}