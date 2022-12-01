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
    public partial class dishesControl1 : UserControl
    {
        public dishesControl1()
        {
            InitializeComponent();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {
            label4.Text = dishes.getDishesClean().ToString();
            label1.Text = dishes.getDishesDirty().ToString();
            label7.Text = dishes.getDishesBeenUsed().ToString();
        }

        public void dishesLoad()
        {
            label4.Text = dishes.getDishesClean().ToString();
            label1.Text = dishes.getDishesDirty().ToString();
            label7.Text = dishes.getDishesBeenUsed().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Dishes button
        {
            dishes.cleanDishes();
            dishesControl1 d = new dishesControl1();
            d.Show();

            label4.Text = dishes.getDishesClean().ToString();
            label1.Text = dishes.getDishesDirty().ToString();
            label7.Text = dishes.getDishesBeenUsed().ToString();

            Form formBackground = new Form();
            try
            {
                using (DishesPopUp uu = new DishesPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0d;
                    formBackground.TopMost = true;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
