using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooltip_listbox_compobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] a = new string[] { "Tamil", "keral" };
            foreach (string i in a)
            {
                comboBox1.Items.Add(i);
            }
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Tamil")
            {
                comboBox2.Items.Add("Channal");
                comboBox2.Items.Add("Trichy");
                comboBox2.Items.Add("pondi");
            }

            if (comboBox1.SelectedItem.ToString() == "keral")
            {
                comboBox2.Items.Add("Kolam");
                comboBox2.Items.Add("cochin");
            }

        }

      
    }
}
