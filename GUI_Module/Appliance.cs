using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
            this.setPower(false);
            this.setCookingSpace(4);
            this.setTemp(0);
        }

        public string grillFile = "grillFile.txt";

        new public void CookFood(int numOfBurgers)
        {
            if(this.getTemperature() < 75 )
            {
                //GUI pop or somthing to flag user to increase grill temp
                Console.WriteLine("Grill not hot enough");
            }
            if(this.getPowerStatus() == false)
            {
                //GUI call pop up
                Console.WriteLine("Grill not on");
            }
            setCookingSpace(this.getCookingSpace() - numOfBurgers);
            //update GUI visual grill area
            
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
                string[]  emptyFile = { "0", "0", "0" };

                File.WriteAllLines(grillFile, emptyFile);

                this.updateFile();
            }
        }
    }

    public class Fryer : Appliance
    {
        public string fryerFile = "fryerFile.txt";

        new public void CookFood(int numOfChicken)
        {
            if (this.getTemperature() < 75)
            {
                //GUI pop or somthing to flag user to increase grill temp
                Console.WriteLine("Fryer not hot enough");
            }
            if(this.getPowerStatus() == false)
            {
                Console.WriteLine("Fryer not on");
            }
            setCookingSpace(this.getCookingSpace() -  numOfChicken);
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
    }
}
