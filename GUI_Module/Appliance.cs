using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;

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

        public void setTemp(int temp)
        {
            this.temperature = temp;
        }
        public int getCookingSpace() { return this.cookingSpace; }
        public bool getPowerStatus() { return this.powerStatus; }
        public int getTemperature() { return this.temperature; }

        public void PowerSwitch()
        {
            this.powerStatus = !powerStatus; //Flips the power switch bool to represent power on/off

            if (this.powerStatus == false)
            {
                this.setTemp(0);
            }
        }

        //void updateApplianceFileGrill(int temperature, bool powerStatus, int cookingSpace)
        //{

        //}
        public void CookFood(int num)
        {

        }
        public void updateFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] fileLines = File.ReadAllLines(fileName); //read all lines from file into an array

                fileLines[0] = this.getPowerStatus().ToString();
                fileLines[1] = this.getTemperature().ToString(); //modify array with current values
                fileLines[2] = this.getCookingSpace().ToString();

                File.WriteAllLines(fileName, fileLines); //write current data to the file

            }
            else
            {
                //Create new file if one does not exist
                string[] emptyFile = { "0", "0", "0" };
                File.WriteAllLines(fileName, emptyFile);
                this.updateFile(fileName);
            }


        }
        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] fileLines = File.ReadAllLines(fileName); //read all files into array

                if (fileLines[0] == "False") //check power status string and update power accordingly
                {
                    this.setPower(false);
                }
                else
                {
                    this.setPower(true);
                }
                //parse temp and cooking space into ints
                this.setTemp(Int32.Parse(fileLines[1]));
                this.setCookingSpace(Int32.Parse(fileLines[2]));
            }
        }

        public class Grill : Appliance
        {
            public Grill()
            {
                this.LoadFromFile("grillFile.txt"); //Default constructor to read from file
            }

            string grillFile = "grillFile.txt";
            public string getGrillFile() { return this.grillFile; }


            new public void CookFood(int numOfBurgers)
            {

                if (this.getPowerStatus() == false)
                {
                    this.CallGrillPowerPopUp(); // if powered off call popup to turn power on
                }
                if (this.getTemperature() < 75)
                {
                    CallGrillLowTempPopUp(); //if not hot enough call pop up to increase temp
                }
                this.LoadFromFile(this.getGrillFile());
                setCookingSpace(this.getCookingSpace() - numOfBurgers); //set cooking to represent usedd spots for cooking
                updateFile(this.getGrillFile());
            }

            //Call grill low temp popup
            public void CallGrillLowTempPopUp()
            {
                Form formBackground = new Form();
                try
                {
                    using (GrillLowTempPopUo uu = new GrillLowTempPopUo())
                    {
                        uu.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Call grill power popup
            public void CallGrillPowerPopUp()
            {
                Form formBackground = new Form();
                try
                {
                    using (GrillPowerPopUp uu = new GrillPowerPopUp())
                    {
                        uu.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public class Fryer : Appliance
        {
            public Fryer()
            {
                this.LoadFromFile("fryerFile.txt"); //initialize new instance with values from the file
            }
            string fryerFile = "fryerFile.txt";
            public string getFryerFile() { return this.fryerFile; }

            new public void CookFood(int numOfChicken)
            {

                if (this.getPowerStatus() == false)
                {
                    CallFryerPowerPopUp(); //if powered off call popup to power on
                }
                if (this.getTemperature() < 75)
                {
                    CallFryerLowTempPopUp(); //if low temp call pop up to increase temp
                }
                this.LoadFromFile(this.getFryerFile());
                setCookingSpace(this.getCookingSpace() - numOfChicken);// set cooking space to represent cooking chicken
                this.updateFile(this.getFryerFile());
            }


            //Call fryer low temp popup
            public void CallFryerLowTempPopUp()
            {
                Form formBackground = new Form();
                try
                {
                    using (LowTempPopUp uu = new LowTempPopUp())
                    {
                        uu.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            //Call fryer power popup
            public void CallFryerPowerPopUp()
            {
                Form formBackground = new Form();
                try
                {
                    using (FryerPowerPopUp uu = new FryerPowerPopUp())
                    {
                        uu.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
