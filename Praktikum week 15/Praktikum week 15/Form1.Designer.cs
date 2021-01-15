namespace Praktikum_week_15
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
            this.labeljudul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbutonmakanan = new System.Windows.Forms.RadioButton();
            this.rbutonminuman = new System.Windows.Forms.RadioButton();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.buttoncheckout = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxharga = new System.Windows.Forms.ListBox();
            this.labelharga = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonjumbo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeljudul
            // 
            this.labeljudul.AutoSize = true;
            this.labeljudul.Location = new System.Drawing.Point(247, 9);
            this.labeljudul.Name = "labeljudul";
            this.labeljudul.Size = new System.Drawing.Size(59, 17);
            this.labeljudul.TabIndex = 0;
            this.labeljudul.Text = "Bu Dewi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            // 
            // rbutonmakanan
            // 
            this.rbutonmakanan.AutoSize = true;
            this.rbutonmakanan.Location = new System.Drawing.Point(372, 71);
            this.rbutonmakanan.Name = "rbutonmakanan";
            this.rbutonmakanan.Size = new System.Drawing.Size(87, 21);
            this.rbutonmakanan.TabIndex = 4;
            this.rbutonmakanan.TabStop = true;
            this.rbutonmakanan.Text = "Makanan";
            this.rbutonmakanan.UseVisualStyleBackColor = true;
            this.rbutonmakanan.CheckedChanged += new System.EventHandler(this.rbutonmakanan_CheckedChanged);
            // 
            // rbutonminuman
            // 
            this.rbutonminuman.AutoSize = true;
            this.rbutonminuman.Location = new System.Drawing.Point(489, 71);
            this.rbutonminuman.Name = "rbutonminuman";
            this.rbutonminuman.Size = new System.Drawing.Size(86, 21);
            this.rbutonminuman.TabIndex = 5;
            this.rbutonminuman.TabStop = true;
            this.rbutonminuman.Text = "Minuman";
            this.rbutonminuman.UseVisualStyleBackColor = true;
            this.rbutonminuman.CheckedChanged += new System.EventHandler(this.rbutonminuman_CheckedChanged);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(432, 114);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMenu.TabIndex = 6;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // buttonbuy
            // 
            this.buttonbuy.Location = new System.Drawing.Point(432, 260);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(121, 38);
            this.buttonbuy.TabIndex = 7;
            this.buttonbuy.Text = "BUY";
            this.buttonbuy.UseVisualStyleBackColor = true;
            this.buttonbuy.Click += new System.EventHandler(this.buttonbuy_Click);
            // 
            // buttoncheckout
            // 
            this.buttoncheckout.Location = new System.Drawing.Point(600, 342);
            this.buttoncheckout.Name = "buttoncheckout";
            this.buttoncheckout.Size = new System.Drawing.Size(121, 50);
            this.buttoncheckout.TabIndex = 8;
            this.buttoncheckout.Text = "Check Out";
            this.buttoncheckout.UseVisualStyleBackColor = true;
            this.buttoncheckout.Click += new System.EventHandler(this.buttoncheckout_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(155, 342);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 9;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 16;
            this.listBoxMenu.Location = new System.Drawing.Point(24, 97);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(154, 228);
            this.listBoxMenu.TabIndex = 10;
            // 
            // listBoxharga
            // 
            this.listBoxharga.FormattingEnabled = true;
            this.listBoxharga.ItemHeight = 16;
            this.listBoxharga.Location = new System.Drawing.Point(194, 97);
            this.listBoxharga.Name = "listBoxharga";
            this.listBoxharga.Size = new System.Drawing.Size(88, 228);
            this.listBoxharga.TabIndex = 11;
            // 
            // labelharga
            // 
            this.labelharga.AutoSize = true;
            this.labelharga.Location = new System.Drawing.Point(622, 117);
            this.labelharga.Name = "labelharga";
            this.labelharga.Size = new System.Drawing.Size(16, 17);
            this.labelharga.TabIndex = 12;
            this.labelharga.Text = "0";
            this.labelharga.Click += new System.EventHandler(this.labelharga_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Size";
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(0, 31);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(74, 21);
            this.radioButtonnormal.TabIndex = 14;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "Normal";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            this.radioButtonnormal.CheckedChanged += new System.EventHandler(this.radioButtonnormal_CheckedChanged);
            // 
            // radioButtonjumbo
            // 
            this.radioButtonjumbo.AutoSize = true;
            this.radioButtonjumbo.Location = new System.Drawing.Point(80, 31);
            this.radioButtonjumbo.Name = "radioButtonjumbo";
            this.radioButtonjumbo.Size = new System.Drawing.Size(71, 21);
            this.radioButtonjumbo.TabIndex = 15;
            this.radioButtonjumbo.TabStop = true;
            this.radioButtonjumbo.Text = "Jumbo";
            this.radioButtonjumbo.UseVisualStyleBackColor = true;
            this.radioButtonjumbo.CheckedChanged += new System.EventHandler(this.radioButtonjumbo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButtonjumbo);
            this.panel1.Controls.Add(this.radioButtonnormal);
            this.panel1.Location = new System.Drawing.Point(372, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 65);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelharga);
            this.Controls.Add(this.listBoxharga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoncheckout);
            this.Controls.Add(this.buttonbuy);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.rbutonminuman);
            this.Controls.Add(this.rbutonmakanan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeljudul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeljudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbutonmakanan;
        private System.Windows.Forms.RadioButton rbutonminuman;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.Button buttoncheckout;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxharga;
        private System.Windows.Forms.Label labelharga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.RadioButton radioButtonjumbo;
        private System.Windows.Forms.Panel panel1;
    }
}

