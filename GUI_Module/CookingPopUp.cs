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
    public partial class CookingPopUp : Form
    {
        public CookingPopUp()
        {
            InitializeComponent();
            
            Fryer fryer = new Fryer();
            Grill grill = new Grill();
            

            label9.Text = (4 - grill.getCookingSpace()).ToString();
            label12.Text = (4 - fryer.getCookingSpace()).ToString();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CookingPopUp_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Green;

            ProgressBar();
            this.Close();
            
        }
        private void ProgressBar()
        {
            
            int orderProgession = 7;
            Button[] progressArray = { button1, button2, button3, button4, button5, button6, button7 };
            for (int i = 0; i < orderProgession; i++)
            {
                this.Refresh();
                progressArray[i].BackColor = Color.Green;
                backgroundWorker1.ReportProgress(i);
                System.Threading.Thread.Sleep(750);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
