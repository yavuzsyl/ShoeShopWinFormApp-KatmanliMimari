namespace UI
{
    partial class StokHareket
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
            this.button1 = new System.Windows.Forms.Button();
            this.rb_cikis = new System.Windows.Forms.RadioButton();
            this.rb_giris = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.nm_adet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_no = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Marka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Ayakkabi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nm_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_no)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(176, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 23;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_cikis
            // 
            this.rb_cikis.AutoSize = true;
            this.rb_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rb_cikis.Location = new System.Drawing.Point(268, 256);
            this.rb_cikis.Name = "rb_cikis";
            this.rb_cikis.Size = new System.Drawing.Size(90, 33);
            this.rb_cikis.TabIndex = 22;
            this.rb_cikis.TabStop = true;
            this.rb_cikis.Text = "Çıkış";
            this.rb_cikis.UseVisualStyleBackColor = true;
            // 
            // rb_giris
            // 
            this.rb_giris.AutoSize = true;
            this.rb_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rb_giris.Location = new System.Drawing.Point(176, 256);
            this.rb_giris.Name = "rb_giris";
            this.rb_giris.Size = new System.Drawing.Size(86, 33);
            this.rb_giris.TabIndex = 21;
            this.rb_giris.TabStop = true;
            this.rb_giris.Text = "Giriş";
            this.rb_giris.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(5, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "İşlem Yönü:";
            // 
            // nm_adet
            // 
            this.nm_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nm_adet.Location = new System.Drawing.Point(176, 199);
            this.nm_adet.Name = "nm_adet";
            this.nm_adet.Size = new System.Drawing.Size(120, 38);
            this.nm_adet.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(84, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adet:";
            // 
            // nm_no
            // 
            this.nm_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nm_no.Location = new System.Drawing.Point(176, 147);
            this.nm_no.Name = "nm_no";
            this.nm_no.Size = new System.Drawing.Size(120, 38);
            this.nm_no.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Numara:";
            // 
            // cb_Marka
            // 
            this.cb_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cb_Marka.FormattingEnabled = true;
            this.cb_Marka.Location = new System.Drawing.Point(176, 23);
            this.cb_Marka.Name = "cb_Marka";
            this.cb_Marka.Size = new System.Drawing.Size(361, 39);
            this.cb_Marka.TabIndex = 15;
            this.cb_Marka.SelectedIndexChanged += new System.EventHandler(this.cb_Marka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(65, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marka:";
            // 
            // cb_Ayakkabi
            // 
            this.cb_Ayakkabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cb_Ayakkabi.FormattingEnabled = true;
            this.cb_Ayakkabi.Location = new System.Drawing.Point(176, 80);
            this.cb_Ayakkabi.Name = "cb_Ayakkabi";
            this.cb_Ayakkabi.Size = new System.Drawing.Size(361, 39);
            this.cb_Ayakkabi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ayakkabı:";
            // 
            // StokHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_cikis);
            this.Controls.Add(this.rb_giris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nm_adet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nm_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Marka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Ayakkabi);
            this.Controls.Add(this.label1);
            this.Name = "StokHareket";
            this.Text = "StokHareket";
            this.Load += new System.EventHandler(this.StokHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_cikis;
        private System.Windows.Forms.RadioButton rb_giris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nm_adet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Ayakkabi;
        private System.Windows.Forms.Label label1;
    }
}