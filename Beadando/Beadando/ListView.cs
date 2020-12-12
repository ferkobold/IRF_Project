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
using Beadando.Entities;

namespace Beadando
{
    public partial class ListView : Form
    {
        List<Expense> Expenses = new List<Expense>();
        List<Income> Incomes = new List<Income>();
        string path = "C:\\temp\\";
        string filename = "2020";

        
        public ListView()
        {
            InitializeComponent();
            /*DirectoryInfo d = new DirectoryInfo(@"C:\temp\Incomes");
            FileInfo[] Files = d.GetFiles("*.csv");
            comboBox1.DataSource = Files;
            comboBox1.DisplayMember = "Name";*/
            Expenses = GetExpenses(@"C:\temp\Expenses.csv");
            Incomes = GetIncomes(@"C:\temp\Incomes.csv");
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

        private void ButtonYearSelect_Click(object sender, EventArgs e)
        {
            /*Ez a kód itt beállítja a fájlnevet .csv befejezéssel, hogy ki tudja olvasni a GetIncome, Expense függvény*/
            if (radioIncomes.Checked)
            {
                //path = "C:\\temp\\Incomes\\";
                DirectoryInfo d = new DirectoryInfo(@"C:\temp\Incomes");
                FileInfo[] Files = d.GetFiles("*.csv");
                comboBox1.DataSource = Files;
                comboBox1.DisplayMember = "Name";
            }

            if (radioExpenses.Checked)
            {
                //path = "C:\\temp\\Expenses\\";
                DirectoryInfo d = new DirectoryInfo(@"C:\temp\Expenses");
                FileInfo[] Files = d.GetFiles("*.csv");
                comboBox1.DataSource = Files;
                comboBox1.DisplayMember = "Name";
            }

            filename = comboBox1.Text;
        }
    }
}
