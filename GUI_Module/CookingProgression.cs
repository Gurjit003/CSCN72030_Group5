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
    public partial class CookingProgression : Form
    {
       
        public CookingProgression()
        {
            InitializeComponent();
            Kitchen k = new Kitchen();
            
            string[] itemArray = k.LoadFile(k.getFullOrder());
            label8.Text = itemArray[0];
            label11.Text = itemArray[1];
            label12.Text = itemArray[2];
            label9.Text = itemArray[3];
            label13.Text = itemArray[4];
            label10.Text = itemArray[5];

            makeTicketnum(k);

            
        }
        private void makeTicketnum(Kitchen k)
        {
            string[] ticket = k.LoadTicketGenoratorFile();
            label17.Text = "0" + ticket[0];
            label18.Text = "0" + ticket[1];
        }

        private void CookingProgression_Load(object sender, EventArgs e)
        {

        }
        private void progressBar()
        {
            Button[] loadArray = { button1, button2, button3, button4, button5, button6, button7 };
            for (int i = 0; i < loadArray.Length; i++)
            {
                
                loadArray[i].BackColor = Color.Green;
                System.Threading.Thread.Sleep(200);
                this.Refresh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Green;
            progressBar();
            label14.BackColor = Color.Green;
            label15.BackColor = Color.Green;
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
