using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace GUI_Module
{
    public class Appliance
    {
        private bool powerStatus;
        private int temperature;
        private int cookingSpace;

        public Appliance()
        {
            powerStatus = false;
            cookingSpace = 4;
            temperature = 0;
        }

        public void setCookingSpace(int space)
        {
            this.cookingSpace = space;
        }

        public void setPower(bool set)
        {
            this.powerStatus = set;
        }

        //GUI calls as tempurature is increased
        public void setTemp(int temp)
        {
            this.temperature = temp;
        }
        public int getCookingSpace() { return this.cookingSpace; }
        public bool getPowerStatus() { return this.powerStatus; }
        public int getTemperature() { return this.temperature; }

        //GUI Calls this method when a power button is pressed
        public void PowerSwitch()
        {
            this.powerStatus = !powerStatus; //Flips the power switch bool to represent power on/off

            if (this.powerStatus == false)
            {
                this.setTemp(0);
            }
        }

        void updateApplianceFileGrill(int temperature, bool powerStatus, int cookingSpace)
        {

        }
        public void CookFood(int num)
        {

        }


    }

    public class Grill : Appliance
    {
        public Grill()
        {
            this.LoadFromFile();
        }

        public string grillFile = "grillFile.txt";

        new public void CookFood(int numOfBurgers)
        {
            
            if (getPowerStatus() == false)
            {
                CallGrillPowerPopUp();
            }
            if (getTemperature() < 75)
            {
                CallGrillLowTempPopUp();
            }
            setCookingSpace(getCookingSpace() - numOfBurgers);
            updateFile();

        }
        public void updateFile()
        {
            if (File.Exists(grillFile))
            {
                string[] fileLines = File.ReadAllLines(grillFile);

                fileLines[0] = this.getPowerStatus().ToString();
                fileLines[1] = this.getTemperature().ToString();
                fileLines[2] = this.getCookingSpace().ToString();

                File.WriteAllLines(grillFile, fileLines);

            }
            else
            {
                string[] emptyFile = { "0", "0", "0" };

                File.WriteAllLines(grillFile, emptyFile);

                this.updateFile();
            }
        }
        public void LoadFromFile()
        {
            if (File.Exists(grillFile))
            {
                string[] fileLines = File.ReadAllLines(grillFile);

                if (fileLines[0] == "False")
                {
                    setPower(false);
                }
                else
                {
                    setPower(true);
                }
                setTemp(Int32.Parse(fileLines[1]));
                setCookingSpace(Int32.Parse(fileLines[2]));
            }
        }
        public void CallGrillLowTempPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (GrillLowTempPopUo uu = new GrillLowTempPopUo())
                {
                    formBackground.StartPosition = FormStartPosition.CenterParent;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0;
                    formBackground.TopMost = true;
                    //formBackground.Location = KitchenControl;
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
        public void CallGrillPowerPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (GrillPowerPopUp uu = new GrillPowerPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.CenterParent;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0;
                    formBackground.TopMost = true;
                    //formBackground.Location = KitchenControl
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    //formBackground.Dispose();
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
    }

    public class Fryer : Appliance
    {
        public Fryer()
        {
            this.LoadFromFile();
        }
        public string fryerFile = "fryerFile.txt";

        new public void CookFood(int numOfChicken)
        {
            
            if (this.getPowerStatus() == false)
            {
                CallFryerPowerPopUp();
            }
            if (this.getTemperature() < 75)
            {
                CallFryerLowTempPopUp();
            }
            this.setCookingSpace(this.getCookingSpace() - numOfChicken);
            this.updateFile();
            //update GUI visual grill area
        }

        public void updateFile()
        {
            if (File.Exists(fryerFile))
            {
                string[] fileLines = File.ReadAllLines(fryerFile);

                fileLines[0] = this.getPowerStatus().ToString();
                fileLines[1] = this.getTemperature().ToString();
                fileLines[2] = this.getCookingSpace().ToString();

                File.WriteAllLines(fryerFile, fileLines);
            }
            else
            {
                string[] emptyFile = { "0", "0", "0" };

                File.WriteAllLines(fryerFile, emptyFile);

                this.updateFile();
            }
        }
        public void LoadFromFile()
        {
            if (File.Exists(fryerFile))
            {
                string[] fileLines = File.ReadAllLines(fryerFile);

                if (fileLines[0] == "False")
                {
                    this.setPower(false);
                }
                else
                {
                    this.setPower(true);
                }
                this.setTemp(Int32.Parse(fileLines[1]));
                this.setCookingSpace(Int32.Parse(fileLines[2]));
            }
        }
        public void CallFryerLowTempPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (LowTempPopUp uu = new LowTempPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.CenterParent;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0;
                    formBackground.TopMost = true;
                    //formBackground.Location = KitchenControl
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
        public void CallFryerPowerPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (FryerPowerPopUp uu = new FryerPowerPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.CenterParent;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0;
                    formBackground.TopMost = true;
                    //formBackground.Location = KitchenControl
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
    } 
}
