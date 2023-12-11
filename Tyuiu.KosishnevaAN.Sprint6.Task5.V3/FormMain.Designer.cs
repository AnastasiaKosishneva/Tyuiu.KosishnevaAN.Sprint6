
namespace Tyuiu.KosishnevaAN.Sprint6.Task5.V3
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelVERH_KAN = new System.Windows.Forms.Panel();
            this.buttonToDo_KAN = new System.Windows.Forms.Button();
            this.buttonOTKR_KAN = new System.Windows.Forms.Button();
            this.buttonSPRAVKA_KAN = new System.Windows.Forms.Button();
            this.labelUSLOVIE_KAN = new System.Windows.Forms.Label();
            this.textBoxUSLOVIE_KAN = new System.Windows.Forms.TextBox();
            this.panelLEVO_KAN = new System.Windows.Forms.Panel();
            this.groupBoxRESULT_KAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewRESULT_KAN = new System.Windows.Forms.DataGridView();
            this.ColumnNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFLAT_KAN = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelVERH_KAN.SuspendLayout();
            this.panelLEVO_KAN.SuspendLayout();
            this.groupBoxRESULT_KAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRESULT_KAN)).BeginInit();
            this.panelFLAT_KAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVERH_KAN
            // 
            this.panelVERH_KAN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelVERH_KAN.Controls.Add(this.buttonToDo_KAN);
            this.panelVERH_KAN.Controls.Add(this.buttonOTKR_KAN);
            this.panelVERH_KAN.Controls.Add(this.buttonSPRAVKA_KAN);
            this.panelVERH_KAN.Controls.Add(this.labelUSLOVIE_KAN);
            this.panelVERH_KAN.Controls.Add(this.textBoxUSLOVIE_KAN);
            this.panelVERH_KAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVERH_KAN.Location = new System.Drawing.Point(0, 0);
            this.panelVERH_KAN.Name = "panelVERH_KAN";
            this.panelVERH_KAN.Size = new System.Drawing.Size(1162, 100);
            this.panelVERH_KAN.TabIndex = 0;
            // 
            // buttonToDo_KAN
            // 
            this.buttonToDo_KAN.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonToDo_KAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToDo_KAN.Location = new System.Drawing.Point(729, 9);
            this.buttonToDo_KAN.Name = "buttonToDo_KAN";
            this.buttonToDo_KAN.Size = new System.Drawing.Size(114, 81);
            this.buttonToDo_KAN.TabIndex = 6;
            this.buttonToDo_KAN.Text = "выполнить";
            this.buttonToDo_KAN.UseVisualStyleBackColor = false;
            this.buttonToDo_KAN.Click += new System.EventHandler(this.buttonToDo_KAN_Click);
            // 
            // buttonOTKR_KAN
            // 
            this.buttonOTKR_KAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOTKR_KAN.Location = new System.Drawing.Point(849, 9);
            this.buttonOTKR_KAN.Name = "buttonOTKR_KAN";
            this.buttonOTKR_KAN.Size = new System.Drawing.Size(114, 81);
            this.buttonOTKR_KAN.TabIndex = 5;
            this.buttonOTKR_KAN.Text = "открыть файл";
            this.buttonOTKR_KAN.UseVisualStyleBackColor = false;
            this.buttonOTKR_KAN.Click += new System.EventHandler(this.buttonOTKR_KAN_Click);
            // 
            // buttonSPRAVKA_KAN
            // 
            this.buttonSPRAVKA_KAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSPRAVKA_KAN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSPRAVKA_KAN.Location = new System.Drawing.Point(1036, 9);
            this.buttonSPRAVKA_KAN.Name = "buttonSPRAVKA_KAN";
            this.buttonSPRAVKA_KAN.Size = new System.Drawing.Size(114, 81);
            this.buttonSPRAVKA_KAN.TabIndex = 4;
            this.buttonSPRAVKA_KAN.Text = "справка";
            this.buttonSPRAVKA_KAN.UseVisualStyleBackColor = false;
            this.buttonSPRAVKA_KAN.Click += new System.EventHandler(this.buttonSPRAVKA_KAN_Click);
            // 
            // labelUSLOVIE_KAN
            // 
            this.labelUSLOVIE_KAN.AutoSize = true;
            this.labelUSLOVIE_KAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUSLOVIE_KAN.Location = new System.Drawing.Point(322, 9);
            this.labelUSLOVIE_KAN.Name = "labelUSLOVIE_KAN";
            this.labelUSLOVIE_KAN.Size = new System.Drawing.Size(79, 20);
            this.labelUSLOVIE_KAN.TabIndex = 1;
            this.labelUSLOVIE_KAN.Text = "Условие";
            this.labelUSLOVIE_KAN.Click += new System.EventHandler(this.labelUSLOVIE_KAN_Click);
            // 
            // textBoxUSLOVIE_KAN
            // 
            this.textBoxUSLOVIE_KAN.Location = new System.Drawing.Point(12, 38);
            this.textBoxUSLOVIE_KAN.Multiline = true;
            this.textBoxUSLOVIE_KAN.Name = "textBoxUSLOVIE_KAN";
            this.textBoxUSLOVIE_KAN.Size = new System.Drawing.Size(711, 51);
            this.textBoxUSLOVIE_KAN.TabIndex = 0;
            this.textBoxUSLOVIE_KAN.Text = "Прчитать данные из файла InPutFileTask5.txt. \r\nВывести в dstaGrindView вещественн" +
    "ые знаяения, посторить диаграмму по эти значениям.\r\n\r\n\r\n\r\n.";
            // 
            // panelLEVO_KAN
            // 
            this.panelLEVO_KAN.Controls.Add(this.groupBoxRESULT_KAN);
            this.panelLEVO_KAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLEVO_KAN.Location = new System.Drawing.Point(0, 100);
            this.panelLEVO_KAN.Name = "panelLEVO_KAN";
            this.panelLEVO_KAN.Size = new System.Drawing.Size(200, 522);
            this.panelLEVO_KAN.TabIndex = 1;
            // 
            // groupBoxRESULT_KAN
            // 
            this.groupBoxRESULT_KAN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxRESULT_KAN.Controls.Add(this.dataGridViewRESULT_KAN);
            this.groupBoxRESULT_KAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRESULT_KAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRESULT_KAN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRESULT_KAN.Name = "groupBoxRESULT_KAN";
            this.groupBoxRESULT_KAN.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxRESULT_KAN.Size = new System.Drawing.Size(200, 522);
            this.groupBoxRESULT_KAN.TabIndex = 0;
            this.groupBoxRESULT_KAN.TabStop = false;
            this.groupBoxRESULT_KAN.Text = "Вывод данных:";
            // 
            // dataGridViewRESULT_KAN
            // 
            this.dataGridViewRESULT_KAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRESULT_KAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNUM,
            this.ColumnZN});
            this.dataGridViewRESULT_KAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRESULT_KAN.Location = new System.Drawing.Point(5, 25);
            this.dataGridViewRESULT_KAN.Name = "dataGridViewRESULT_KAN";
            this.dataGridViewRESULT_KAN.RowHeadersVisible = false;
            this.dataGridViewRESULT_KAN.RowHeadersWidth = 51;
            this.dataGridViewRESULT_KAN.RowTemplate.Height = 24;
            this.dataGridViewRESULT_KAN.Size = new System.Drawing.Size(190, 492);
            this.dataGridViewRESULT_KAN.TabIndex = 0;
            // 
            // ColumnNUM
            // 
            this.ColumnNUM.HeaderText = "№";
            this.ColumnNUM.MinimumWidth = 6;
            this.ColumnNUM.Name = "ColumnNUM";
            this.ColumnNUM.Width = 50;
            // 
            // ColumnZN
            // 
            this.ColumnZN.HeaderText = "ZN";
            this.ColumnZN.MinimumWidth = 6;
            this.ColumnZN.Name = "ColumnZN";
            this.ColumnZN.Width = 125;
            // 
            // panelFLAT_KAN
            // 
            this.panelFLAT_KAN.Controls.Add(this.chart1);
            this.panelFLAT_KAN.Controls.Add(this.splitter1);
            this.panelFLAT_KAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFLAT_KAN.Location = new System.Drawing.Point(200, 100);
            this.panelFLAT_KAN.Name = "panelFLAT_KAN";
            this.panelFLAT_KAN.Size = new System.Drawing.Size(962, 522);
            this.panelFLAT_KAN.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(959, 522);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 522);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 622);
            this.Controls.Add(this.panelFLAT_KAN);
            this.Controls.Add(this.panelLEVO_KAN);
            this.Controls.Add(this.panelVERH_KAN);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 3 | Косишнева А. Н.";
            this.panelVERH_KAN.ResumeLayout(false);
            this.panelVERH_KAN.PerformLayout();
            this.panelLEVO_KAN.ResumeLayout(false);
            this.groupBoxRESULT_KAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRESULT_KAN)).EndInit();
            this.panelFLAT_KAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVERH_KAN;
        private System.Windows.Forms.Label labelUSLOVIE_KAN;
        private System.Windows.Forms.TextBox textBoxUSLOVIE_KAN;
        private System.Windows.Forms.Panel panelLEVO_KAN;
        private System.Windows.Forms.GroupBox groupBoxRESULT_KAN;
        private System.Windows.Forms.Panel panelFLAT_KAN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonToDo_KAN;
        private System.Windows.Forms.Button buttonOTKR_KAN;
        private System.Windows.Forms.Button buttonSPRAVKA_KAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridViewRESULT_KAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZN;
    }
}

