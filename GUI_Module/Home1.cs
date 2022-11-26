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
    public partial class homeControl1 : UserControl
    {
        public homeControl1()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // homeControl1
            // 
            this.Name = "homeControl1";
            this.Load += new System.EventHandler(this.homeControl1_Load);
            this.ResumeLayout(false);

        }

        private void homeControl1_Load(object sender, EventArgs e)
        {

        }
    }
}