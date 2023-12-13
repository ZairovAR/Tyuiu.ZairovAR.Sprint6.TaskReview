using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZairovAR.Sprint6.TaskReview.V8.Lib;
namespace Tyuiu.ZairovAR.Sprint6.TaskReview.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonMatrix_Click(object sender, EventArgs e)
        {
            try 
            {
                int n = Convert.ToInt32(textboxN.Text);
                int m = Convert.ToInt32(textBoxM.Text);
                int n1 = Convert.ToInt32(textBoxRandomStart.Text);
                int n2 = Convert.ToInt32(textBoxRandomStop.Text);
                

                int[,] array = new int[n, m];

               
                array = ds.GetMatrix( n,  m,  n1, n2);

                dataGridViewMatrix.ColumnCount = n;
                dataGridViewMatrix.RowCount = m;

                for (int i = 0; i < m; i++)
                {
                    dataGridViewMatrix.Columns[i].Width = 90;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                    }
                }

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textboxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);
            int c = Convert.ToInt32(textBoxColum_C.Text);
            int k = Convert.ToInt32(textBoxMinusStart.Text);
            int l = Convert.ToInt32(textBoxMinusStop.Text);

            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) 
                {
                    array[i, j] = Convert.ToInt32(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }
            }

            int res = ds.resultGetMatrix(array, c, k, l);
            textBoxResult.Text = Convert.ToString(res);
        }
    }
}
