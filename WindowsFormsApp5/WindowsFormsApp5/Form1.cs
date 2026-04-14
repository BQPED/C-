using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Нет текста", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string task = textBox1.Text;
                listBox1.Items.Add(task);
                textBox1.Text = ""; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(listBox1.Text))
            {
                MessageBox.Show("Нет выбора", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
