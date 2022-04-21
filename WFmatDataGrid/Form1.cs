using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmatDataGrid
{
    public partial class Form1 : Form
    {
        int m, n;
        double[,] elem;

        public Form1()
        {
            InitializeComponent();
            listBoxMatrix.Items.Clear();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReadM_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    elem[i, j] = double.Parse(dataGridMatrix.Rows[i].Cells[j].Value.ToString());
                }
            }
        }

        private void buttonInputM_Click(object sender, EventArgs e)
        {
            string aux;

            for (int i = 0; i < m; i++)
            {
                aux = " ";

                for (int j = 0; j < n; j++)
                {
                    aux += elem[i, j] + " ";
                }

                listBoxMatrix.Items.Add(aux);
            }
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            m = int.Parse(textBoxM.Text);
            n = int.Parse(textBoxN.Text);
            elem = new double[m, n];
            dataGridMatrix.RowCount = m;
            dataGridMatrix.ColumnCount= n;
        }
    }
}
