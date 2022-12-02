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
    public partial class GrillLowTempPopUo : Form
    {
        public GrillLowTempPopUo()
        {
            InitializeComponent();
            Appliance.Grill grill = new Appliance.Grill();
            label2.Text = grill.getTemperature().ToString(); //display current temp
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appliance.Grill grill = new Appliance.Grill();
            //Update Temp and file
            grill.setTemp(75);
            grill.updateFile(grill.getGrillFile());
            this.Close();
        }

        private void GrillLowTempPopUo_Load(object sender, EventArgs e)
        {

        }
    }
}
