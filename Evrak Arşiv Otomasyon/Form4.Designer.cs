namespace Evrak_Arşiv_Otomasyonu
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
            this.txtEvrakID2 = new System.Windows.Forms.TextBox();
            this.txtKullaniciID2 = new System.Windows.Forms.TextBox();
            this.txtEmanetiAlan = new System.Windows.Forms.TextBox();
            this.txtTeslimDurumu = new System.Windows.Forms.TextBox();
            this.dtEmanet = new System.Windows.Forms.DateTimePicker();
            this.dtTeslim = new System.Windows.Forms.DateTimePicker();
            this.cmbArama3 = new System.Windows.Forms.ComboBox();
            this.txtArama3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonDegistir = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.labelTemizle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEvrakID2
            // 
            this.txtEvrakID2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEvrakID2.Location = new System.Drawing.Point(140, 149);
            this.txtEvrakID2.Name = "txtEvrakID2";
            this.txtEvrakID2.Size = new System.Drawing.Size(134, 25);
            this.txtEvrakID2.TabIndex = 37;
            // 
            // txtKullaniciID2
            // 
            this.txtKullaniciID2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID2.Location = new System.Drawing.Point(140, 222);
            this.txtKullaniciID2.Name = "txtKullaniciID2";
            this.txtKullaniciID2.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciID2.TabIndex = 38;
            // 
            // txtEmanetiAlan
            // 
            this.txtEmanetiAlan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmanetiAlan.Location = new System.Drawing.Point(830, 151);
            this.txtEmanetiAlan.Name = "txtEmanetiAlan";
            this.txtEmanetiAlan.Size = new System.Drawing.Size(134, 25);
            this.txtEmanetiAlan.TabIndex = 39;
            // 
            // txtTeslimDurumu
            // 
            this.txtTeslimDurumu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimDurumu.Location = new System.Drawing.Point(830, 220);
            this.txtTeslimDurumu.Name = "txtTeslimDurumu";
            this.txtTeslimDurumu.Size = new System.Drawing.Size(134, 25);
            this.txtTeslimDurumu.TabIndex = 40;
            // 
            // dtEmanet
            // 
            this.dtEmanet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtEmanet.Location = new System.Drawing.Point(472, 148);
            this.dtEmanet.Name = "dtEmanet";
            this.dtEmanet.Size = new System.Drawing.Size(201, 25);
            this.dtEmanet.TabIndex = 41;
            // 
            // dtTeslim
            // 
            this.dtTeslim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTeslim.Location = new System.Drawing.Point(472, 220);
            this.dtTeslim.Name = "dtTeslim";
            this.dtTeslim.Size = new System.Drawing.Size(201, 25);
            this.dtTeslim.TabIndex = 42;
            // 
            // cmbArama3
            // 
            this.cmbArama3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbArama3.FormattingEnabled = true;
            this.cmbArama3.Items.AddRange(new object[] {
            "Evrak ID",
            "Kullanıcı ID",
            "Emanet Tarihi",
            "Teslim Tarihi",
            "Emaneti Alan Kişi",
            "Teslim Durumu"});
            this.cmbArama3.Location = new System.Drawing.Point(331, 43);
            this.cmbArama3.Name = "cmbArama3";
            this.cmbArama3.Size = new System.Drawing.Size(121, 25);
            this.cmbArama3.TabIndex = 43;
            // 
            // txtArama3
            // 
            this.txtArama3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama3.Location = new System.Drawing.Point(557, 43);
            this.txtArama3.Name = "txtArama3";
            this.txtArama3.Size = new System.Drawing.Size(313, 25);
            this.txtArama3.TabIndex = 44;
            this.txtArama3.TextChanged += new System.EventHandler(this.txtArama2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(247, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Arama Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(505, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Evrak ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Kullanıcı ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(379, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Emanet Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(386, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Teslim Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(713, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Emaneti Alan Kişi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(729, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Teslim Durumu";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 372);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1098, 232);
            this.dataGridView3.TabIndex = 53;
            this.dataGridView3.Visible = false;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(226, 289);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(97, 33);
            this.buttonEkle.TabIndex = 54;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonDegistir
            // 
            this.buttonDegistir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDegistir.Location = new System.Drawing.Point(607, 289);
            this.buttonDegistir.Name = "buttonDegistir";
            this.buttonDegistir.Size = new System.Drawing.Size(97, 33);
            this.buttonDegistir.TabIndex = 55;
            this.buttonDegistir.Text = "DEĞİŞTİR";
            this.buttonDegistir.UseVisualStyleBackColor = true;
            this.buttonDegistir.Click += new System.EventHandler(this.buttonDegistir_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(420, 289);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(97, 33);
            this.buttonSil.TabIndex = 56;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(787, 289);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(97, 33);
            this.buttonListele.TabIndex = 57;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // labelTemizle
            // 
            this.labelTemizle.AutoSize = true;
            this.labelTemizle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTemizle.Location = new System.Drawing.Point(141, 257);
            this.labelTemizle.Name = "labelTemizle";
            this.labelTemizle.Size = new System.Drawing.Size(111, 15);
            this.labelTemizle.TabIndex = 58;
            this.labelTemizle.Text = "Kutucukları Temizle";
            this.labelTemizle.Click += new System.EventHandler(this.labelTemizle_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 604);
            this.Controls.Add(this.labelTemizle);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDegistir);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArama3);
            this.Controls.Add(this.cmbArama3);
            this.Controls.Add(this.dtTeslim);
            this.Controls.Add(this.dtEmanet);
            this.Controls.Add(this.txtTeslimDurumu);
            this.Controls.Add(this.txtEmanetiAlan);
            this.Controls.Add(this.txtKullaniciID2);
            this.Controls.Add(this.txtEvrakID2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanetler";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvrakID2;
        private System.Windows.Forms.TextBox txtKullaniciID2;
        private System.Windows.Forms.TextBox txtEmanetiAlan;
        private System.Windows.Forms.TextBox txtTeslimDurumu;
        private System.Windows.Forms.DateTimePicker dtEmanet;
        private System.Windows.Forms.DateTimePicker dtTeslim;
        private System.Windows.Forms.ComboBox cmbArama3;
        private System.Windows.Forms.TextBox txtArama3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonDegistir;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Label labelTemizle;
    }
}