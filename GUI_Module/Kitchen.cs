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
    public partial class KitchenControl : UserControl
    {
        public KitchenControl()
        {
            InitializeComponent();
            Grill grill = new Grill();
            Fryer fryer = new Fryer();

            numericUpDown1.Value = fryer.getTemperature();
            numericUpDown2.Value = grill.getTemperature();

            

            if(fryer.getPowerStatus() == true)
            {
                button1.BackColor = Color.Green;
            }
            if (grill.getPowerStatus() == true)
            {
                button2.BackColor = Color.Green;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KitchenControl_Load(object sender, EventArgs e)
        {
            label7.Text = Order.sendHam().ToString();
            label8.Text = Order.sendChic().ToString();
            label9.Text = Order.sendFri().ToString();
            label10.Text = Order.sendSal().ToString();
            label11.Text = Order.sendWat().ToString();
            label12.Text = Order.sendPop().ToString(); 
        }

        public void updateKitchen()
        {
            label7.Text = Order.sendHam().ToString();
            label8.Text = Order.sendChic().ToString();
            label9.Text = Order.sendFri().ToString();
            label10.Text = Order.sendSal().ToString();
            label11.Text = Order.sendWat().ToString();
            label12.Text = Order.sendPop().ToString();

            Grill grill = new Grill();
            Fryer fryer = new Fryer();

            if (fryer.getPowerStatus() == true)
            {
                button1.BackColor = Color.Green;
            }
            if (grill.getPowerStatus() == true)
            {
                button2.BackColor = Color.Green;
            }
            numericUpDown1.Value = fryer.getTemperature();
            numericUpDown2.Value = grill.getTemperature();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Fryer fryer = new Fryer();
            if(fryer.getPowerStatus() == true)
            {
                fryer.setTemp(((int)numericUpDown1.Value));
                fryer.updateFile();
            }
            else
            {
                numericUpDown1.Value = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fryer fryer = new Fryer();
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Green":
                    fryer.setPower(false);
                    ctrl.BackColor = Color.Red;
                    numericUpDown1.Value = 0;
                    fryer.setTemp((int)numericUpDown1.Value);
                    break;
                default:
                    fryer.setPower(true);
                    ctrl.BackColor = Color.Green;
                    break;
            }
            fryer.updateFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grill grill = new Grill();
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Green":
                    grill.setPower(false);
                    ctrl.BackColor = Color.Red;
                    numericUpDown2.Value = 0;
                    grill.setTemp((int)numericUpDown2.Value);
                    break;
                default:
                    grill.setPower(true);
                    ctrl.BackColor = Color.Green;
                    break;
            }
            grill.updateFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Grill grill = new Grill();
            if(grill.getPowerStatus() == true)
            {
                grill.setTemp(((int)numericUpDown2.Value));
                grill.updateFile();
            }
            else
            {
                numericUpDown2.Value = 0;
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
