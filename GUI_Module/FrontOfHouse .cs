using System;
using System.Windows.Forms;

namespace GUI_Module
{
    public partial class frontOfHouseControl1 : UserControl
    {
        public frontOfHouseControl1()
        {
            InitializeComponent();
        }

        private void frontOfHouseControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frontOfHouse.createArrayOfEmptyTables();

            for (int x = 0; x < (frontOfHouse.generateNumberOfCustomers() * 2); x++) // Set random number of tables
            {
                frontOfHouse.setTable();
                updateTableStatus();
            }
            
            //clearTables();
            updateTableStatus();
        }
    }
}
