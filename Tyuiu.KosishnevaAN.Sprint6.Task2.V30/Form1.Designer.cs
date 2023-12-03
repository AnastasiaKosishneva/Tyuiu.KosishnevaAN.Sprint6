
namespace Tyuiu.KosishnevaAN.Sprint6.Task2.V30
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUSLOVIE_KAN = new System.Windows.Forms.GroupBox();
            this.textBoxUSLOVIE_KAN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxDONE = new System.Windows.Forms.GroupBox();
            this.textBoxSTART_KAN = new System.Windows.Forms.TextBox();
            this.textBoxSTOP_KAN = new System.Windows.Forms.TextBox();
            this.labelSTART_KAN = new System.Windows.Forms.Label();
            this.labelSTOP_KAN = new System.Windows.Forms.Label();
            this.buttonSPAVKA_KAN = new System.Windows.Forms.Button();
            this.buttonToDo_KAN = new System.Windows.Forms.Button();
            this.groupBoxRESULT_KAN = new System.Windows.Forms.GroupBox();
            this.chart_KAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_KAN = new System.Windows.Forms.DataGridView();
            this.ColumnFX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUSLOVIE_KAN.SuspendLayout();
            this.groupBoxDONE.SuspendLayout();
            this.groupBoxRESULT_KAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_KAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUSLOVIE_KAN
            // 
            this.groupBoxUSLOVIE_KAN.Controls.Add(this.textBoxUSLOVIE_KAN);
            this.groupBoxUSLOVIE_KAN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUSLOVIE_KAN.Name = "groupBoxUSLOVIE_KAN";
            this.groupBoxUSLOVIE_KAN.Size = new System.Drawing.Size(565, 253);
            this.groupBoxUSLOVIE_KAN.TabIndex = 0;
            this.groupBoxUSLOVIE_KAN.TabStop = false;
            this.groupBoxUSLOVIE_KAN.Text = "УСЛОВИЕ";
            // 
            // textBoxUSLOVIE_KAN
            // 
            this.textBoxUSLOVIE_KAN.Location = new System.Drawing.Point(7, 22);
            this.textBoxUSLOVIE_KAN.Multiline = true;
            this.textBoxUSLOVIE_KAN.Name = "textBoxUSLOVIE_KAN";
            this.textBoxUSLOVIE_KAN.Size = new System.Drawing.Size(539, 205);
            this.textBoxUSLOVIE_KAN.TabIndex = 0;
            this.textBoxUSLOVIE_KAN.Text = "Протабулировать функцию sin(x) на заданном диапозоне.\r\nРезультат вывести в DataGr" +
    "idView и посторить график функции.";
            this.textBoxUSLOVIE_KAN.TextChanged += new System.EventHandler(this.textBoxUSLOVIE_KAN_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxDONE
            // 
            this.groupBoxDONE.Controls.Add(this.labelSTOP_KAN);
            this.groupBoxDONE.Controls.Add(this.labelSTART_KAN);
            this.groupBoxDONE.Controls.Add(this.textBoxSTOP_KAN);
            this.groupBoxDONE.Controls.Add(this.textBoxSTART_KAN);
            this.groupBoxDONE.Location = new System.Drawing.Point(20, 287);
            this.groupBoxDONE.Name = "groupBoxDONE";
            this.groupBoxDONE.Size = new System.Drawing.Size(244, 123);
            this.groupBoxDONE.TabIndex = 2;
            this.groupBoxDONE.TabStop = false;
            this.groupBoxDONE.Text = "ВВВОД ДАННЫХ";
            // 
            // textBoxSTART_KAN
            // 
            this.textBoxSTART_KAN.Location = new System.Drawing.Point(110, 36);
            this.textBoxSTART_KAN.Name = "textBoxSTART_KAN";
            this.textBoxSTART_KAN.Size = new System.Drawing.Size(100, 22);
            this.textBoxSTART_KAN.TabIndex = 0;
            // 
            // textBoxSTOP_KAN
            // 
            this.textBoxSTOP_KAN.Location = new System.Drawing.Point(110, 76);
            this.textBoxSTOP_KAN.Name = "textBoxSTOP_KAN";
            this.textBoxSTOP_KAN.Size = new System.Drawing.Size(100, 22);
            this.textBoxSTOP_KAN.TabIndex = 1;
            // 
            // labelSTART_KAN
            // 
            this.labelSTART_KAN.AutoSize = true;
            this.labelSTART_KAN.Location = new System.Drawing.Point(6, 36);
            this.labelSTART_KAN.Name = "labelSTART_KAN";
            this.labelSTART_KAN.Size = new System.Drawing.Size(87, 17);
            this.labelSTART_KAN.TabIndex = 2;
            this.labelSTART_KAN.Text = "Старт шага:";
            // 
            // labelSTOP_KAN
            // 
            this.labelSTOP_KAN.AutoSize = true;
            this.labelSTOP_KAN.Location = new System.Drawing.Point(6, 76);
            this.labelSTOP_KAN.Name = "labelSTOP_KAN";
            this.labelSTOP_KAN.Size = new System.Drawing.Size(89, 17);
            this.labelSTOP_KAN.TabIndex = 3;
            this.labelSTOP_KAN.Text = "Конец шага:";
            // 
            // buttonSPAVKA_KAN
            // 
            this.buttonSPAVKA_KAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSPAVKA_KAN.Location = new System.Drawing.Point(270, 314);
            this.buttonSPAVKA_KAN.Name = "buttonSPAVKA_KAN";
            this.buttonSPAVKA_KAN.Size = new System.Drawing.Size(111, 66);
            this.buttonSPAVKA_KAN.TabIndex = 3;
            this.buttonSPAVKA_KAN.Text = "Справка";
            this.buttonSPAVKA_KAN.UseVisualStyleBackColor = true;
            this.buttonSPAVKA_KAN.Click += new System.EventHandler(this.buttonSPAVKA_KAN_Click);
            // 
            // buttonToDo_KAN
            // 
            this.buttonToDo_KAN.Location = new System.Drawing.Point(412, 304);
            this.buttonToDo_KAN.Name = "buttonToDo_KAN";
            this.buttonToDo_KAN.Size = new System.Drawing.Size(166, 87);
            this.buttonToDo_KAN.TabIndex = 4;
            this.buttonToDo_KAN.Text = "Выполнить";
            this.buttonToDo_KAN.UseVisualStyleBackColor = true;
            this.buttonToDo_KAN.Click += new System.EventHandler(this.buttonToDo_KAN_Click);
            this.buttonToDo_KAN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonToDo_KAN_MouseDown);
            this.buttonToDo_KAN.MouseEnter += new System.EventHandler(this.buttonToDo_KAN_MouseEnter);
            this.buttonToDo_KAN.MouseLeave += new System.EventHandler(this.buttonToDo_KAN_MouseLeave);
            // 
            // groupBoxRESULT_KAN
            // 
            this.groupBoxRESULT_KAN.Controls.Add(this.dataGridView_KAN);
            this.groupBoxRESULT_KAN.Controls.Add(this.chart_KAN);
            this.groupBoxRESULT_KAN.Location = new System.Drawing.Point(598, 13);
            this.groupBoxRESULT_KAN.Name = "groupBoxRESULT_KAN";
            this.groupBoxRESULT_KAN.Size = new System.Drawing.Size(540, 378);
            this.groupBoxRESULT_KAN.TabIndex = 5;
            this.groupBoxRESULT_KAN.TabStop = false;
            this.groupBoxRESULT_KAN.Text = "ВВЫВОД ДАННЫХ";
            // 
            // chart_KAN
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_KAN.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_KAN.Legends.Add(legend4);
            this.chart_KAN.Location = new System.Drawing.Point(180, 32);
            this.chart_KAN.Name = "chart_KAN";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_KAN.Series.Add(series4);
            this.chart_KAN.Size = new System.Drawing.Size(286, 300);
            this.chart_KAN.TabIndex = 0;
            this.chart_KAN.Text = "chart1";
            // 
            // dataGridView_KAN
            // 
            this.dataGridView_KAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFX,
            this.ColumnX});
            this.dataGridView_KAN.Location = new System.Drawing.Point(7, 32);
            this.dataGridView_KAN.Name = "dataGridView_KAN";
            this.dataGridView_KAN.RowHeadersVisible = false;
            this.dataGridView_KAN.RowHeadersWidth = 51;
            this.dataGridView_KAN.RowTemplate.Height = 24;
            this.dataGridView_KAN.Size = new System.Drawing.Size(142, 300);
            this.dataGridView_KAN.TabIndex = 1;
            // 
            // ColumnFX
            // 
            this.ColumnFX.HeaderText = "F(X)";
            this.ColumnFX.MinimumWidth = 6;
            this.ColumnFX.Name = "ColumnFX";
            this.ColumnFX.Width = 50;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 50;
            // 
            // FormMain_KAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 430);
            this.Controls.Add(this.groupBoxRESULT_KAN);
            this.Controls.Add(this.buttonToDo_KAN);
            this.Controls.Add(this.buttonSPAVKA_KAN);
            this.Controls.Add(this.groupBoxDONE);
            this.Controls.Add(this.groupBoxUSLOVIE_KAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_KAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 2 | Вариант 30 | Косишнева А. Н.";
            this.groupBoxUSLOVIE_KAN.ResumeLayout(false);
            this.groupBoxUSLOVIE_KAN.PerformLayout();
            this.groupBoxDONE.ResumeLayout(false);
            this.groupBoxDONE.PerformLayout();
            this.groupBoxRESULT_KAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_KAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUSLOVIE_KAN;
        private System.Windows.Forms.TextBox textBoxUSLOVIE_KAN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxDONE;
        private System.Windows.Forms.Label labelSTOP_KAN;
        private System.Windows.Forms.Label labelSTART_KAN;
        private System.Windows.Forms.TextBox textBoxSTOP_KAN;
        private System.Windows.Forms.TextBox textBoxSTART_KAN;
        private System.Windows.Forms.Button buttonSPAVKA_KAN;
        private System.Windows.Forms.Button buttonToDo_KAN;
        private System.Windows.Forms.GroupBox groupBoxRESULT_KAN;
        private System.Windows.Forms.DataGridView dataGridView_KAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KAN;
    }
}

