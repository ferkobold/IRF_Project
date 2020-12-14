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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioExpenses = new System.Windows.Forms.RadioButton();
            this.radioIncomes = new System.Windows.Forms.RadioButton();
            this.buttonYearSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonPie = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonBar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(158)))), ((int)(((byte)(223)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(280, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(390, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customize your graph!";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(158)))), ((int)(((byte)(223)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(175, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 105);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save the graph";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to the financial statement view!";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Január",
            "Február",
            "Március",
            "Április",
            "Május",
            "Június",
            "Július",
            "Augusztus",
            "Szeptember",
            "Október",
            "November",
            "December"});
            this.checkedListBox1.Location = new System.Drawing.Point(84, 205);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(112, 180);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select the months you would not like to see!";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // radioExpenses
            // 
            this.radioExpenses.AutoSize = true;
            this.radioExpenses.Location = new System.Drawing.Point(27, 74);
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
            this.radioIncomes.Location = new System.Drawing.Point(27, 51);
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
            this.buttonYearSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(158)))), ((int)(((byte)(223)))));
            this.buttonYearSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYearSelect.Location = new System.Drawing.Point(27, 125);
            this.buttonYearSelect.Name = "buttonYearSelect";
            this.buttonYearSelect.Size = new System.Drawing.Size(142, 35);
            this.buttonYearSelect.TabIndex = 12;
            this.buttonYearSelect.Text = "Show on the graph";
            this.buttonYearSelect.UseVisualStyleBackColor = false;
            this.buttonYearSelect.Click += new System.EventHandler(this.ButtonYearSelect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(158)))), ((int)(((byte)(223)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(84, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "TEST CHART";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonList
            // 
            this.buttonList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonList.BackgroundImage = global::Beadando.Properties.Resources.ListViewGood1;
            this.buttonList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonList.Location = new System.Drawing.Point(709, 376);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(62, 62);
            this.buttonList.TabIndex = 5;
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonColor.BackgroundImage = global::Beadando.Properties.Resources.ColorPickerGood2;
            this.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Location = new System.Drawing.Point(709, 273);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(62, 62);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonPie
            // 
            this.buttonPie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPie.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPie.BackgroundImage = global::Beadando.Properties.Resources.PieChartGood1;
            this.buttonPie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPie.Location = new System.Drawing.Point(709, 194);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(62, 62);
            this.buttonPie.TabIndex = 3;
            this.buttonPie.UseVisualStyleBackColor = false;
            this.buttonPie.Click += new System.EventHandler(this.ButtonPie_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLine.BackgroundImage = global::Beadando.Properties.Resources.LineChartGood1;
            this.buttonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Location = new System.Drawing.Point(709, 115);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(62, 62);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // buttonBar
            // 
            this.buttonBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBar.BackgroundImage = global::Beadando.Properties.Resources.BarChartGood1;
            this.buttonBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBar.Location = new System.Drawing.Point(709, 36);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(62, 62);
            this.buttonBar.TabIndex = 1;
            this.buttonBar.UseVisualStyleBackColor = false;
            this.buttonBar.Click += new System.EventHandler(this.ButtonBar_Click);
            // 
            // FinancialStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
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

