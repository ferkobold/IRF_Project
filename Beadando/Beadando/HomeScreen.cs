using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GraphView fs = new GraphView();
            fs.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListView lv = new ListView();
            lv.ShowDialog();
        }
    }
}
