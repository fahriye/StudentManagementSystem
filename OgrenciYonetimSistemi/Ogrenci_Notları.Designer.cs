namespace OgrenciYonetimSistemi
{
    partial class Ogrenci_Notları
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
            this.textBox3_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oYSDataSet14 = new OgrenciYonetimSistemi.OYSDataSet14();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.oysDataSet101 = new OgrenciYonetimSistemi.OYSDataSet10();
            this.ogrenciTableAdapter1 = new OgrenciYonetimSistemi.OYSDataSet1TableAdapters.ogrenciTableAdapter();
            this.oysDataSet11 = new OgrenciYonetimSistemi.OYSDataSet1();
            this.ogrenciTableAdapter2 = new OgrenciYonetimSistemi.OYSDataSet12TableAdapters.ogrenciTableAdapter();
            this.notlarTableAdapter = new OgrenciYonetimSistemi.OYSDataSet14TableAdapters.notlarTableAdapter();
            this.oYSDataSet15 = new OgrenciYonetimSistemi.OYSDataSet15();
            this.notlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notlarTableAdapter1 = new OgrenciYonetimSistemi.OYSDataSet15TableAdapters.notlarTableAdapter();
            this.oYSDataSet16 = new OgrenciYonetimSistemi.OYSDataSet16();
            this.notlarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.notlarTableAdapter2 = new OgrenciYonetimSistemi.OYSDataSet16TableAdapters.notlarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oYSDataSet17 = new OgrenciYonetimSistemi.OYSDataSet17();
            this.notlarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.notlarTableAdapter3 = new OgrenciYonetimSistemi.OYSDataSet17TableAdapters.notlarTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nottDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oysDataSet101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oysDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3_number
            // 
            this.textBox3_number.Location = new System.Drawing.Point(180, 165);
            this.textBox3_number.Name = "textBox3_number";
            this.textBox3_number.Size = new System.Drawing.Size(207, 22);
            this.textBox3_number.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "NOT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "SOYADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADI:";
            // 
            // notlarBindingSource
            // 
            this.notlarBindingSource.DataMember = "notlar";
            this.notlarBindingSource.DataSource = this.oYSDataSet14;
            // 
            // oYSDataSet14
            // 
            this.oYSDataSet14.DataSetName = "OYSDataSet14";
            this.oYSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(66, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notlarBindingSource3, "soyad", true));
            this.comboBox2.DataSource = this.notlarBindingSource3;
            this.comboBox2.DisplayMember = "soyad";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(180, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 24);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "soyad";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // oysDataSet101
            // 
            this.oysDataSet101.DataSetName = "OYSDataSet10";
            this.oysDataSet101.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // oysDataSet11
            // 
            this.oysDataSet11.DataSetName = "OYSDataSet1";
            this.oysDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // notlarTableAdapter
            // 
            this.notlarTableAdapter.ClearBeforeFill = true;
            // 
            // oYSDataSet15
            // 
            this.oYSDataSet15.DataSetName = "OYSDataSet15";
            this.oYSDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notlarBindingSource1
            // 
            this.notlarBindingSource1.DataMember = "notlar";
            this.notlarBindingSource1.DataSource = this.oYSDataSet15;
            // 
            // notlarTableAdapter1
            // 
            this.notlarTableAdapter1.ClearBeforeFill = true;
            // 
            // oYSDataSet16
            // 
            this.oYSDataSet16.DataSetName = "OYSDataSet16";
            this.oYSDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notlarBindingSource2
            // 
            this.notlarBindingSource2.DataMember = "notlar";
            this.notlarBindingSource2.DataSource = this.oYSDataSet16;
            // 
            // notlarTableAdapter2
            // 
            this.notlarTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.nottDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notlarBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(440, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 288);
            this.dataGridView1.TabIndex = 21;
            // 
            // oYSDataSet17
            // 
            this.oYSDataSet17.DataSetName = "OYSDataSet17";
            this.oYSDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notlarBindingSource3
            // 
            this.notlarBindingSource3.DataMember = "notlar";
            this.notlarBindingSource3.DataSource = this.oYSDataSet17;
            // 
            // notlarTableAdapter3
            // 
            this.notlarTableAdapter3.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // nottDataGridViewTextBoxColumn
            // 
            this.nottDataGridViewTextBoxColumn.DataPropertyName = "nott";
            this.nottDataGridViewTextBoxColumn.HeaderText = "nott";
            this.nottDataGridViewTextBoxColumn.Name = "nottDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(210, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ogrenci_Notları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(908, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci_Notları";
            this.Text = "Ogrenci_Notları";
            this.Load += new System.EventHandler(this.Ogrenci_Notları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oysDataSet101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oysDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYSDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private OYSDataSet1TableAdapters.ogrenciTableAdapter ogrenciTableAdapter1;
        private OYSDataSet1 oysDataSet11;
        private OYSDataSet10 oysDataSet101;
        private OYSDataSet12TableAdapters.ogrenciTableAdapter ogrenciTableAdapter2;
        private OYSDataSet14 oYSDataSet14;
        private System.Windows.Forms.BindingSource notlarBindingSource;
        private OYSDataSet14TableAdapters.notlarTableAdapter notlarTableAdapter;
        private OYSDataSet15 oYSDataSet15;
        private System.Windows.Forms.BindingSource notlarBindingSource1;
        private OYSDataSet15TableAdapters.notlarTableAdapter notlarTableAdapter1;
        private OYSDataSet16 oYSDataSet16;
        private System.Windows.Forms.BindingSource notlarBindingSource2;
        private OYSDataSet16TableAdapters.notlarTableAdapter notlarTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OYSDataSet17 oYSDataSet17;
        private System.Windows.Forms.BindingSource notlarBindingSource3;
        private OYSDataSet17TableAdapters.notlarTableAdapter notlarTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nottDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}