
namespace Siralayici
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDizin = new System.Windows.Forms.TextBox();
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.fbdDizin = new System.Windows.Forms.FolderBrowserDialog();
            this.lstDosyaAdlari = new System.Windows.Forms.ListBox();
            this.btnDosyaAdlariniSayilastir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDizin
            // 
            this.txtDizin.Location = new System.Drawing.Point(14, 14);
            this.txtDizin.Margin = new System.Windows.Forms.Padding(5);
            this.txtDizin.Name = "txtDizin";
            this.txtDizin.Size = new System.Drawing.Size(564, 32);
            this.txtDizin.TabIndex = 0;
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(14, 56);
            this.btnKlasorSec.Margin = new System.Windows.Forms.Padding(5);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(564, 38);
            this.btnKlasorSec.TabIndex = 1;
            this.btnKlasorSec.Text = "Klasör Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // lstDosyaAdlari
            // 
            this.lstDosyaAdlari.FormattingEnabled = true;
            this.lstDosyaAdlari.ItemHeight = 25;
            this.lstDosyaAdlari.Location = new System.Drawing.Point(14, 102);
            this.lstDosyaAdlari.Name = "lstDosyaAdlari";
            this.lstDosyaAdlari.Size = new System.Drawing.Size(564, 329);
            this.lstDosyaAdlari.TabIndex = 2;
            // 
            // btnDosyaAdlariniSayilastir
            // 
            this.btnDosyaAdlariniSayilastir.Location = new System.Drawing.Point(14, 438);
            this.btnDosyaAdlariniSayilastir.Name = "btnDosyaAdlariniSayilastir";
            this.btnDosyaAdlariniSayilastir.Size = new System.Drawing.Size(564, 63);
            this.btnDosyaAdlariniSayilastir.TabIndex = 3;
            this.btnDosyaAdlariniSayilastir.Text = "Dosya Adlarıını 1,2,3, ... Şeklinde Değiştir";
            this.btnDosyaAdlariniSayilastir.UseVisualStyleBackColor = true;
            this.btnDosyaAdlariniSayilastir.Click += new System.EventHandler(this.btnDosyaAdlariniSayilastir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 511);
            this.Controls.Add(this.btnDosyaAdlariniSayilastir);
            this.Controls.Add(this.lstDosyaAdlari);
            this.Controls.Add(this.btnKlasorSec);
            this.Controls.Add(this.txtDizin);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Klasör İçindeki Dosyaları Sıralayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDizin;
        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.FolderBrowserDialog fbdDizin;
        private System.Windows.Forms.ListBox lstDosyaAdlari;
        private System.Windows.Forms.Button btnDosyaAdlariniSayilastir;
    }
}

