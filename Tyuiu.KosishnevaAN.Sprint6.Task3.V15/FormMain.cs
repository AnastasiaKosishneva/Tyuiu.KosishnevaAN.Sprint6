using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosishnevaAN.Sprint6.Task3.V15.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task3.V15
{
    public partial class FormMain_KAN : Form
    {
        public FormMain_KAN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
        {
             { 33, 28, 31, 19, 4 },
             { 1, 32, -3, -17, -12 },
             { 24, -19, 26, 31, -3 },
             { 30, -16, 29, 28, 8 },
             { 30, 5, 11, 7, 32 },
        }; 

        private void buttonToDo_KAN_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewRESULT_KAN.ColumnCount = columns;
            dataGridViewRESULT_KAN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {

                dataGridViewRESULT_KAN.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewRESULT_KAN.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRESULT_KAN.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }

        }

        private void buttonVOPROS_KAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-23-1 Косишнева Анастасия Николанвна", "Сообщение");
        }

        private void FormMain_KAN_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;


            dataGridViewDANO_KAN.ColumnCount = columns;
            
            dataGridViewDANO_KAN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewDANO_KAN.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewDANO_KAN.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
    }
}
}
