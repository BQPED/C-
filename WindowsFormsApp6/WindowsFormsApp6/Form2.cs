using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        private Contact contactR;

        public Contact ContactR { get => contactR; private set => contactR = value; }
        public Form2(Contact contact = null)
        {
            InitializeComponent();

            comboBox1.Items.AddRange(
                new string[] {
                    "Друзья", "Семья", "Работа", "Учеба", "Другое"
                }
                );
            if (contact == null)
            {
                ContactR = new Contact();
                Text = "Добавить контакт";
            }
            else
            {
                ContactR = contact;
                Text = "Редактировать контакт";
                FillForm();
            }
        }
        private void FillForm()
        {
            textBox1.Text = ContactR.FirstName;
            textBox2.Text = ContactR.LastName;
            textBox4.Text = ContactR.Mail;
            textBox3.Text = ContactR.Phone;
            dateTimePicker1.Value = ContactR.BirthDate;
            comboBox1.Text = ContactR.Category;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContactR.FirstName = textBox2.Text;
            ContactR.LastName = textBox1.Text;
            ContactR.Phone = textBox3.Text;
            ContactR.Mail = textBox4.Text;
            ContactR.BirthDate = dateTimePicker1.Value;
            ContactR.Category = comboBox1.Text;
            string message = 
                   $"Контакт сохранен:\n" +
                   $"Имя: {ContactR.FirstName}\n" +
                   $"Фамилия: {ContactR.LastName}\n" +
                   $"Телефон: {ContactR.Phone}\n" +
                   $"Email: {ContactR.Mail}\n" +
                   $"Дата рождения: {ContactR.BirthDate.ToShortDateString()}\n" +
                   $"Категория: {ContactR.Category}";

            MessageBox.Show(message, "Данные контакта",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
