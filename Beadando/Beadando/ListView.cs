﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beadando.Entities;

namespace Beadando
{
    public partial class ListView : Form
    {
        List<Expense> Expenses = new List<Expense>();
        List<Income> Incomes = new List<Income>();
        public string path = (@"C:\temp\Incomes\");
        public string filename = "2019.csv";

        public ListView()
        {
            InitializeComponent();
            Expenses = GetExpenses(path + filename);
            Incomes = GetIncomes(path + filename);
        }


        //---CREATING INCOME/EXPENSE LISTS---//
        public List<Expense> GetExpenses(string csvpath)
        {
            List<Expense> expenses = new List<Expense>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    expenses.Add(new Expense()
                    {
                        Month = (Month)Enum.Parse(typeof(Month), line[0]),
                        Expensetype = (Expensetype)Enum.Parse(typeof(Expensetype), line[1]),
                        Value = int.Parse(line[2])
                    });
                }
            }
            return expenses;
        }

        public List<Income> GetIncomes(string csvpath)
        {
            List<Income> incomes = new List<Income>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    incomes.Add(new Income()
                    {
                        Month = (Month)Enum.Parse(typeof(Month), line[0]),
                        Incometype = (Incometype)Enum.Parse(typeof(Incometype), line[1]),
                        Value = int.Parse(line[2])
                    });
                }
            }
            return incomes;
        }



        //---SETTING THE DATASOURCE OF THE DATAGRIDVIEW---//
        private void ButtonYearSelect_Click(object sender, EventArgs e)
        {
            if (radioIncomes.Checked)
            {
                Incomes = GetIncomes(path + filename);
                dataGridView1.DataSource = Incomes;
            }

            if (radioExpenses.Checked)
            {
                Expenses = GetExpenses(path + filename);
                dataGridView1.DataSource = Expenses;
            }
        }

        private void RadioIncomes_CheckedChanged(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\temp\Incomes");
            FileInfo[] Files = d.GetFiles("*.csv");
            comboBox1.DataSource = Files;
            comboBox1.DisplayMember = "Name";
            path = (@"C:\temp\Incomes\");
        }

        private void RadioExpenses_CheckedChanged(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\temp\Expenses");
            FileInfo[] Files = d.GetFiles("*.csv");
            comboBox1.DataSource = Files;
            comboBox1.DisplayMember = "Name";
            path = (@"C:\temp\Expenses\");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filename = comboBox1.Text;
        }
    }
}
