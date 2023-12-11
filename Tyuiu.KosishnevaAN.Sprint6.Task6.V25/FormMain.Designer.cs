
namespace Tyuiu.KosishnevaAN.Sprint6.Task6.V25
{
    partial class FormMain_KAN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KAN));
            this.panelToDo_KAN = new System.Windows.Forms.Panel();
            this.buttonToDo_KAN = new System.Windows.Forms.Button();
            this.buttonFAIL_KAN = new System.Windows.Forms.Button();
            this.buttonVOPROS_KAN = new System.Windows.Forms.Button();
            this.panel_KAN = new System.Windows.Forms.Panel();
            this.groupBoxRESULT_KAN = new System.Windows.Forms.GroupBox();
            this.textBoxRESULT_KAN = new System.Windows.Forms.TextBox();
            this.groupBoxDANO_KAN = new System.Windows.Forms.GroupBox();
            this.textBoxDANO_KAN = new System.Windows.Forms.TextBox();
            this.textBoxUSLOVIE_KAN = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_KAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KAN = new System.Windows.Forms.ToolTip(this.components);
            this.panelToDo_KAN.SuspendLayout();
            this.panel_KAN.SuspendLayout();
            this.groupBoxRESULT_KAN.SuspendLayout();
            this.groupBoxDANO_KAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToDo_KAN
            // 
            this.panelToDo_KAN.Controls.Add(this.buttonToDo_KAN);
            this.panelToDo_KAN.Controls.Add(this.buttonFAIL_KAN);
            this.panelToDo_KAN.Controls.Add(this.buttonVOPROS_KAN);
            this.panelToDo_KAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToDo_KAN.Location = new System.Drawing.Point(0, 0);
            this.panelToDo_KAN.Name = "panelToDo_KAN";
            this.panelToDo_KAN.Size = new System.Drawing.Size(1189, 100);
            this.panelToDo_KAN.TabIndex = 0;
            // 
            // buttonToDo_KAN
            // 
            this.buttonToDo_KAN.Location = new System.Drawing.Point(129, 6);
            this.buttonToDo_KAN.Name = "buttonToDo_KAN";
            this.buttonToDo_KAN.Size = new System.Drawing.Size(111, 91);
            this.buttonToDo_KAN.TabIndex = 4;
            this.buttonToDo_KAN.Text = "Выполнить задание";
            this.toolTip_KAN.SetToolTip(this.buttonToDo_KAN, resources.GetString("buttonToDo_KAN.ToolTip"));
            this.buttonToDo_KAN.UseVisualStyleBackColor = true;
            this.buttonToDo_KAN.Click += new System.EventHandler(this.buttonToDo_KAN_Click);
            // 
            // buttonFAIL_KAN
            // 
            this.buttonFAIL_KAN.Location = new System.Drawing.Point(12, 6);
            this.buttonFAIL_KAN.Name = "buttonFAIL_KAN";
            this.buttonFAIL_KAN.Size = new System.Drawing.Size(111, 91);
            this.buttonFAIL_KAN.TabIndex = 3;
            this.buttonFAIL_KAN.Text = "Показать содержание файла";
            this.toolTip_KAN.SetToolTip(this.buttonFAIL_KAN, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonFAIL_KAN.UseVisualStyleBackColor = true;
            this.buttonFAIL_KAN.Click += new System.EventHandler(this.buttonFAIL_KAN_Click);
            // 
            // buttonVOPROS_KAN
            // 
            this.buttonVOPROS_KAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVOPROS_KAN.Location = new System.Drawing.Point(1066, 3);
            this.buttonVOPROS_KAN.Name = "buttonVOPROS_KAN";
            this.buttonVOPROS_KAN.Size = new System.Drawing.Size(111, 91);
            this.buttonVOPROS_KAN.TabIndex = 2;
            this.buttonVOPROS_KAN.Text = "Справка";
            this.toolTip_KAN.SetToolTip(this.buttonVOPROS_KAN, "Сведения о программе");
            this.buttonVOPROS_KAN.UseVisualStyleBackColor = true;
            this.buttonVOPROS_KAN.Click += new System.EventHandler(this.buttonVOPROS_KAN_Click);
            // 
            // panel_KAN
            // 
            this.panel_KAN.Controls.Add(this.groupBoxRESULT_KAN);
            this.panel_KAN.Controls.Add(this.groupBoxDANO_KAN);
            this.panel_KAN.Controls.Add(this.textBoxUSLOVIE_KAN);
            this.panel_KAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_KAN.Location = new System.Drawing.Point(0, 100);
            this.panel_KAN.Name = "panel_KAN";
            this.panel_KAN.Size = new System.Drawing.Size(1189, 554);
            this.panel_KAN.TabIndex = 1;
            // 
            // groupBoxRESULT_KAN
            // 
            this.groupBoxRESULT_KAN.Controls.Add(this.textBoxRESULT_KAN);
            this.groupBoxRESULT_KAN.Location = new System.Drawing.Point(586, 78);
            this.groupBoxRESULT_KAN.Name = "groupBoxRESULT_KAN";
            this.groupBoxRESULT_KAN.Size = new System.Drawing.Size(591, 473);
            this.groupBoxRESULT_KAN.TabIndex = 6;
            this.groupBoxRESULT_KAN.TabStop = false;
            this.groupBoxRESULT_KAN.Text = "Вывод:";
            // 
            // textBoxRESULT_KAN
            // 
            this.textBoxRESULT_KAN.Location = new System.Drawing.Point(6, 21);
            this.textBoxRESULT_KAN.Multiline = true;
            this.textBoxRESULT_KAN.Name = "textBoxRESULT_KAN";
            this.textBoxRESULT_KAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRESULT_KAN.Size = new System.Drawing.Size(579, 443);
            this.textBoxRESULT_KAN.TabIndex = 0;
            // 
            // groupBoxDANO_KAN
            // 
            this.groupBoxDANO_KAN.Controls.Add(this.textBoxDANO_KAN);
            this.groupBoxDANO_KAN.Location = new System.Drawing.Point(4, 78);
            this.groupBoxDANO_KAN.Name = "groupBoxDANO_KAN";
            this.groupBoxDANO_KAN.Size = new System.Drawing.Size(575, 473);
            this.groupBoxDANO_KAN.TabIndex = 5;
            this.groupBoxDANO_KAN.TabStop = false;
            this.groupBoxDANO_KAN.Text = "Ввод:";
            // 
            // textBoxDANO_KAN
            // 
            this.textBoxDANO_KAN.Location = new System.Drawing.Point(8, 21);
            this.textBoxDANO_KAN.Multiline = true;
            this.textBoxDANO_KAN.Name = "textBoxDANO_KAN";
            this.textBoxDANO_KAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDANO_KAN.Size = new System.Drawing.Size(561, 443);
            this.textBoxDANO_KAN.TabIndex = 0;
            // 
            // textBoxUSLOVIE_KAN
            // 
            this.textBoxUSLOVIE_KAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUSLOVIE_KAN.Location = new System.Drawing.Point(3, 4);
            this.textBoxUSLOVIE_KAN.Multiline = true;
            this.textBoxUSLOVIE_KAN.Name = "textBoxUSLOVIE_KAN";
            this.textBoxUSLOVIE_KAN.Size = new System.Drawing.Size(1183, 67);
            this.textBoxUSLOVIE_KAN.TabIndex = 0;
            this.textBoxUSLOVIE_KAN.Text = "Условие";
            // 
            // openFileDialogTask_KAN
            // 
            this.openFileDialogTask_KAN.FileName = "openFileDialog1";
            // 
            // toolTip_KAN
            // 
            this.toolTip_KAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_KAN.ToolTipTitle = "Подсказка";
            // 
            // FormMain_KAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 654);
            this.Controls.Add(this.panel_KAN);
            this.Controls.Add(this.panelToDo_KAN);
            this.Name = "FormMain_KAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Спринт 6 | Таск 6 | Вариант 25 | Косишнева А. Н.";
            this.panelToDo_KAN.ResumeLayout(false);
            this.panel_KAN.ResumeLayout(false);
            this.panel_KAN.PerformLayout();
            this.groupBoxRESULT_KAN.ResumeLayout(false);
            this.groupBoxRESULT_KAN.PerformLayout();
            this.groupBoxDANO_KAN.ResumeLayout(false);
            this.groupBoxDANO_KAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToDo_KAN;
        private System.Windows.Forms.Button buttonToDo_KAN;
        private System.Windows.Forms.Button buttonFAIL_KAN;
        private System.Windows.Forms.Button buttonVOPROS_KAN;
        private System.Windows.Forms.Panel panel_KAN;
        private System.Windows.Forms.TextBox textBoxUSLOVIE_KAN;
        private System.Windows.Forms.ToolTip toolTip_KAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAN;
        private System.Windows.Forms.GroupBox groupBoxRESULT_KAN;
        private System.Windows.Forms.TextBox textBoxRESULT_KAN;
        private System.Windows.Forms.GroupBox groupBoxDANO_KAN;
        private System.Windows.Forms.TextBox textBoxDANO_KAN;
    }
}

