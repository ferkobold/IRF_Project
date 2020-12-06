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
    public partial class Form1 : Form
    {
        List<Expense> Expenses = new List<Expense>();
        List<Income> Incomes = new List<Income>();
        //Ezekben a listákban fogjuk eltárolni a beolvasandó adatokat.
        //Az első listában a kiadásokat, a második listában a bevételeket tároljuk.
        
        public Form1()
        {
            InitializeComponent();
            Expenses = GetExpenses(@"C:\temp\Expenses.csv");
            Incomes = GetIncomes(@"C:\temp\Incomes.csv");

            /*chart1.DataSource = Incomes;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Month";
            series.YValueMembers = "Value";*/
        }

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
                while(!sr.EndOfStream)
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
    }
}
