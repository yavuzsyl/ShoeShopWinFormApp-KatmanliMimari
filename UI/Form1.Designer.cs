namespace UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayakkabılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAyak = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMarka = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSTOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetimToolStripMenuItem,
            this.stokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markalarToolStripMenuItem,
            this.ayakkabılarToolStripMenuItem});
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // markalarToolStripMenuItem
            // 
            this.markalarToolStripMenuItem.Name = "markalarToolStripMenuItem";
            this.markalarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.markalarToolStripMenuItem.Text = "Markalar";
            this.markalarToolStripMenuItem.Click += new System.EventHandler(this.markalarToolStripMenuItem_Click);
            // 
            // ayakkabılarToolStripMenuItem
            // 
            this.ayakkabılarToolStripMenuItem.Name = "ayakkabılarToolStripMenuItem";
            this.ayakkabılarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ayakkabılarToolStripMenuItem.Text = "Ayakkabılar";
            this.ayakkabılarToolStripMenuItem.Click += new System.EventHandler(this.ayakkabılarToolStripMenuItem_Click);
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.stokToolStripMenuItem.Text = "Stok";
            this.stokToolStripMenuItem.Click += new System.EventHandler(this.stokToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAyak,
            this.toolStripButtonMarka,
            this.toolStripButtonSTOK,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAyak
            // 
            this.toolStripButtonAyak.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAyak.Image")));
            this.toolStripButtonAyak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAyak.Name = "toolStripButtonAyak";
            this.toolStripButtonAyak.Size = new System.Drawing.Size(124, 24);
            this.toolStripButtonAyak.Text = "Ayakkabı Ekle";
            this.toolStripButtonAyak.Click += new System.EventHandler(this.toolStripButtonAyak_Click);
            // 
            // toolStripButtonMarka
            // 
            this.toolStripButtonMarka.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMarka.Image")));
            this.toolStripButtonMarka.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMarka.Name = "toolStripButtonMarka";
            this.toolStripButtonMarka.Size = new System.Drawing.Size(105, 24);
            this.toolStripButtonMarka.Text = "Marka Ekle";
            this.toolStripButtonMarka.Click += new System.EventHandler(this.toolStripButtonMarka_Click);
            // 
            // toolStripButtonSTOK
            // 
            this.toolStripButtonSTOK.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSTOK.Image")));
            this.toolStripButtonSTOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSTOK.Name = "toolStripButtonSTOK";
            this.toolStripButtonSTOK.Size = new System.Drawing.Size(156, 24);
            this.toolStripButtonSTOK.Text = "Stok Hareket Takip";
            this.toolStripButtonSTOK.Click += new System.EventHandler(this.toolStripButtonSTOK_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 24);
            this.toolStripButton1.Text = "EnvanterRapor";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayakkabılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyak;
        private System.Windows.Forms.ToolStripButton toolStripButtonMarka;
        private System.Windows.Forms.ToolStripButton toolStripButtonSTOK;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

