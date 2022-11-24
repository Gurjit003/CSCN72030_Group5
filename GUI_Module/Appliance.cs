using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUI_Module
{
    public class Appliance
    {
        private bool powerStatus;
        private int temperature;
        private int cookingSpace;
        private int usedCookingSpace;

        public Appliance()
        {
            powerStatus = false;
            cookingSpace = 4;
            temperature = 0;
            usedCookingSpace = 0;
        }

        public void setCookingSpace(int space)
        {
            this.cookingSpace = space;
        }
        public void setUsedCookingSpace(int used)
        {
            this.usedCookingSpace = used;
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
        public int getUsedCookingSpace() { return this.usedCookingSpace; }
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
        public string grillFile = "grillFile.txt";

        new public void CookFood(int numOfBurgers)
        {
            if(this.getTemperature() < 75)
            {
                //GUI pop or somthing to flag user to increase grill temp
                Console.WriteLine("Grill not hot enough");
            }
            setUsedCookingSpace(numOfBurgers);
            //update GUI visual grill area
            
        }
        public void updateFile()
        {
            if (File.Exists(grillFile))
            {
                
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
            setUsedCookingSpace(numOfChicken);
            //update GUI visual grill area
        }

        public void updateFile()
        {
            
        }
    }
}
