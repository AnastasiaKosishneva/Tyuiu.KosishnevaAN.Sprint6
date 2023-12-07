
namespace Tyuiu.KosishnevaAN.Sprint6.Task6.V25
{
    partial class FormAbout
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelIMA = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelMESTO = new System.Windows.Forms.Label();
            this.label4RASP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(449, 196);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 30);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelIMA
            // 
            this.labelIMA.AutoSize = true;
            this.labelIMA.Location = new System.Drawing.Point(12, 9);
            this.labelIMA.Name = "labelIMA";
            this.labelIMA.Size = new System.Drawing.Size(216, 34);
            this.labelIMA.TabIndex = 1;
            this.labelIMA.Text = "Разработчица: Косишнева А.Н.\r\nГруппа ИСНТб-23-1\r\n";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(12, 56);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(369, 17);
            this.labelV.TabIndex = 2;
            this.labelV.Text = "программа разработанна в рамках изучения языка C#";
            // 
            // labelMESTO
            // 
            this.labelMESTO.AutoSize = true;
            this.labelMESTO.Location = new System.Drawing.Point(12, 85);
            this.labelMESTO.Name = "labelMESTO";
            this.labelMESTO.Size = new System.Drawing.Size(340, 34);
            this.labelMESTO.TabIndex = 3;
            this.labelMESTO.Text = "Тюменский индустриальный университет (с) 2023\r\nВысшая школа цифровых технологий с" +
    " 2023";
            // 
            // label4RASP
            // 
            this.label4RASP.AutoSize = true;
            this.label4RASP.Location = new System.Drawing.Point(12, 130);
            this.label4RASP.Name = "label4RASP";
            this.label4RASP.Size = new System.Drawing.Size(376, 17);
            this.label4RASP.TabIndex = 4;
            this.label4RASP.Text = "Внутреннее имя: Tyuiu.KosishnevaAN.Sprint6.Task6.V25\r\n";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 238);
            this.Controls.Add(this.label4RASP);
            this.Controls.Add(this.labelMESTO);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelIMA);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelIMA;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelMESTO;
        private System.Windows.Forms.Label label4RASP;
    }
}