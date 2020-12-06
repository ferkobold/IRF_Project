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
    public partial class Form1 : Form
    {
        List<Expense> Expenses = new List<Expense>();
        List<Income> Incomes = new List<Income>();
        //Ezekben a listákban fogjuk eltárolni a beolvasandó adatokat.
        //Az első listában a kiadásokat, a második listában a bevételeket tároljuk.
        public Form1()
        {
            InitializeComponent();
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
    }
}
