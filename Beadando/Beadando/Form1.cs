using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
        }
    }
}
