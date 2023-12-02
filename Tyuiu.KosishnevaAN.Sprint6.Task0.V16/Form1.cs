using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosishnevaAN.Sprint6.Task0.V16.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task0.V16
{
    public partial class FormMain_KAN : Form
    {
        public FormMain_KAN()
        {
            InitializeComponent();
        }

        private void buttonToDo_KAN_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRESULTAT_KAN.Text = Convert.ToString(ds.SaveToFileTextData(Convert.ToInt32(textBoxDONE_KAN.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные даннаые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxDONE_KAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonVOPROS_KAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
