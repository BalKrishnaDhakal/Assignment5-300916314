using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Date: August12, 2017
 * Description: This is the FlashForm Class
 * Version: 0.2 Created the SplashFormTimer_Tick Event Handler Method
 */ 
namespace Assignment5_300916314
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMICalculatorForm bmiCalculatorForm = new BMICalculatorForm();
            bmiCalculatorForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = false; // This turn timer off
        }
    }
}
