using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KosishnevaAN.Sprint6.Task1.V20.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task1.V20
{
    public partial class FormMain_KAN : System.Windows.Forms.Form
    {
        public FormMain_KAN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonToDo_Click(object sender, EventArgs e)
        {
            int startstep = Convert.ToInt32(textBoxStart_KAN.Text);
            int stopstep = Convert.ToInt32(textBoxSTOP_KAN.Text);

            string strline;

            int len = ds.GetMassFunction(startstep, stopstep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startstep, stopstep);
            textBoxRES_KAN.Text = "";
            textBoxRES_KAN.AppendText("+----------+------------+" + Environment.NewLine);
            textBoxRES_KAN.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
            textBoxRES_KAN.AppendText("+----------+------------+" + Environment.NewLine);

            for (int i = 0; i <= len - 1; i++)
            {
                strline = String.Format("|{0,5:d}     | {1,6:f2}    | ", startstep, valueArray[i]);
                textBoxRES_KAN.AppendText(strline + Environment.NewLine);
                startstep++;
            }
            textBoxRES_KAN.AppendText("+----------+------------+" + Environment.NewLine);


        }

        private void buttonSPRAVKA_KAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб-23-1 Косишнева А. Н.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
