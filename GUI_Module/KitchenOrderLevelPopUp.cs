using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Module
{
    public partial class KitchenOrderLevelPopUp : Form
    {
        public KitchenOrderLevelPopUp()
        {
            InitializeComponent();
            Kitchen kitchen = new Kitchen();

            string[] itemsOrdered = kitchen.LoadFile(kitchen.getKitchenOrderFIle());
            //array {Hamburger, Chicken, Salad, Fries, Pop, Water}
            label9.Text = itemsOrdered[0]; // Burger    
            label12.Text = itemsOrdered[1]; //Chicken
            label11.Text = itemsOrdered[3]; //Fires
            label13.Text = itemsOrdered[5]; //Water
            label14.Text = itemsOrdered[2]; //Salad
            label10.Text = itemsOrdered[4]; //Pop
        }

        private void KitchenOrderLevelPopUp_Load(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
