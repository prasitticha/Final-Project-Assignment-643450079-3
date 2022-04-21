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

namespace Final_Project_Assignment_643450079_3
{
    public partial class Form2 : Form
    {
        Product product = new Product();
        Calculator calculator = new Calculator();

        DataTable table = new DataTable();
        int indexRow;

        public Form2()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "CSV (*.csv) | *.csv";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(opd.FileName);

                string readAllText = File.ReadAllText(opd.FileName);
                for (int i = 1; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4], allDATASplited[5]);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV(*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                {
                    int columnCount = dataGridView1.Columns.Count;
                    string column = "";
                    string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                    }
                    outputCSV[0] += column;
                    for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                    }
                    File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                }
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            string ProductCode = textBox_ProductCode.Text;
            string List = textBox_ListProduct.Text;
            string INputProduct = textBox_INputProduct.Text;
            string OUTputProduct = textBox_OUTputProduct.Text;

            product.ProductCode = ProductCode;
            product.List = List;
            product.INputProduct = INputProduct;
            product.OPTputProduct = OUTputProduct;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = product.ProductCode;
            dataGridView1.Rows[n].Cells[1].Value = product.List;
            dataGridView1.Rows[n].Cells[2].Value = product.INputProduct;
            dataGridView1.Rows[n].Cells[3].Value = product.OPTputProduct;

            calculator.addCalculator(INputProduct, OUTputProduct);
            int num = calculator.getCalculator();
            dataGridView1.Rows[n].Cells[4].Value = num.ToString();

            textBox_ProductCode.Text = "";
            textBox_ListProduct.Text = "";
            textBox_INputProduct.Text = "";
            textBox_OUTputProduct.Text = "";
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow UpdateDataGridViewRow = dataGridView1.Rows[indexRow];

            UpdateDataGridViewRow.Cells[0].Value = textBox_ProductCode.Text;
            UpdateDataGridViewRow.Cells[1].Value = textBox_ListProduct.Text;
            UpdateDataGridViewRow.Cells[2].Value = textBox_INputProduct.Text;
            UpdateDataGridViewRow.Cells[3].Value = textBox_OUTputProduct.Text;

            calculator.addCalculatorUpdate(textBox_INputProduct.Text, textBox_OUTputProduct.Text);

            int num = calculator.getCalculatorUpdate();

            UpdateDataGridViewRow.Cells[4].Value = num.ToString();

            textBox_ProductCode.Text = "";
            textBox_ListProduct.Text = "";
            textBox_INputProduct.Text = "";
            textBox_OUTputProduct.Text = "";
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textBox_ProductCode.Text = row.Cells[0].Value.ToString();
            textBox_ListProduct.Text = row.Cells[1].Value.ToString();
            textBox_INputProduct.Text = row.Cells[2].Value.ToString();
            textBox_OUTputProduct.Text = row.Cells[3].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = DateTime.Now.ToString("dd/MM/yyyy     HH:mm:ss");
        }
    }
}
