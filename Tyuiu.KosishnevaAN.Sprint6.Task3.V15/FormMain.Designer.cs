
namespace Tyuiu.KosishnevaAN.Sprint6.Task3.V15
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
            this.groupBoxUSLIVIE_KAN = new System.Windows.Forms.GroupBox();
            this.textBoxUSLOVIE = new System.Windows.Forms.TextBox();
            this.groupBoxRESULT_KAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewRESULT_KAN = new System.Windows.Forms.DataGridView();
            this.labelRESULT_KAN = new System.Windows.Forms.Label();
            this.buttonToDo_KAN = new System.Windows.Forms.Button();
            this.buttonVOPROS_KAN = new System.Windows.Forms.Button();
            this.dataGridViewDANO_KAN = new System.Windows.Forms.DataGridView();
            this.groupBoxUSLIVIE_KAN.SuspendLayout();
            this.groupBoxRESULT_KAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRESULT_KAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDANO_KAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUSLIVIE_KAN
            // 
            this.groupBoxUSLIVIE_KAN.Controls.Add(this.textBoxUSLOVIE);
            this.groupBoxUSLIVIE_KAN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUSLIVIE_KAN.Name = "groupBoxUSLIVIE_KAN";
            this.groupBoxUSLIVIE_KAN.Size = new System.Drawing.Size(331, 325);
            this.groupBoxUSLIVIE_KAN.TabIndex = 0;
            this.groupBoxUSLIVIE_KAN.TabStop = false;
            this.groupBoxUSLIVIE_KAN.Text = "Условие";
            // 
            // textBoxUSLOVIE
            // 
            this.textBoxUSLOVIE.Location = new System.Drawing.Point(28, 31);
            this.textBoxUSLOVIE.Multiline = true;
            this.textBoxUSLOVIE.Name = "textBoxUSLOVIE";
            this.textBoxUSLOVIE.Size = new System.Drawing.Size(265, 197);
            this.textBoxUSLOVIE.TabIndex = 0;
            this.textBoxUSLOVIE.Text = "Дана матрица 5 на 5\r\n33  28  31  19   4 \r\n1    32  -3  -17 -12\r\n24 -19  26  31  -" +
    "3\r\n30 -16 29   28  8\r\n30    5  11   7    32";
            // 
            // groupBoxRESULT_KAN
            // 
            this.groupBoxRESULT_KAN.Controls.Add(this.dataGridViewRESULT_KAN);
            this.groupBoxRESULT_KAN.Controls.Add(this.labelRESULT_KAN);
            this.groupBoxRESULT_KAN.Location = new System.Drawing.Point(629, 13);
            this.groupBoxRESULT_KAN.Name = "groupBoxRESULT_KAN";
            this.groupBoxRESULT_KAN.Size = new System.Drawing.Size(282, 368);
            this.groupBoxRESULT_KAN.TabIndex = 1;
            this.groupBoxRESULT_KAN.TabStop = false;
            this.groupBoxRESULT_KAN.Text = "Вывод данных";
            // 
            // dataGridViewRESULT_KAN
            // 
            this.dataGridViewRESULT_KAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRESULT_KAN.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewRESULT_KAN.Name = "dataGridViewRESULT_KAN";
            this.dataGridViewRESULT_KAN.RowHeadersVisible = false;
            this.dataGridViewRESULT_KAN.RowHeadersWidth = 51;
            this.dataGridViewRESULT_KAN.RowTemplate.Height = 24;
            this.dataGridViewRESULT_KAN.Size = new System.Drawing.Size(260, 256);
            this.dataGridViewRESULT_KAN.TabIndex = 1;
            // 
            // labelRESULT_KAN
            // 
            this.labelRESULT_KAN.AutoSize = true;
            this.labelRESULT_KAN.Location = new System.Drawing.Point(7, 22);
            this.labelRESULT_KAN.Name = "labelRESULT_KAN";
            this.labelRESULT_KAN.Size = new System.Drawing.Size(80, 17);
            this.labelRESULT_KAN.TabIndex = 0;
            this.labelRESULT_KAN.Text = "Результат:";
            this.labelRESULT_KAN.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonToDo_KAN
            // 
            this.buttonToDo_KAN.Location = new System.Drawing.Point(802, 387);
            this.buttonToDo_KAN.Name = "buttonToDo_KAN";
            this.buttonToDo_KAN.Size = new System.Drawing.Size(109, 51);
            this.buttonToDo_KAN.TabIndex = 2;
            this.buttonToDo_KAN.Text = "Выполнить";
            this.buttonToDo_KAN.UseVisualStyleBackColor = true;
            this.buttonToDo_KAN.Click += new System.EventHandler(this.buttonToDo_KAN_Click);
            // 
            // buttonVOPROS_KAN
            // 
            this.buttonVOPROS_KAN.Location = new System.Drawing.Point(750, 402);
            this.buttonVOPROS_KAN.Name = "buttonVOPROS_KAN";
            this.buttonVOPROS_KAN.Size = new System.Drawing.Size(37, 36);
            this.buttonVOPROS_KAN.TabIndex = 3;
            this.buttonVOPROS_KAN.Text = "?";
            this.buttonVOPROS_KAN.UseVisualStyleBackColor = true;
            this.buttonVOPROS_KAN.Click += new System.EventHandler(this.buttonVOPROS_KAN_Click);
            // 
            // dataGridViewDANO_KAN
            // 
            this.dataGridViewDANO_KAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDANO_KAN.Location = new System.Drawing.Point(350, 23);
            this.dataGridViewDANO_KAN.Name = "dataGridViewDANO_KAN";
            this.dataGridViewDANO_KAN.RowHeadersVisible = false;
            this.dataGridViewDANO_KAN.RowHeadersWidth = 51;
            this.dataGridViewDANO_KAN.RowTemplate.Height = 24;
            this.dataGridViewDANO_KAN.Size = new System.Drawing.Size(253, 358);
            this.dataGridViewDANO_KAN.TabIndex = 4;
            // 
            // FormMain_KAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.dataGridViewDANO_KAN);
            this.Controls.Add(this.buttonVOPROS_KAN);
            this.Controls.Add(this.buttonToDo_KAN);
            this.Controls.Add(this.groupBoxRESULT_KAN);
            this.Controls.Add(this.groupBoxUSLIVIE_KAN);
            this.MaximizeBox = false;
            this.Name = "FormMain_KAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 3 | Вариант 15 | Косишнева А. Н.";
            this.Load += new System.EventHandler(this.FormMain_KAN_Load);
            this.groupBoxUSLIVIE_KAN.ResumeLayout(false);
            this.groupBoxUSLIVIE_KAN.PerformLayout();
            this.groupBoxRESULT_KAN.ResumeLayout(false);
            this.groupBoxRESULT_KAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRESULT_KAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDANO_KAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUSLIVIE_KAN;
        private System.Windows.Forms.TextBox textBoxUSLOVIE;
        private System.Windows.Forms.GroupBox groupBoxRESULT_KAN;
        private System.Windows.Forms.Label labelRESULT_KAN;
        private System.Windows.Forms.DataGridView dataGridViewRESULT_KAN;
        private System.Windows.Forms.Button buttonToDo_KAN;
        private System.Windows.Forms.Button buttonVOPROS_KAN;
        private System.Windows.Forms.DataGridView dataGridViewDANO_KAN;
    }
}

