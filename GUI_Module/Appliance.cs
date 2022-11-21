using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    public class Appliance
    {
        bool powerStatus;
        int temperature;
        int cookingSpace;
        int usedCookingSpace;

        public Appliance()
        {
            powerStatus = false;
            cookingSpace = 4;
            temperature = 0;
            usedCookingSpace = 0;
        }

        

        //GUI Calls this method when a power button is pressed
        public void PowerSwitch()
        {
            this.powerStatus = !powerStatus; //Flips the power switch bool to represent power on/off

            if (this.powerStatus == false)
            {
                this.temperature = 0;

            }
        }
        

    }

    public class Grill : Appliance
    {
       
    }

    public class Fryer : Appliance
    {

    }
}
