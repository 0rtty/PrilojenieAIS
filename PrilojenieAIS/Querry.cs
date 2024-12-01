using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace PrilojenieAIS
{
    public partial class Querry : UserControl
    {
        Database database = new Database();
        List<string> tables = new List<string>() { "customers", "products", "employees", "orders", "order_items", "reviews" };
        int selected;
        public Querry()
        {
            InitializeComponent();
            database.OpenConnection();
            dataGridView1.DataSource = database.ExecuteCommand("select * from " + tables[selected = new Random().Next(0, 5)]);
            buttonTable.Text = tables[selected];
            database.CloseConnection();
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            string query = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Пожалуйста, введите запрос.");
                return;
            }

            if (IsRestrictedCommand(query))
            {
                MessageBox.Show("У вас нет прав для выполнения этой команды.");
                return;
            }

            try
            {
                database.OpenConnection();
                DataTable dataTable = database.ExecuteCommand(query);
                database.CloseConnection();

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения.");
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                }
                buttonTable.Text = "Пользовательский запрос";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запроса: {ex.Message}");
                database.CloseConnection();
            }
        }

        private bool IsRestrictedCommand(string query)
        {
            string[] restrictedCommands = { "INSERT", "DELETE", "UPDATE", "DROP" };
            string upperQuery = query.ToUpper();
            foreach (var command in restrictedCommands)
            {
                if (upperQuery.Contains(command))
                {
                    return true;
                }
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.ParentForm as Form1;
            Lesson scheme = new Lesson();
            scheme.SetImage(".\\Resources\\Diagramm2.PNG");
            form1.AddControl(scheme);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database.OpenConnection();
            if (selected < 5)
            {
                dataGridView1.DataSource = database.ExecuteCommand("select * from " + tables[selected += 1]);
                buttonTable.Text = tables[selected];
            }
            database.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenConnection();
            if (selected > 0)
            {
                dataGridView1.DataSource = database.ExecuteCommand("select * from " + tables[selected -= 1]);
                buttonTable.Text = tables[selected];
            }
            database.CloseConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл как";
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    if (File.Exists(filePath))
                    {
                        DialogResult result = MessageBox.Show("Файл уже существует. Перезаписать?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Cancel)
                            return;
                        else if (result == DialogResult.No)
                            return;
                    }

                    using (StreamWriter writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
                    {
                        writer.Write(richTextBox1.Text);
                    }
                    MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Сохранить файл как";
            openFileDialog.DefaultExt = "txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (StreamReader reader = new StreamReader(filePath, System.Text.Encoding.UTF8))
                    {
                        richTextBox1.Text = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Querry_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show("Сохранить запрос? Сохранить?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.No)
                    return;
                buttonSave_Click(sender, e);
            }
        }

        private void buttonDescription_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.ParentForm as Form1;
            Lesson description = new Lesson();
            description.SetImage(".\\Resources\\description.PNG");
            form1.AddControl(description);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Сохранить файл как";
            saveFileDialog.DefaultExt = "xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    var excelApp = new Excel.Application();
                    if (excelApp == null)
                    {
                        MessageBox.Show("Не удалось создать экземпляр Excel.");
                        return;
                    }

                    var workBook = excelApp.Workbooks.Add();
                    var workSheet = (Excel.Worksheet)workBook.Sheets[1];

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    workBook.SaveAs(filePath);
                    MessageBox.Show("Файл успешно сохранен!");
                    excelApp.Visible = true;

                    Marshal.ReleaseComObject(excelApp);
                    Marshal.ReleaseComObject(workBook);
                    Marshal.ReleaseComObject(workSheet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте: {ex.Message}");
                }
            }
        }
    }
}
