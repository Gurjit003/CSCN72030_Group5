﻿using System;
using System.Windows.Forms;

namespace GUI_Module
{
    public partial class inventoryControl1 : UserControl
    {
        public inventoryControl1()
        {
            InitializeComponent1();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (ReorderPopUp uu = new ReorderPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .1000d;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // inventoryControl1
            // 
            this.Name = "inventoryControl1";
            this.Load += new System.EventHandler(this.inventoryControl1_Load);
            this.ResumeLayout(false);

        }

        private void inventoryControl1_Load(object sender, EventArgs e)
        {

        }
    }
}