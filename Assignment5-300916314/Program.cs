using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Date: August4, 2017
 * Description: Assignment5 BMI calculator Form
 * Version: 0.1 Created BMI Calculator Form Project
 */ 
namespace Assignment5_300916314
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
