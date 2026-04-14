using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace WindowsFormsApp6
{



    public partial class Form1 : Form
    {
        private List<Contact> contacts; //поля
        private string dataFile = "contactData.dat";
        public Form1()//конструктор
        {
            InitializeComponent();
            contacts = new List<Contact>();
            loadContacts();
            UpdateContactsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadContacts() //Пользовательская функция
        {
            try
            {
                if (File.Exists(dataFile))
                {
                    using (StreamReader reader = new StreamReader(dataFile))
                    {
                        while (!reader.EndOfStream)
                        {
                            string[] data = reader.ReadLine().Split('|');
                            Contact contact = new Contact();
                            contact.FirstName = data[0];
                            contact.LastName = data[1];
                            contact.Phone = data[2];
                            contact.Mail = data[3];
                            contact.BirthDate = DateTime.Parse(data[4]);
                            contact.Category = data[5];
                            contacts.Add(contact);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки контакта : {ex.Message}");
            }
        }
            private void SaveContacts()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dataFile))
                {
                    foreach (Contact contact in contacts)
                    {
                        writer.WriteLine(
                            $"{contact.FirstName}|" +
                            $"{contact.LastName}|" +
                            $"{contact.Phone}|" +
                            $"{contact.Mail}|" +
                            $"{contact.BirthDate:dd-MM-yyyy}|" +
                            $"{contact.Category}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ошибка с сохранением контактов: {ex.Message}");
            }
        }
        private void UpdateContactsList()
        {
            listBox1.Items.Clear();

            var filteredContacts = contacts.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string search = textBox1.Text.ToLower();
                filteredContacts = filteredContacts.Where(c =>
                    c.FirstName.ToLower().Contains(search) ||
                    c.LastName.ToLower().Contains(search) ||
                    c.Phone.ToLower().Contains(search)
                );
            }

            if (comboBox1.SelectedIndex > 0)
            {
                string category = comboBox1.Text;
                filteredContacts = filteredContacts.Where(c => c.Category == category);
            }

            filteredContacts = filteredContacts.OrderBy(c => c.LastName);
            foreach (Contact contact in filteredContacts)
            {
                listBox1.Items.Add(contact);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveContacts();
        }

        private void button5_Click(object sender, EventArgs e) //delete
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выбирите пожалуйста контакт для удаления!!!");
                return;
            }
            if(MessageBox.Show("Удалить контакт?","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Contact selectedContact = listBox1.SelectedItem as Contact;
                contacts.Remove(selectedContact);
                UpdateContactsList();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveContacts();
            MessageBox.Show("Сохранено","Отлично", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateContactsList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            UpdateContactsList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {

                    contacts.Add(form2.ContactR);
                    UpdateContactsList();

                    string message = 
                          $"Новый контакт добавлен:\n" +
                          $"Имя: {form2.ContactR.FirstName}\n" +
                          $"Фамилия: {form2.ContactR.LastName}\n" +
                          $"Телефон: {form2.ContactR.Phone}\n" +
                          $"Email: {form2.ContactR.Mail}\n" +
                          $"Дата рождения: {form2.ContactR.BirthDate.ToShortDateString()}\n" +
                          $"Категория: {form2.ContactR.Category}";

                    MessageBox.Show(message, "Добавление контакта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт для редактирования!");
                return;
            }
            Contact selectedContact = listBox1.SelectedItem as Contact;
            int index = contacts.IndexOf(selectedContact);
            using (Form2 form2 = new Form2(selectedContact))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    contacts[index] = form2.ContactR;
                    UpdateContactsList();
                }
            }
        }
    }  
}
