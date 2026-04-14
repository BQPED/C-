using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6_Zak
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
            products = new BindingList<Product>();
            filePath = "";
            InitializeDataGridView();
            products.ListChanged += Products_ListChanged;
            UpdateStatus();

        }
        private void Products_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateStatus();
        }
        private void loadProducts() //Пользовательская функция
        {
            try
            {
                if (File.Exists(filePath)) // При помощи класса File проверяем существует ли файл с данными
                {
                    using (StreamReader reader = new StreamReader(filePath)) // читает файл в потоке
                    {
                        while (!reader.EndOfStream)
                        {
                            string[] data = reader.ReadLine().Split('|');
                            if (data.Length == 5)
                            {
                                Product product = new Product();
                                product.ID = Int32.Parse(data[0]);
                                product.Name = data[1];
                                product.Category = data[2];
                                product.Price = Int32.Parse(data[3]);
                                product.Quantity = Int32.Parse(data[4]);
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки продуктов : {ex.Message}");
            }
        }
        private void SaveProducts()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Product product in products)
                    {
                        writer.WriteLine(
                            $"{product.ID}|" +
                            $"{product.Name}|" +
                            $"{product.Category}|" +
                            $"{product.Price}|" +
                            $"{product.Quantity}"
                        );
                    }
                }

                MessageBox.Show(
                    $"Данные успешно сохранены в файл:\n{Path.GetFileName(filePath)}",
                    "Сохранение завершено",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении продуктов: {ex.Message}");
            }
        }
        private void UpdateStatus()
        {
            try
            {
                if (products == null)
                {
                    toolStripStatusLabel1.Text = "Количество: 0 шт.";
                    toolStripStatusLabel2.Text = "Стоимость: 0 руб.";
                    return;
                }

                int totalQuantity = 0;
                int totalPrice = 0;

                if (products.Count > 0)
                {
                    totalQuantity = products.Sum(p => p.Quantity);
                    totalPrice = products.Sum(p => (int)p.Price * p.Quantity);
                }

                toolStripStatusLabel1.Text = $"Количество: {totalQuantity} шт.";
                toolStripStatusLabel2.Text = $"Стоимость: {totalPrice} руб.";

                toolStripStatusLabel1.ToolTipText = $"Всего товаров: {products.Count}\nОбщее количество: {totalQuantity:N0} шт.";
                toolStripStatusLabel2.ToolTipText = $"Общая стоимость: {totalPrice:N2} руб.";


            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Количество: ошибка";
                toolStripStatusLabel2.Text = "Стоимость: ошибка";
                Console.WriteLine($"Ошибка в UpdateStatus: {ex.Message}");
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = products;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProducts();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файл с данными";
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;

                        products.Clear();

                        loadProducts();

                        UpdateStatus();

                        MessageBox.Show(
                            $"Данные успешно загружены из файла:\n{Path.GetFileName(filePath)}\n" +
                            $"Загружено товаров: {products.Count}",
                            "Загрузка завершена",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.Text = $"Управление товарами - {Path.GetFileName(filePath)}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Ошибка при загрузке файла:\n{ex.Message}",
                            "Ошибка загрузки",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
        DialogResult result = MessageBox.Show(
        "Вы действительно хотите выйти?",
        "Выход из программы",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = new Product();

                using (Form2 addForm = new Form2())
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        addForm.Product.ID = products.Count > 0 ? products.Max(p => p.ID) + 1 : 1;

                        products.Add(addForm.Product);

                        dataGridView1.Refresh();

                        UpdateStatus();

                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                        }

                        MessageBox.Show("Товар успешно добавлен!",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Product selectedProduct = dataGridView1.CurrentRow.DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    products.Remove(selectedProduct);
                    UpdateStatus();
                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Выберите товар для редактирования",
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Product selectedProduct = dataGridView1.CurrentRow.DataBoundItem as Product;

                if (selectedProduct != null)
                {
                    using (Form2 editForm = new Form2(selectedProduct))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {

                            dataGridView1.Refresh();

                            UpdateStatus();

                            MessageBox.Show("Товар успешно обновлен!",
                                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
