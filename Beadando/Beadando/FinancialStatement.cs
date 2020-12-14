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

namespace Beadando
{
    public partial class FinancialStatement : Form
    {
        List<Expense> Expenses = new List<Expense>();
        List<Income> Incomes = new List<Income>();
        public string path = (@"C:\temp\Incomes\");
        public string filename = "2019.csv";
        SeriesChartType chartType = SeriesChartType.Line;
        Color color = Color.Red;


        public FinancialStatement()
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




        //---UTILITIES ON LEFT SIDE---//
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"c:\temp\screenshot.png");
            }
        }



        //---CUSTOMIZATION BUTTONS---//
        private void ButtonBar_Click(object sender, EventArgs e)
        {
            chartType = SeriesChartType.Bar;
            InteractiveClick();
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            chartType = SeriesChartType.Line;
            InteractiveClick();
        }

        private void ButtonPie_Click(object sender, EventArgs e)
        {
            chartType = SeriesChartType.Doughnut;
            InteractiveClick();

        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            var colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            color = colorPicker.Color;
            InteractiveClick();
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            ListView listView = new ListView();
            listView.ShowDialog();
        }



        //---INTERACTIVE GRAPH---//
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

        private void InteractiveClick()
        {
            if (radioIncomes.Checked)
            {
                Incomes = GetIncomes(path + filename);
                foreach (string itemChecked in checkedListBox1.CheckedItems)
                {
                    Incomes.RemoveAll(x => x.MonthString == itemChecked);
                }
                var incomes = from x in Incomes
                              group x by x.MonthString into asd
                              select new
                              {
                                  MonthString = asd.Key,
                                  Value = asd.Sum(
                              item => item.Value)
                              };
                chart1.DataSource = incomes.ToList();
                var series = chart1.Series[0];
                series.ChartType = chartType;
                series.XValueMember = "MonthString";
                series.YValueMembers = "Value";
                series.Color = color;
            }

            if (radioExpenses.Checked)
            {
                Expenses = GetExpenses(path + filename);
                foreach (string itemChecked in checkedListBox1.CheckedItems)
                {
                    Expenses.RemoveAll(x => x.MonthString == itemChecked);
                }
                var expenses = from x in Expenses
                               group x by x.MonthString into asd
                               select new
                               {
                                   MonthString = asd.Key,
                                   Value = asd.Sum(
                               item => item.Value)
                               };
                chart1.DataSource = expenses.ToList();
                var series = chart1.Series[0];
                series.ChartType = chartType;
                series.XValueMember = "MonthString";
                series.YValueMembers = "Value";
                series.Color = color;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InteractiveClick();
        }
    }
}
