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

            chart1.DataSource = Incomes;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "MonthString";
            series.YValueMembers = "Value";
            /*Itt majd kell egy linQ lekérdezés, amiben összeadom
            a hónap összes kiadását, bevételét, és annak az értékét 
            jelenítem meg a grafikonon.*/
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
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Bar;
            series.XValueMember = "MonthString";
            series.YValueMembers = "Value";
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "MonthString";
            series.YValueMembers = "Value";
        }

        private void ButtonPie_Click(object sender, EventArgs e)
        {
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Doughnut;
            series.XValueMember = "MonthString";
            series.YValueMembers = "Value";
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            //kell csinálni egy változót, ami eltárolja a színt és a többinek
            //meg kell adni ezt a változót a szín propertynek
        }
    }
}
