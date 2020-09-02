using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace работа_с_таблицами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            {
                while (!int.TryParse(textBox1.Text, out n) | n < 1)
                {
                    MessageBox.Show("Ошибка в данных!");
                    textBox1.Focus();
                    return;
                }
                dataGridView1.ColumnCount = dataGridView1.RowCount = n;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        dataGridView1[i, j].Value = i == j ? "1" : "0";
            }
        }
    }
}
