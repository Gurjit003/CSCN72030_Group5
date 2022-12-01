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
            frontOfHouse.createArrayOfEmptyTables();
            updateTableStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTables();
            updateTableStatus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //for (int x = 0; x < (frontOfHouse.generateNumberOfCustomers() * 2); x++) // Set random number of tables
            // {
            frontOfHouse.setTable();
            updateTableStatus();
            // }
        }
    }
}
