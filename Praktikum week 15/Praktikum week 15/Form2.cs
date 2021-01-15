using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_week_15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void labelbayar_click(object sender, EventArgs e)
        {
            //labelbayar.Text = (labelsubtotal.Text + labeltax.Text - labeldiskon.Text)
        }

        private void checkBoxdiskon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxdiskon.Checked == true)
            {
                labelpersen.Visible = labelpersen.Enabled;
                labelinput.Visible = labelinput.Enabled;
                textBoxdiskon.Visible = textBoxdiskon.Enabled;
            }
            else
            {
                labelpersen.Hide();
                labelinput.Hide();
                textBoxdiskon.Hide();
            }
        }
        private void labelsubtotal_Click(object sender, EventArgs e)
        {
            labelsubtotal.Text = Form1.subtotal;
        }
    }
}
