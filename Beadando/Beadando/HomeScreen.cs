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



        //---NAVIGATION---//
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GraphView gv = new GraphView();
            gv.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListView lv = new ListView();
            lv.ShowDialog();
        }
    }
}
