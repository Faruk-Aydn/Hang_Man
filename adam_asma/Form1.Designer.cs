namespace Hang_Man
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblYanlisHarfler;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblTitle; // Başlık etiketi
        private System.Windows.Forms.Panel pnlTitle; // Başlık paneli

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblYanlisHarfler = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label(); // Başlık etiketi
            this.pnlTitle = new System.Windows.Forms.Panel(); // Başlık paneli
            this.SuspendLayout();

            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(584, 50);
            this.pnlTitle.TabIndex = 6;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(200, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Hang Man";

            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(300, 150);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(50, 20);
            this.txtHarf.TabIndex = 0;

            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(300, 200);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.BackColor = System.Drawing.Color.LightGray;
            this.btnKontrol.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnKontrol.Click += new System.EventHandler(this.BtnKontrol_Click);

            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelime.Location = new System.Drawing.Point(250, 100); // Oyun öğelerini biraz aşağıya çektik
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(103, 36);
            this.lblKelime.TabIndex = 2;
            this.lblKelime.Text = "______";

            // 
            // lblYanlisHarfler
            // 
            this.lblYanlisHarfler.AutoSize = true;
            this.lblYanlisHarfler.Location = new System.Drawing.Point(300, 250);
            this.lblYanlisHarfler.Name = "lblYanlisHarfler";
            this.lblYanlisHarfler.Size = new System.Drawing.Size(75, 13);
            this.lblYanlisHarfler.TabIndex = 3;
            this.lblYanlisHarfler.Text = "Yanlış Harfler: ";

            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(300, 280);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(47, 13);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "Skor: 0";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblYanlisHarfler);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.txtHarf);
            this.Name = "Form1";
            this.Text = "Adam Asmaca - Türkiye Şehirleri";
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
