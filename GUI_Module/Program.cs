﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Module
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            

            dishes.resetDishes();
            Home main= new Home();
            
            Application.Run(main);
        }
    }
}
