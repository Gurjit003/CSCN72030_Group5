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
            int tableCounter = 0;
            for (int x = 0; x < frontOfHouse.numberOfTables; x++) // For all tables
            {
                if (frontOfHouse.arrayOfTables[x].getOccupants() != 0) // If the table is not empty
                {
                    tableCounter++;
                }
            }

            if (tableCounter < frontOfHouse.numberOfTables) // If all tables are not occupied
            {
                //for (int x = 0; x < (frontOfHouse.generateNumberOfCustomers() * 2); x++) // Set random number of tables
                // {
                frontOfHouse.setTable();
                updateTableStatus();
                // }
            }
            else
            {
                // All dishes occupied popup
                allTablesOccupiedPopUp();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[0].clearTable();
            updateTableStatus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[1].clearTable();
            updateTableStatus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[2].clearTable();
            updateTableStatus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[3].clearTable();
            updateTableStatus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[4].clearTable();
            updateTableStatus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[5].clearTable();
            updateTableStatus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[6].clearTable();
            updateTableStatus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[7].clearTable();
            updateTableStatus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[0].clearTable();
            updateTableStatus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[1].clearTable();
            updateTableStatus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[2].clearTable();
            updateTableStatus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[3].clearTable();
            updateTableStatus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[4].clearTable();
            updateTableStatus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[5].clearTable();
            updateTableStatus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[6].clearTable();
            updateTableStatus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frontOfHouse.arrayOfTables[7].clearTable();
            updateTableStatus();
        }
    }
}
