using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosishnevaAN.Sprint6.Task2.V30.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task2.V30
{
    public partial class FormMain_KAN : Form
    {
        public FormMain_KAN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonToDo_KAN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxSTART_KAN.Text);
                int stoptStep = Convert.ToInt32(textBoxSTOP_KAN.Text);

                int len = ds.GetMassFunction(startStep, stoptStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stoptStep);
                this.chart_KAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_KAN.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i ++)
                {
                    this.dataGridView_KAN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart_KAN.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;

                }

            }
            catch
            {
                MessageBox.Show("Введены неверные даннаые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonToDo_KAN_MouseEnter(object sender, EventArgs e)
        {
            buttonToDo_KAN.BackColor = Color.Red;
        }

        private void buttonToDo_KAN_MouseLeave(object sender, EventArgs e)
        {
            buttonToDo_KAN.BackColor = Color.Green;
        }

        private void buttonToDo_KAN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonToDo_KAN.BackColor = Color.Blue;
        }

        private void buttonSPAVKA_KAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxUSLOVIE_KAN_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
