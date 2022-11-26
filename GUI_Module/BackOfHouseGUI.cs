using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Module
{
    public partial class backOfHouseGUIControl1 : UserControl
    {
        public backOfHouseGUIControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backOfHouseGUIControl1_Load(object sender, EventArgs e)
        {
            double totalGrossRevenue = BackOfHouse.getGrossRevenue();
            double totalExpenses = BackOfHouse.getExpenses();

            label7.Text = totalGrossRevenue.ToString();

            label4.Text = totalExpenses.ToString();
 
            label5.Text = BackOfHouse.getNetRevenue(totalGrossRevenue, totalExpenses).ToString(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
