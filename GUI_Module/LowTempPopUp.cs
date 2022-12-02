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
    public partial class LowTempPopUp : Form
    {
        public LowTempPopUp()
        {
            InitializeComponent();
            Appliance.Fryer fryer = new Appliance.Fryer();

            label2.Text = fryer.getTemperature().ToString(); //set label to equal current temp

        }

        private void LowTempPopUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appliance.Fryer fryer = new Appliance.Fryer();
            //set proper temp and update file
            fryer.setTemp(75);
            fryer.updateFile(fryer.getFryerFile());

            this.Close();
        }
    }
}
