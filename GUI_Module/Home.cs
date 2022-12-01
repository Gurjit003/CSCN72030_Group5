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
        private homeControl1 homeControl11;
        private Label label13;
        private Panel panel1;
        private homeControl1 homeControl12;

        public Home()
        {
            this.InitializeComponent1();
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
            KitchenControl.updateKitchen();

        }

        private void button7_Click(object sender, EventArgs e) // Click inventory
        {
            inventoryControl11.BringToFront();
            SidePanel.Height = 33;
            SidePanel.Top = 136;
            inventoryControl11.loadComponents();
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
            dishesControl11.dishesLoad();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homeControl11 = new GUI_Module.homeControl1();
            this.homeControl12 = new GUI_Module.homeControl1();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // homeControl11
            // 
            this.homeControl11.BackColor = System.Drawing.Color.Pink;
            this.homeControl11.Location = new System.Drawing.Point(54, 51);
            this.homeControl11.Name = "homeControl11";
            this.homeControl11.Size = new System.Drawing.Size(150, 150);
            this.homeControl11.TabIndex = 0;
            // 
            // homeControl12
            // 
            this.homeControl12.BackColor = System.Drawing.Color.Pink;
            this.homeControl12.Location = new System.Drawing.Point(127, -5);
            this.homeControl12.Name = "homeControl12";
            this.homeControl12.Size = new System.Drawing.Size(502, 445);
            this.homeControl12.TabIndex = 1;
            this.homeControl12.Load += new System.EventHandler(this.homeControl12_Load);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(342, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 34);
            this.label13.TabIndex = 42;
            this.label13.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(290, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 136);
            this.panel1.TabIndex = 44;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(719, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.homeControl12);
            this.Controls.Add(this.homeControl11);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void backOfHouseGUIControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void homeControl12_Load(object sender, EventArgs e)
        {

        }
    }
}