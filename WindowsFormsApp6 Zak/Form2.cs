using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_Zak
{
    public partial class Form2 : Form
    {
        public Product Product { get; set; }

        public Form2()
        {
            InitializeComponent();
            Product = new Product();
            this.Text = "Добавление товара";
        }
        public Form2(Product product)
        {
            InitializeComponent();
            Product = product;
            this.Text = "Редактирование товара";
            LoadData();
        }

        private void LoadData()
        {
            textBox1.Text = Product.ID.ToString();
            textBox2.Text = Product.Name;
            textBox3.Text = Product.Category;
            textBox4.Text = Product.Price.ToString();
            textBox5.Text = Product.Quantity.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product.ID = Int32.Parse(textBox1.Text);
            Product.Name = textBox2.Text;
            Product.Category = textBox3.Text;
            Product.Price = Int32.Parse(textBox4.Text);
            Product.Quantity = Int32.Parse(textBox5.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
