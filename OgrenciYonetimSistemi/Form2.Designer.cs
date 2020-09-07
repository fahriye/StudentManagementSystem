namespace OgrenciYonetimSistemi
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öĞRENCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖğrenciEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERSLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTHESAPLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİNOTLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİToolStripMenuItem,
            this.dERSLERToolStripMenuItem,
            this.nOTLARToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1116, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öĞRENCİToolStripMenuItem
            // 
            this.öĞRENCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÖğrenciEklemeToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.öĞRENCİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öĞRENCİToolStripMenuItem.Name = "öĞRENCİToolStripMenuItem";
            this.öĞRENCİToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.öĞRENCİToolStripMenuItem.Text = "ÖĞRENCİ";
            // 
            // yeniÖğrenciEklemeToolStripMenuItem
            // 
            this.yeniÖğrenciEklemeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yeniÖğrenciEklemeToolStripMenuItem.Name = "yeniÖğrenciEklemeToolStripMenuItem";
            this.yeniÖğrenciEklemeToolStripMenuItem.Size = new System.Drawing.Size(335, 32);
            this.yeniÖğrenciEklemeToolStripMenuItem.Text = "Yeni Öğrenci Ekleme/Silme";
            this.yeniÖğrenciEklemeToolStripMenuItem.Click += new System.EventHandler(this.yeniÖğrenciEklemeToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.öğrenciListesiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(335, 32);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(335, 32);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // dERSLERToolStripMenuItem
            // 
            this.dERSLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersListesiToolStripMenuItem});
            this.dERSLERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dERSLERToolStripMenuItem.Name = "dERSLERToolStripMenuItem";
            this.dERSLERToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.dERSLERToolStripMenuItem.Text = "FAKÜLTELER";
            // 
            // dersListesiToolStripMenuItem
            // 
            this.dersListesiToolStripMenuItem.Name = "dersListesiToolStripMenuItem";
            this.dersListesiToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.dersListesiToolStripMenuItem.Text = "FAKÜLTELER LİSTESİ";
            this.dersListesiToolStripMenuItem.Click += new System.EventHandler(this.dersListesiToolStripMenuItem_Click);
            // 
            // nOTLARToolStripMenuItem
            // 
            this.nOTLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOTHESAPLAMAToolStripMenuItem,
            this.öĞRENCİNOTLARIToolStripMenuItem});
            this.nOTLARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nOTLARToolStripMenuItem.Name = "nOTLARToolStripMenuItem";
            this.nOTLARToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.nOTLARToolStripMenuItem.Text = "NOTLAR";
            this.nOTLARToolStripMenuItem.Click += new System.EventHandler(this.nOTLARToolStripMenuItem_Click);
            // 
            // nOTHESAPLAMAToolStripMenuItem
            // 
            this.nOTHESAPLAMAToolStripMenuItem.Name = "nOTHESAPLAMAToolStripMenuItem";
            this.nOTHESAPLAMAToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.nOTHESAPLAMAToolStripMenuItem.Text = "NOT HESAPLAMA";
            this.nOTHESAPLAMAToolStripMenuItem.Click += new System.EventHandler(this.nOTHESAPLAMAToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // öĞRENCİNOTLARIToolStripMenuItem
            // 
            this.öĞRENCİNOTLARIToolStripMenuItem.Name = "öĞRENCİNOTLARIToolStripMenuItem";
            this.öĞRENCİNOTLARIToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.öĞRENCİNOTLARIToolStripMenuItem.Text = "ÖĞRENCİ NOTLARI";
            this.öĞRENCİNOTLARIToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİNOTLARIToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OgrenciYonetimSistemi.Properties.Resources._5a69adc3c03c0e21249b0a7a;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1110, 740);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1116, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form2";
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÖğrenciEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERSLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTHESAPLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİNOTLARIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}