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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labeljudul.Font = new Font("Times New Roman", 25, FontStyle.Bold);
        }

        private void rbutonmakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbutonmakanan.Checked == true)
            {
                comboBoxMenu.Items.Add("Ayam Bakar");
                comboBoxMenu.Items.Add("Nasi Goreng");
                comboBoxMenu.Items.Add("Nasi Goreng Spesial");
                comboBoxMenu.Items.Add("Nasi Goreng Pete");
            }
            if (rbutonmakanan.Checked == false)
            {
                comboBoxMenu.Items.Clear();
            }
        }

        private void rbutonminuman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbutonminuman.Checked == true)
            {
                comboBoxMenu.Items.Add("Es Teh");
                comboBoxMenu.Items.Add("Teh Hangat");
                comboBoxMenu.Items.Add("Nutrisari");
                comboBoxMenu.Items.Add("Aqua");
                panel1.Visible = panel1.Enabled;
            }
            else
            {
                comboBoxMenu.Items.Clear();
                panel1.Hide();
            }
        }

        private void labelharga_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButtonnormal_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem.ToString() == "Es Teh" && radioButtonnormal.Checked == true)
            {
                labelharga.Text = "5000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonnormal.Checked == true)
            {
                labelharga.Text = "3000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonnormal.Checked == true)
            {
                labelharga.Text = "6000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Aqua" && radioButtonnormal.Checked == true)
            {
                labelharga.Text = "2000";
            }
        }

        private void radioButtonjumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem.ToString() == "Es Teh" && radioButtonjumbo.Checked == true)
            {
                labelharga.Text = "7000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonjumbo.Checked == true)
            {
                labelharga.Text = "5000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonjumbo.Checked == true)
            {
                labelharga.Text = "10000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Aqua" && radioButtonjumbo.Checked == true)
            {
                labelharga.Text = "5000";
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMenu.SelectedItem.ToString() == "Ayam Bakar")
            {
                labelharga.Text = "15000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelharga.Text = "10000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng Spesial")
            {
                labelharga.Text = "12000";
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                labelharga.Text = "15000";
            }
            radioButtonjumbo_CheckedChanged(sender, e);
            radioButtonnormal_CheckedChanged(sender, e);
        }
        public static string subtotal = "16500";
         
        private void buttonbuy_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Add(comboBoxMenu.SelectedItem);
            if (comboBoxMenu.SelectedItem.ToString() == "Ayam Bakar")
            {
                listBoxharga.Items.Add(15000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng")
            {
                listBoxharga.Items.Add(10000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng Spesial")
            {
                listBoxharga.Items.Add(12000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                listBoxharga.Items.Add(15000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Es Teh" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(7000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(5000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(10000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Aqua" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(5000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Es Teh" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(5000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(3000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(6000);
            }
            if (comboBoxMenu.SelectedItem.ToString() == "Aqua" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(2000);
            }
            subtotal = listBoxharga.Items.ToString();
            cekbuttonDelete();
        }

        private void cekbuttonDelete()
        {
            if (listBoxMenu.Items.Count == 0)
            {
                buttondelete.Enabled = false;
            }
            else
            {
                buttondelete.Enabled = true;
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            listBoxharga.Items.RemoveAt(listBoxMenu.SelectedIndex);
            listBoxMenu.Items.RemoveAt(listBoxMenu.SelectedIndex);
            cekbuttonDelete();
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.Items.Count == 0)
            {
                MessageBox.Show("Tolong Beli Dulu");
            }
            else
            {
                var formbaru = new Form2();
                formbaru.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cekbuttonDelete();
        }
    }
}
