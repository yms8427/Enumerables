namespace BilgeAdam.Enumerables
{
    partial class frmMain
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
            this.lstDuz = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSilDuz = new System.Windows.Forms.Button();
            this.btnEkleDuz = new System.Windows.Forms.Button();
            this.txtDuz = new System.Windows.Forms.TextBox();
            this.erpWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDuzTemizle = new System.Windows.Forms.Button();
            this.lstBaglanti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaglantiEkle = new System.Windows.Forms.Button();
            this.btnBaglantiSil = new System.Windows.Forms.Button();
            this.txtBaglanti = new System.Windows.Forms.TextBox();
            this.lstCoklu = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCokluSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDuz
            // 
            this.lstDuz.FormattingEnabled = true;
            this.lstDuz.Location = new System.Drawing.Point(12, 25);
            this.lstDuz.Name = "lstDuz";
            this.lstDuz.Size = new System.Drawing.Size(154, 212);
            this.lstDuz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Düz";
            // 
            // btnSilDuz
            // 
            this.btnSilDuz.Location = new System.Drawing.Point(93, 272);
            this.btnSilDuz.Name = "btnSilDuz";
            this.btnSilDuz.Size = new System.Drawing.Size(75, 23);
            this.btnSilDuz.TabIndex = 2;
            this.btnSilDuz.Text = "Sil";
            this.btnSilDuz.UseVisualStyleBackColor = true;
            this.btnSilDuz.Click += new System.EventHandler(this.btnSilDuz_Click);
            // 
            // btnEkleDuz
            // 
            this.btnEkleDuz.Location = new System.Drawing.Point(12, 272);
            this.btnEkleDuz.Name = "btnEkleDuz";
            this.btnEkleDuz.Size = new System.Drawing.Size(75, 23);
            this.btnEkleDuz.TabIndex = 2;
            this.btnEkleDuz.Text = "Ekle";
            this.btnEkleDuz.UseVisualStyleBackColor = true;
            this.btnEkleDuz.Click += new System.EventHandler(this.btnEkleDuz_Click);
            // 
            // txtDuz
            // 
            this.txtDuz.Location = new System.Drawing.Point(12, 243);
            this.txtDuz.Name = "txtDuz";
            this.txtDuz.Size = new System.Drawing.Size(154, 20);
            this.txtDuz.TabIndex = 3;
            this.txtDuz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDuz_KeyDown);
            // 
            // erpWarning
            // 
            this.erpWarning.ContainerControl = this;
            // 
            // btnDuzTemizle
            // 
            this.btnDuzTemizle.Location = new System.Drawing.Point(12, 301);
            this.btnDuzTemizle.Name = "btnDuzTemizle";
            this.btnDuzTemizle.Size = new System.Drawing.Size(154, 23);
            this.btnDuzTemizle.TabIndex = 4;
            this.btnDuzTemizle.Text = "Temizle";
            this.btnDuzTemizle.UseVisualStyleBackColor = true;
            this.btnDuzTemizle.Click += new System.EventHandler(this.btnDuzTemizle_Click);
            // 
            // lstBaglanti
            // 
            this.lstBaglanti.FormattingEnabled = true;
            this.lstBaglanti.Location = new System.Drawing.Point(203, 25);
            this.lstBaglanti.Name = "lstBaglanti";
            this.lstBaglanti.Size = new System.Drawing.Size(154, 212);
            this.lstBaglanti.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veri Bağlantısı";
            // 
            // btnBaglantiEkle
            // 
            this.btnBaglantiEkle.Location = new System.Drawing.Point(203, 272);
            this.btnBaglantiEkle.Name = "btnBaglantiEkle";
            this.btnBaglantiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBaglantiEkle.TabIndex = 7;
            this.btnBaglantiEkle.Text = "Ekle";
            this.btnBaglantiEkle.UseVisualStyleBackColor = true;
            this.btnBaglantiEkle.Click += new System.EventHandler(this.btnBaglantiEkle_Click);
            // 
            // btnBaglantiSil
            // 
            this.btnBaglantiSil.Location = new System.Drawing.Point(284, 272);
            this.btnBaglantiSil.Name = "btnBaglantiSil";
            this.btnBaglantiSil.Size = new System.Drawing.Size(75, 23);
            this.btnBaglantiSil.TabIndex = 8;
            this.btnBaglantiSil.Text = "Sil";
            this.btnBaglantiSil.UseVisualStyleBackColor = true;
            // 
            // txtBaglanti
            // 
            this.txtBaglanti.Location = new System.Drawing.Point(203, 243);
            this.txtBaglanti.Name = "txtBaglanti";
            this.txtBaglanti.Size = new System.Drawing.Size(154, 20);
            this.txtBaglanti.TabIndex = 9;
            // 
            // lstCoklu
            // 
            this.lstCoklu.FormattingEnabled = true;
            this.lstCoklu.Location = new System.Drawing.Point(397, 25);
            this.lstCoklu.Name = "lstCoklu";
            this.lstCoklu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCoklu.Size = new System.Drawing.Size(156, 212);
            this.lstCoklu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Çoklu İşlemler";
            // 
            // btnCokluSil
            // 
            this.btnCokluSil.Location = new System.Drawing.Point(397, 243);
            this.btnCokluSil.Name = "btnCokluSil";
            this.btnCokluSil.Size = new System.Drawing.Size(156, 23);
            this.btnCokluSil.TabIndex = 12;
            this.btnCokluSil.Text = "Seçilenleri Sil";
            this.btnCokluSil.UseVisualStyleBackColor = true;
            this.btnCokluSil.Click += new System.EventHandler(this.btnCokluSil_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 337);
            this.Controls.Add(this.btnCokluSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCoklu);
            this.Controls.Add(this.txtBaglanti);
            this.Controls.Add(this.btnBaglantiSil);
            this.Controls.Add(this.btnBaglantiEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBaglanti);
            this.Controls.Add(this.btnDuzTemizle);
            this.Controls.Add(this.txtDuz);
            this.Controls.Add(this.btnEkleDuz);
            this.Controls.Add(this.btnSilDuz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDuz);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listeler";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDuz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSilDuz;
        private System.Windows.Forms.Button btnEkleDuz;
        private System.Windows.Forms.TextBox txtDuz;
        private System.Windows.Forms.ErrorProvider erpWarning;
        private System.Windows.Forms.Button btnDuzTemizle;
        private System.Windows.Forms.TextBox txtBaglanti;
        private System.Windows.Forms.Button btnBaglantiSil;
        private System.Windows.Forms.Button btnBaglantiEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBaglanti;
        private System.Windows.Forms.Button btnCokluSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCoklu;
    }
}

