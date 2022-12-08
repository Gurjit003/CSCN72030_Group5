using System;
using System.Windows.Forms;
using System.Threading;

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

        // Clicking table icon or number to clear it
        private void pictureBox1_Click(object sender, EventArgs e) // Table 1
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[0]);
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Table 2
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[1]);
        }

        private void pictureBox5_Click(object sender, EventArgs e) // Table 3
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[2]);
        }

        private void pictureBox7_Click(object sender, EventArgs e) // Table 4
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[3]);
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Table 5
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[4]);
        }

        private void pictureBox4_Click(object sender, EventArgs e) // Table 6
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[5]);
        }

        private void pictureBox6_Click(object sender, EventArgs e) // Table 7
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[6]);
        }

        private void pictureBox8_Click(object sender, EventArgs e) // Table 8
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[7]);
        }

        private void label1_Click(object sender, EventArgs e) // Table 1
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[0]);
        }

        private void label3_Click(object sender, EventArgs e) // Table 2
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[1]);
        }

        private void label5_Click(object sender, EventArgs e) // Table 3
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[2]);
        }

        private void label7_Click(object sender, EventArgs e) // Table 4
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[3]);
        }

        private void label2_Click(object sender, EventArgs e) // Table 5
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[4]);
        }

        private void label4_Click(object sender, EventArgs e) // Table 6
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[5]);
        }

        private void label6_Click(object sender, EventArgs e) // Table 7
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[6]);
        }

        private void label8_Click(object sender, EventArgs e) // Table 8
        {
            seatSendOrClear(frontOfHouse.arrayOfTables[7]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            helpPopUpFOH();
        }
    }
}
