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
            string totalExpenseTemp = BackOfHouse.getExpenses().ToString();
            label4.Text = totalExpenseTemp;

            string totalIncomeTemp = BackOfHouse.getGrossRevenue().ToString(); 
            label7.Text = totalIncomeTemp;
            
            string totalNetRevenue = BackOfHouse.getNetRevenue(BackOfHouse.getGrossRevenue(), BackOfHouse.getExpenses()).ToString();
            label5.Text = totalNetRevenue; 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
