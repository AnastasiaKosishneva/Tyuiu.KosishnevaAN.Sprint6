using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosishnevaAN.Sprint6.Task5.V3.Lib;
using System.IO;

namespace Tyuiu.KosishnevaAN.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelUSLOVIE_KAN_Click(object sender, EventArgs e)
        {
            //
        }

        private void textBoxRESULT_KAN_TextChanged(object sender, EventArgs e)
        {
            //
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Lenovo\Desktop\DataSprint6\InPutFileTask5V3.txt";
        private void buttonToDo_KAN_Click(object sender, EventArgs e)
        {
            dataGridViewRESULT_KAN.ColumnCount = 2;
            dataGridViewRESULT_KAN.Columns[0].Width = 20;
            dataGridViewRESULT_KAN.Columns[1].Width = 50;

            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            chart1.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewRESULT_KAN.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chart1.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonOTKR_KAN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSPRAVKA_KAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка Косишнева Анастасия Николаевна группы ИСТНб-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}