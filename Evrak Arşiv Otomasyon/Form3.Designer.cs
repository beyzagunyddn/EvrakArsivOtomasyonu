namespace Evrak_Arşiv_Otomasyonu
{
    partial class Form3
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
            this.cmbArama2 = new System.Windows.Forms.ComboBox();
            this.txtArama2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEvrakID = new System.Windows.Forms.TextBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtEvrakSahibi = new System.Windows.Forms.TextBox();
            this.dateTimeKayıt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonDegistir = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.cmbEvrakTuru = new System.Windows.Forms.ComboBox();
            this.labelTemizle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbArama2
            // 
            this.cmbArama2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbArama2.FormattingEnabled = true;
            this.cmbArama2.Items.AddRange(new object[] {
            "Evrak ID",
            "Kullanıcı ID",
            "Evrak Türü",
            "Raf Konumu",
            "Kayıt Tarihi",
            "Evrak Sahibi"});
            this.cmbArama2.Location = new System.Drawing.Point(335, 38);
            this.cmbArama2.Name = "cmbArama2";
            this.cmbArama2.Size = new System.Drawing.Size(121, 25);
            this.cmbArama2.TabIndex = 29;
            // 
            // txtArama2
            // 
            this.txtArama2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama2.Location = new System.Drawing.Point(561, 38);
            this.txtArama2.Name = "txtArama2";
            this.txtArama2.Size = new System.Drawing.Size(313, 25);
            this.txtArama2.TabIndex = 30;
            this.txtArama2.TextChanged += new System.EventHandler(this.txtArama2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(251, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Arama Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(509, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Arama";
            // 
            // txtEvrakID
            // 
            this.txtEvrakID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEvrakID.Location = new System.Drawing.Point(41, 33);
            this.txtEvrakID.Name = "txtEvrakID";
            this.txtEvrakID.Size = new System.Drawing.Size(134, 25);
            this.txtEvrakID.TabIndex = 33;
            this.txtEvrakID.Visible = false;
            this.txtEvrakID.TextChanged += new System.EventHandler(this.txtad1_TextChanged);
            // 
            // txtRaf
            // 
            this.txtRaf.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRaf.Location = new System.Drawing.Point(474, 145);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(134, 25);
            this.txtRaf.TabIndex = 35;
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID.Location = new System.Drawing.Point(184, 145);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciID.TabIndex = 36;
            // 
            // txtEvrakSahibi
            // 
            this.txtEvrakSahibi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEvrakSahibi.Location = new System.Drawing.Point(474, 219);
            this.txtEvrakSahibi.Name = "txtEvrakSahibi";
            this.txtEvrakSahibi.Size = new System.Drawing.Size(134, 25);
            this.txtEvrakSahibi.TabIndex = 37;
            // 
            // dateTimeKayıt
            // 
            this.dateTimeKayıt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeKayıt.Location = new System.Drawing.Point(779, 142);
            this.dateTimeKayıt.Name = "dateTimeKayıt";
            this.dateTimeKayıt.Size = new System.Drawing.Size(201, 25);
            this.dateTimeKayıt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Evrak Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(387, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Raf Konumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(102, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kullanıcı ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(389, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Evrak Sahibi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(657, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Evrak Kayıt Tarihi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1098, 232);
            this.dataGridView2.TabIndex = 44;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(708, 206);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(97, 33);
            this.buttonEkle.TabIndex = 45;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonDegistir
            // 
            this.buttonDegistir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDegistir.Location = new System.Drawing.Point(883, 206);
            this.buttonDegistir.Name = "buttonDegistir";
            this.buttonDegistir.Size = new System.Drawing.Size(97, 33);
            this.buttonDegistir.TabIndex = 46;
            this.buttonDegistir.Text = "DEĞİŞTİR";
            this.buttonDegistir.UseVisualStyleBackColor = true;
            this.buttonDegistir.Click += new System.EventHandler(this.buttonDegistir_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(708, 265);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(97, 33);
            this.buttonSil.TabIndex = 47;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(883, 265);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(97, 33);
            this.buttonListele.TabIndex = 48;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // cmbEvrakTuru
            // 
            this.cmbEvrakTuru.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEvrakTuru.FormattingEnabled = true;
            this.cmbEvrakTuru.Items.AddRange(new object[] {
            "Sınav Kağıtları",
            "Personel Evrakları",
            "Öğrenci Evrakları",
            "Muhasebe Evrakları",
            "Bölüm Evrakları"});
            this.cmbEvrakTuru.Location = new System.Drawing.Point(184, 219);
            this.cmbEvrakTuru.Name = "cmbEvrakTuru";
            this.cmbEvrakTuru.Size = new System.Drawing.Size(134, 25);
            this.cmbEvrakTuru.TabIndex = 49;
            // 
            // labelTemizle
            // 
            this.labelTemizle.AutoSize = true;
            this.labelTemizle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTemizle.Location = new System.Drawing.Point(183, 265);
            this.labelTemizle.Name = "labelTemizle";
            this.labelTemizle.Size = new System.Drawing.Size(111, 15);
            this.labelTemizle.TabIndex = 50;
            this.labelTemizle.Text = "Kutucukları Temizle";
            this.labelTemizle.Click += new System.EventHandler(this.labelTemizle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 561);
            this.Controls.Add(this.labelTemizle);
            this.Controls.Add(this.cmbEvrakTuru);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDegistir);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeKayıt);
            this.Controls.Add(this.txtEvrakSahibi);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.txtEvrakID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArama2);
            this.Controls.Add(this.cmbArama2);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Evraklar";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArama2;
        private System.Windows.Forms.TextBox txtArama2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEvrakID;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtEvrakSahibi;
        private System.Windows.Forms.DateTimePicker dateTimeKayıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonDegistir;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.ComboBox cmbEvrakTuru;
        private System.Windows.Forms.Label labelTemizle;
    }
}