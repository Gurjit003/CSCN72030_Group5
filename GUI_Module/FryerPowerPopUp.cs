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
    public partial class FryerPowerPopUp : Form
    {
        public FryerPowerPopUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appliance.Fryer fryer = new Appliance.Fryer();
            //update power and file
            fryer.setPower(true);
            fryer.updateFile(fryer.getFryerFile());

            this.Close();
        }
    }
}
