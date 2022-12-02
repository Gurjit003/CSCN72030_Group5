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
    public partial class GrillPowerPopUp : Form
    {
        public GrillPowerPopUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update File with new power status
            Appliance.Grill grill = new Appliance.Grill();
            grill.setPower(true);
            grill.updateFile(grill.getGrillFile());

            this.Close();

        }

        private void GrillPowerPopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
