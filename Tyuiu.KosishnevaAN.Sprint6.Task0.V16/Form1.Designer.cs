
namespace Tyuiu.KosishnevaAN.Sprint6.Task0.V16
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
            this.groupBoxUSLOVIE_KAN = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_KAN = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KAN = new System.Windows.Forms.TextBox();
            this.groupBoxDone_KAN = new System.Windows.Forms.GroupBox();
            this.textBoxDONE_KAN = new System.Windows.Forms.TextBox();
            this.labelX_KAN = new System.Windows.Forms.Label();
            this.groupBoxRESULT_KAN = new System.Windows.Forms.GroupBox();
            this.textBoxRESULTAT_KAN = new System.Windows.Forms.TextBox();
            this.labelRESULTAT_KAN = new System.Windows.Forms.Label();
            this.buttonToDo_KAN = new System.Windows.Forms.Button();
            this.buttonVOPROS_KAN = new System.Windows.Forms.Button();
            this.groupBoxUSLOVIE_KAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KAN)).BeginInit();
            this.groupBoxDone_KAN.SuspendLayout();
            this.groupBoxRESULT_KAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUSLOVIE_KAN
            // 
            this.groupBoxUSLOVIE_KAN.Controls.Add(this.textBoxTask_KAN);
            this.groupBoxUSLOVIE_KAN.Location = new System.Drawing.Point(12, 28);
            this.groupBoxUSLOVIE_KAN.Name = "groupBoxUSLOVIE_KAN";
            this.groupBoxUSLOVIE_KAN.Size = new System.Drawing.Size(598, 171);
            this.groupBoxUSLOVIE_KAN.TabIndex = 0;
            this.groupBoxUSLOVIE_KAN.TabStop = false;
            this.groupBoxUSLOVIE_KAN.Text = "УСЛОВИЕ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox_KAN
            // 
            this.pictureBox_KAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_KAN.Image")));
            this.pictureBox_KAN.Location = new System.Drawing.Point(640, 70);
            this.pictureBox_KAN.Name = "pictureBox_KAN";
            this.pictureBox_KAN.Size = new System.Drawing.Size(133, 76);
            this.pictureBox_KAN.TabIndex = 1;
            this.pictureBox_KAN.TabStop = false;
            // 
            // textBoxTask_KAN
            // 
            this.textBoxTask_KAN.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_KAN.Multiline = true;
            this.textBoxTask_KAN.Name = "textBoxTask_KAN";
            this.textBoxTask_KAN.Size = new System.Drawing.Size(586, 60);
            this.textBoxTask_KAN.TabIndex = 0;
            this.textBoxTask_KAN.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой. Графический интерфейс оформить по шаблону и" +
    "з лекции.";
            // 
            // groupBoxDone_KAN
            // 
            this.groupBoxDone_KAN.Controls.Add(this.labelX_KAN);
            this.groupBoxDone_KAN.Controls.Add(this.textBoxDONE_KAN);
            this.groupBoxDone_KAN.Location = new System.Drawing.Point(12, 205);
            this.groupBoxDone_KAN.Name = "groupBoxDone_KAN";
            this.groupBoxDone_KAN.Size = new System.Drawing.Size(500, 107);
            this.groupBoxDone_KAN.TabIndex = 2;
            this.groupBoxDone_KAN.TabStop = false;
            this.groupBoxDone_KAN.Text = "ВВЕДИТЕ ДАННЫЕ";
            // 
            // textBoxDONE_KAN
            // 
            this.textBoxDONE_KAN.Location = new System.Drawing.Point(155, 35);
            this.textBoxDONE_KAN.Name = "textBoxDONE_KAN";
            this.textBoxDONE_KAN.Size = new System.Drawing.Size(256, 22);
            this.textBoxDONE_KAN.TabIndex = 0;
            this.textBoxDONE_KAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDONE_KAN_KeyPress);
            // 
            // labelX_KAN
            // 
            this.labelX_KAN.AutoSize = true;
            this.labelX_KAN.Location = new System.Drawing.Point(6, 35);
            this.labelX_KAN.Name = "labelX_KAN";
            this.labelX_KAN.Size = new System.Drawing.Size(143, 17);
            this.labelX_KAN.TabIndex = 1;
            this.labelX_KAN.Text = "Введите значение X";
            // 
            // groupBoxRESULT_KAN
            // 
            this.groupBoxRESULT_KAN.Controls.Add(this.labelRESULTAT_KAN);
            this.groupBoxRESULT_KAN.Controls.Add(this.textBoxRESULTAT_KAN);
            this.groupBoxRESULT_KAN.Location = new System.Drawing.Point(532, 205);
            this.groupBoxRESULT_KAN.Name = "groupBoxRESULT_KAN";
            this.groupBoxRESULT_KAN.Size = new System.Drawing.Size(256, 110);
            this.groupBoxRESULT_KAN.TabIndex = 3;
            this.groupBoxRESULT_KAN.TabStop = false;
            this.groupBoxRESULT_KAN.Text = "ВЫВОД ДАННЫХ";
            // 
            // textBoxRESULTAT_KAN
            // 
            this.textBoxRESULTAT_KAN.Location = new System.Drawing.Point(88, 32);
            this.textBoxRESULTAT_KAN.Name = "textBoxRESULTAT_KAN";
            this.textBoxRESULTAT_KAN.Size = new System.Drawing.Size(153, 22);
            this.textBoxRESULTAT_KAN.TabIndex = 0;
            // 
            // labelRESULTAT_KAN
            // 
            this.labelRESULTAT_KAN.AutoSize = true;
            this.labelRESULTAT_KAN.Location = new System.Drawing.Point(6, 35);
            this.labelRESULTAT_KAN.Name = "labelRESULTAT_KAN";
            this.labelRESULTAT_KAN.Size = new System.Drawing.Size(76, 17);
            this.labelRESULTAT_KAN.TabIndex = 1;
            this.labelRESULTAT_KAN.Text = "Результат";
            // 
            // buttonToDo_KAN
            // 
            this.buttonToDo_KAN.Location = new System.Drawing.Point(635, 349);
            this.buttonToDo_KAN.Name = "buttonToDo_KAN";
            this.buttonToDo_KAN.Size = new System.Drawing.Size(153, 41);
            this.buttonToDo_KAN.TabIndex = 4;
            this.buttonToDo_KAN.Text = "Выполнить";
            this.buttonToDo_KAN.UseVisualStyleBackColor = true;
            this.buttonToDo_KAN.Click += new System.EventHandler(this.buttonToDo_KAN_Click);
            // 
            // buttonVOPROS_KAN
            // 
            this.buttonVOPROS_KAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVOPROS_KAN.Location = new System.Drawing.Point(571, 349);
            this.buttonVOPROS_KAN.Name = "buttonVOPROS_KAN";
            this.buttonVOPROS_KAN.Size = new System.Drawing.Size(43, 41);
            this.buttonVOPROS_KAN.TabIndex = 5;
            this.buttonVOPROS_KAN.Text = "?";
            this.buttonVOPROS_KAN.UseVisualStyleBackColor = true;
            this.buttonVOPROS_KAN.Click += new System.EventHandler(this.buttonVOPROS_KAN_Click);
            // 
            // FormMain_KAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVOPROS_KAN);
            this.Controls.Add(this.buttonToDo_KAN);
            this.Controls.Add(this.groupBoxRESULT_KAN);
            this.Controls.Add(this.groupBoxDone_KAN);
            this.Controls.Add(this.pictureBox_KAN);
            this.Controls.Add(this.groupBoxUSLOVIE_KAN);
            this.Name = "FormMain_KAN";
            this.groupBoxUSLOVIE_KAN.ResumeLayout(false);
            this.groupBoxUSLOVIE_KAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KAN)).EndInit();
            this.groupBoxDone_KAN.ResumeLayout(false);
            this.groupBoxDone_KAN.PerformLayout();
            this.groupBoxRESULT_KAN.ResumeLayout(false);
            this.groupBoxRESULT_KAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUSLOVIE_KAN;
        private System.Windows.Forms.TextBox textBoxTask_KAN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox_KAN;
        private System.Windows.Forms.GroupBox groupBoxDone_KAN;
        private System.Windows.Forms.Label labelX_KAN;
        private System.Windows.Forms.TextBox textBoxDONE_KAN;
        private System.Windows.Forms.GroupBox groupBoxRESULT_KAN;
        private System.Windows.Forms.Label labelRESULTAT_KAN;
        private System.Windows.Forms.TextBox textBoxRESULTAT_KAN;
        private System.Windows.Forms.Button buttonToDo_KAN;
        private System.Windows.Forms.Button buttonVOPROS_KAN;
    }
}

