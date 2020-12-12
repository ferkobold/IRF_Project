namespace Beadando
{
    partial class ListView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonYearSelect = new System.Windows.Forms.Button();
            this.radioIncomes = new System.Windows.Forms.RadioButton();
            this.radioExpenses = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonYearSelect
            // 
            this.buttonYearSelect.Location = new System.Drawing.Point(12, 86);
            this.buttonYearSelect.Name = "buttonYearSelect";
            this.buttonYearSelect.Size = new System.Drawing.Size(142, 35);
            this.buttonYearSelect.TabIndex = 2;
            this.buttonYearSelect.Text = "button1";
            this.buttonYearSelect.UseVisualStyleBackColor = true;
            this.buttonYearSelect.Click += new System.EventHandler(this.ButtonYearSelect_Click);
            // 
            // radioIncomes
            // 
            this.radioIncomes.AutoSize = true;
            this.radioIncomes.Location = new System.Drawing.Point(12, 12);
            this.radioIncomes.Name = "radioIncomes";
            this.radioIncomes.Size = new System.Drawing.Size(65, 17);
            this.radioIncomes.TabIndex = 5;
            this.radioIncomes.TabStop = true;
            this.radioIncomes.Text = "Incomes";
            this.radioIncomes.UseVisualStyleBackColor = true;
            this.radioIncomes.CheckedChanged += new System.EventHandler(this.RadioIncomes_CheckedChanged);
            // 
            // radioExpenses
            // 
            this.radioExpenses.AutoSize = true;
            this.radioExpenses.Location = new System.Drawing.Point(12, 35);
            this.radioExpenses.Name = "radioExpenses";
            this.radioExpenses.Size = new System.Drawing.Size(71, 17);
            this.radioExpenses.TabIndex = 6;
            this.radioExpenses.TabStop = true;
            this.radioExpenses.Text = "Expenses";
            this.radioExpenses.UseVisualStyleBackColor = true;
            this.radioExpenses.CheckedChanged += new System.EventHandler(this.RadioExpenses_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioExpenses);
            this.Controls.Add(this.radioIncomes);
            this.Controls.Add(this.buttonYearSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListView";
            this.Text = "ListView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonYearSelect;
        private System.Windows.Forms.RadioButton radioIncomes;
        private System.Windows.Forms.RadioButton radioExpenses;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}