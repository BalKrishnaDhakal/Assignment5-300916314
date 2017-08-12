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
 * Date: August4, 2017
 * Description: Assignment5 BMI calculator Form
 * Version: 0.3 Added the form closing for event handler
 */
namespace Assignment5_300916314
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
