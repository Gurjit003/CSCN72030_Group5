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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent1();
            homeControl1.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 7;

        }

        private void RMS_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KitchenControl.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 50;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inventoryControl11.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 136;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frontOfHouseControl11.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 179;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            backOfHouseGUIControl11.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 220;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            contactUsControl11.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 263;
        }

        private void kitchenControl1_Load(object sender, EventArgs e)
        {

        }

        private void homeControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dishesControl11.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 93;
        }

        private void dishesControl11_Load(object sender, EventArgs e)
        {

        }

        private void inventoryControl11_Load(object sender, EventArgs e)
        {

        }

        private void frontOfHouseControl11_Load(object sender, EventArgs e)
        {

        }

        private void backOfHouseGUIControl11_Load(object sender, EventArgs e)
        {

        }

        private void contactUsControl11_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}