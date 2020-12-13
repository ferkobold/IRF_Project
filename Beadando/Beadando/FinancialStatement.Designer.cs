namespace Beadando
{
    partial class FinancialStatement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonPie = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonBar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioExpenses = new System.Windows.Forms.RadioButton();
            this.radioIncomes = new System.Windows.Forms.RadioButton();
            this.buttonYearSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(280, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(390, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customize your chart!";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(125, 397);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(149, 41);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save the graph";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to the financial statement view!";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 224);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(112, 214);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Which months would you like to see?";
            // 
            // buttonList
            // 
            this.buttonList.BackgroundImage = global::Beadando.Properties.Resources.ListViewGood;
            this.buttonList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonList.Location = new System.Drawing.Point(709, 376);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(62, 62);
            this.buttonList.TabIndex = 5;
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackgroundImage = global::Beadando.Properties.Resources.ColorPickerGood;
            this.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonColor.Location = new System.Drawing.Point(709, 273);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(62, 62);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonPie
            // 
            this.buttonPie.BackgroundImage = global::Beadando.Properties.Resources.PieChartGood;
            this.buttonPie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPie.Location = new System.Drawing.Point(709, 194);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(62, 62);
            this.buttonPie.TabIndex = 3;
            this.buttonPie.UseVisualStyleBackColor = true;
            this.buttonPie.Click += new System.EventHandler(this.ButtonPie_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackgroundImage = global::Beadando.Properties.Resources.LineChartGood;
            this.buttonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLine.Location = new System.Drawing.Point(709, 115);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(62, 62);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // buttonBar
            // 
            this.buttonBar.BackgroundImage = global::Beadando.Properties.Resources.BarChartGood;
            this.buttonBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBar.Location = new System.Drawing.Point(709, 36);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(62, 62);
            this.buttonBar.TabIndex = 1;
            this.buttonBar.UseVisualStyleBackColor = true;
            this.buttonBar.Click += new System.EventHandler(this.ButtonBar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // radioExpenses
            // 
            this.radioExpenses.AutoSize = true;
            this.radioExpenses.Location = new System.Drawing.Point(16, 55);
            this.radioExpenses.Name = "radioExpenses";
            this.radioExpenses.Size = new System.Drawing.Size(71, 17);
            this.radioExpenses.TabIndex = 14;
            this.radioExpenses.TabStop = true;
            this.radioExpenses.Text = "Expenses";
            this.radioExpenses.UseVisualStyleBackColor = true;
            this.radioExpenses.CheckedChanged += new System.EventHandler(this.RadioExpenses_CheckedChanged);
            // 
            // radioIncomes
            // 
            this.radioIncomes.AutoSize = true;
            this.radioIncomes.Location = new System.Drawing.Point(16, 32);
            this.radioIncomes.Name = "radioIncomes";
            this.radioIncomes.Size = new System.Drawing.Size(65, 17);
            this.radioIncomes.TabIndex = 13;
            this.radioIncomes.TabStop = true;
            this.radioIncomes.Text = "Incomes";
            this.radioIncomes.UseVisualStyleBackColor = true;
            this.radioIncomes.CheckedChanged += new System.EventHandler(this.RadioIncomes_CheckedChanged);
            // 
            // buttonYearSelect
            // 
            this.buttonYearSelect.Location = new System.Drawing.Point(16, 106);
            this.buttonYearSelect.Name = "buttonYearSelect";
            this.buttonYearSelect.Size = new System.Drawing.Size(142, 35);
            this.buttonYearSelect.TabIndex = 12;
            this.buttonYearSelect.Text = "button1";
            this.buttonYearSelect.UseVisualStyleBackColor = true;
            this.buttonYearSelect.Click += new System.EventHandler(this.ButtonYearSelect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 71);
            this.button1.TabIndex = 16;
            this.button1.Text = "TEST CHART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FinancialStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioExpenses);
            this.Controls.Add(this.radioIncomes);
            this.Controls.Add(this.buttonYearSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonPie);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonBar);
            this.Controls.Add(this.chart1);
            this.Name = "FinancialStatement";
            this.Text = "Financial Statement";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonBar;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonPie;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioExpenses;
        private System.Windows.Forms.RadioButton radioIncomes;
        private System.Windows.Forms.Button buttonYearSelect;
        private System.Windows.Forms.Button button1;
    }
}

