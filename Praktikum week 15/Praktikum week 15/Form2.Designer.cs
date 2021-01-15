namespace Praktikum_week_15
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
            this.checkBoxdiskon = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelbayar = new System.Windows.Forms.Label();
            this.labeldiskon = new System.Windows.Forms.Label();
            this.labeltax = new System.Windows.Forms.Label();
            this.labelsubtotal = new System.Windows.Forms.Label();
            this.labelinput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxdiskon = new System.Windows.Forms.TextBox();
            this.labelpersen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxdiskon
            // 
            this.checkBoxdiskon.AutoSize = true;
            this.checkBoxdiskon.Location = new System.Drawing.Point(13, 13);
            this.checkBoxdiskon.Name = "checkBoxdiskon";
            this.checkBoxdiskon.Size = new System.Drawing.Size(85, 21);
            this.checkBoxdiskon.TabIndex = 0;
            this.checkBoxdiskon.Text = "Discount";
            this.checkBoxdiskon.UseVisualStyleBackColor = true;
            this.checkBoxdiskon.CheckedChanged += new System.EventHandler(this.checkBoxdiskon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount";
            // 
            // labelbayar
            // 
            this.labelbayar.AutoSize = true;
            this.labelbayar.Location = new System.Drawing.Point(261, 119);
            this.labelbayar.Name = "labelbayar";
            this.labelbayar.Size = new System.Drawing.Size(16, 17);
            this.labelbayar.TabIndex = 5;
            this.labelbayar.Text = "0";
            this.labelbayar.Click += new System.EventHandler(this.labelbayar_click);
            // 
            // labeldiskon
            // 
            this.labeldiskon.AutoSize = true;
            this.labeldiskon.Location = new System.Drawing.Point(261, 84);
            this.labeldiskon.Name = "labeldiskon";
            this.labeldiskon.Size = new System.Drawing.Size(16, 17);
            this.labeldiskon.TabIndex = 6;
            this.labeldiskon.Text = "0";
            // 
            // labeltax
            // 
            this.labeltax.AutoSize = true;
            this.labeltax.Location = new System.Drawing.Point(261, 53);
            this.labeltax.Name = "labeltax";
            this.labeltax.Size = new System.Drawing.Size(16, 17);
            this.labeltax.TabIndex = 7;
            this.labeltax.Text = "0";
            // 
            // labelsubtotal
            // 
            this.labelsubtotal.AutoSize = true;
            this.labelsubtotal.Location = new System.Drawing.Point(261, 22);
            this.labelsubtotal.Name = "labelsubtotal";
            this.labelsubtotal.Size = new System.Drawing.Size(16, 17);
            this.labelsubtotal.TabIndex = 8;
            this.labelsubtotal.Text = "0";
            this.labelsubtotal.Click += new System.EventHandler(this.labelsubtotal_Click);
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Location = new System.Drawing.Point(12, 53);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(39, 17);
            this.labelinput.TabIndex = 9;
            this.labelinput.Text = "Input";
            this.labelinput.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxdiskon
            // 
            this.textBoxdiskon.Location = new System.Drawing.Point(57, 50);
            this.textBoxdiskon.Name = "textBoxdiskon";
            this.textBoxdiskon.Size = new System.Drawing.Size(100, 22);
            this.textBoxdiskon.TabIndex = 11;
            this.textBoxdiskon.Visible = false;
            // 
            // labelpersen
            // 
            this.labelpersen.AutoSize = true;
            this.labelpersen.Location = new System.Drawing.Point(164, 53);
            this.labelpersen.Name = "labelpersen";
            this.labelpersen.Size = new System.Drawing.Size(20, 17);
            this.labelpersen.TabIndex = 12;
            this.labelpersen.Text = "%";
            this.labelpersen.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelpersen);
            this.Controls.Add(this.textBoxdiskon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelinput);
            this.Controls.Add(this.labelsubtotal);
            this.Controls.Add(this.labeltax);
            this.Controls.Add(this.labeldiskon);
            this.Controls.Add(this.labelbayar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxdiskon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxdiskon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelbayar;
        private System.Windows.Forms.Label labeldiskon;
        private System.Windows.Forms.Label labeltax;
        private System.Windows.Forms.Label labelsubtotal;
        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxdiskon;
        private System.Windows.Forms.Label labelpersen;
    }
}