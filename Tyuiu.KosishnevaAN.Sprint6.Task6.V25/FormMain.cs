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
using Tyuiu.KosishnevaAN.Sprint6.Task6.V25.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task6.V25
{
    public partial class FormMain_KAN : Form
    {
        public FormMain_KAN()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonFAIL_KAN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAN.ShowDialog();
            openFilePath = openFileDialogTask_KAN.FileName;
            textBoxDANO_KAN.Text = File.ReadAllText(openFilePath);
            groupBoxDANO_KAN.Text = groupBoxDANO_KAN.Text + " " + openFileDialogTask_KAN.FileName;
            buttonToDo_KAN.Enabled = true;
        }

        private void buttonToDo_KAN_Click(object sender, EventArgs e)
        {
            textBoxRESULT_KAN.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonVOPROS_KAN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
