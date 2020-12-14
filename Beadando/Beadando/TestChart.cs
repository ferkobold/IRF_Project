using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Beadando.Entities;
using System.Linq;
using System.Collections;

namespace Beadando
{
    public partial class TestChart : Form
    {
        List<Expense> Expenses = new List<Expense>();
        List<Income> Incomes = new List<Income>();
        public string path = (@"C:\temp\Incomes\");
        public string filename = "2019.csv";
        List<Month> x2 = new List<Month>();
        public TestChart()
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






        //---INTERACTIVE CHART---//
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

        private void ButtonYearSelect_Click(object sender, EventArgs e)
        {
            InteractiveClick();
        }



        //---CURRENTLY WOTRKING ON LINQ CHART VALUES---//
        /*
        Már a DataSourcet kell megváltoztatni, tehát nekem lesz egy listám, pl az Expenses lista, és akkor abból kell majd csinálni egy libQ lekérdezést 
        */
        private void InteractiveClick()
        {
            //---Linq Lekérdezés a listákhoz---//
            var incomes = from x in Incomes
                          group x by x.MonthString into asd
                          select new { MonthString = asd.Key,
                                 Value = asd.Sum(
                          item => item.Value) };

            var expenses = from x in Expenses
                           group x by x.MonthString into asd
                           select new
                           {
                               MonthString = asd.Key,
                               Value = asd.Sum(
                           item => item.Value)
                           };

            if (radioIncomes.Checked)
            {
                Incomes = GetIncomes(path + filename);
                chart1.DataSource = incomes.ToList();
                //checkedListBox1.DataSource = incomes.ToList();
                var series = chart1.Series[0];
                series.ChartType = SeriesChartType.Line;
                series.XValueMember = "MonthString";
                series.YValueMembers = "Value";
                series.Color = Color.Red;
            }

            if (radioExpenses.Checked)
            {
                Expenses = GetExpenses(path + filename);
                chart1.DataSource = expenses.ToList();
                //checkedListBox1.DataSource = expenses.ToList();
                var series = chart1.Series[0];
                series.ChartType = SeriesChartType.Line;
                series.XValueMember = "MonthString";
                series.YValueMembers = "Value";
                series.Color = Color.Red;
            }
        }

        



        //---BAL OLDALI DGW EGY HÓNAPRA MŰKÖDIK---//
        private void Button1_Click(object sender, EventArgs e)
        {
            var filteredincomes = from x in Incomes
                                  where x.MonthString == comboBox2.SelectedItem.ToString()
                                  select x;
            dataGridView1.DataSource = filteredincomes.ToList();
        }


        //---JOBB OLDALI DGW---//
        private void Button2_Click(object sender, EventArgs e)
        {
            var filteredincomes = from x in Incomes
                                  where x.MonthString == comboBox2.SelectedItem.ToString()
                                  select x;
            dataGridView2.DataSource = filteredincomes.ToList();
        }
    }
}
