using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
/* Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Date: August13, 2017
 * Description: Assignment5 BMI calculator Form
 * Version: 0.14  Refactored CalculateButtonClick method
 */
namespace Assignment5_300916314
{
    public partial class BMICalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private double _weightInKilograms;
        private double _weightInPounds;
        private double _heightInInches;
        private double _heightInMeters;
        private double _bMIResult;
        private bool _calcFlag = false;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        public double WeightInKilograms
        {
            get
            {
                return this._weightInKilograms;
            }
            set
            {
                this._weightInKilograms = value;

            }
        }
        public double WeightInPounds
        {
            get
            {
                return this._weightInPounds;
            }
            set
            {
                this._weightInPounds = value;
            }
        }
        public double HeightInInches
        {
            get
            {
                return this._heightInInches;
            }
            set
            {
                this._heightInInches = value;
            }
        }
        public double HeightInMeters
        {
            get
            {
                return this._heightInMeters;
            }
            set
            {
                this._heightInMeters = value;
            }
        }
        public double BMIResult
        {
            get
            {
                return this._bMIResult;
            }
            set
            {
                this._bMIResult = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// This is the main constructor of BMICalculatorForm Class
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is an Event Handler for the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is an Event Handler for the MetricUnitsButton Checked ++++++++++++++++++++++++++++++++++++++++++
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricUnitsButton_CheckedChanged(object sender, EventArgs e)
        {
            KgsLabel.Text = "Kgs";
            MetersLabel.Text = "Meters";
        }
        /// <summary>
        /// This is an Event Handler for the ImperialUnitsButton Checked +++++++++++++++++++++++++++++++++++++++++++++++
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialUnitsButton_CheckedChanged(object sender, EventArgs e)
        {
            KgsLabel.Text = "Pounds";
            MetersLabel.Text = "Inches";
        }
        /// <summary>
        /// This is the main method to calculate the BMI in this project ++++++++++++++++++++++++++++++++++++++++++++++++
        /// </summary>
        private void CalculateBMI()
        {
            if (MetricUnitsButton.Checked)
            {
                if (!"".Equals(WeightTextBox.Text))
                {
                    WeightInKilograms = Convert.ToDouble(WeightTextBox.Text);
                }
                if (!"".Equals(HeightTextBox.Text))
                {
                    HeightInMeters = Convert.ToDouble(HeightTextBox.Text);
                }
                if (!"".Equals(WeightTextBox.Text) && !"".Equals(HeightTextBox.Text))
                {
                    BMIResult = (WeightInKilograms) / (HeightInMeters * HeightInMeters);
                    Math.Round(BMIResult, 2);
                    _calcFlag = true;
                }

            }
            if (ImperialUnitsButton.Checked)
            {
                if (!"".Equals(HeightTextBox.Text))
                {
                    HeightInInches = Convert.ToDouble(HeightTextBox.Text);
                }
                if (!"".Equals(HeightTextBox.Text))
                {
                    WeightInPounds = Convert.ToDouble(WeightTextBox.Text);
                }
                if (!"".Equals(WeightTextBox.Text) && !"".Equals(HeightTextBox.Text))
                {
                    BMIResult = (WeightInPounds * 703) / (HeightInInches * HeightInInches);
                    Math.Round(BMIResult, 2);
                    _calcFlag = true;
                }

            }

        }
        /// <summary>
        /// This is an Event Handler for the CalculateBMIButton which onclick displays the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

            CalculateBMI();

            if (_calcFlag)
            {
                _calcFlag = false;
                if (!"".Equals(BMIResult < 18.5))
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + Math.Round(BMIResult, 2) + "\r\n It shows that you are under weight";

                }
                if ((BMIResult >= 18.5) && (BMIResult <= 24.9))
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + Math.Round(BMIResult, 2) + "\r\n It shows that your weight is  normal";

                }
                if ((BMIResult >= 25) && (BMIResult <= 29.9))
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + Math.Round(BMIResult, 2) + "\r\n It shows that you are overweight";

                }
                if (BMIResult >= 30)
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + Math.Round(BMIResult, 2) + "\r\n It shows that you are obese";

                }
            }

        }


        /// <summary>
        /// This method converts from the string  result textBox to a number
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private double _convertOperand(string inputString)
        {
            try
            {
                return Convert.ToDouble(inputString);
            }
            catch (Exception exception)
            {
                Debug.WriteLine("An Error Occured");
                Debug.WriteLine(exception.Message);
            }
            return 0;
        }
        /// <summary>
        /// This methods clear all inputs and results from the form
        /// </summary>
        private void _clear()
        {
            ResultDisplayAreaTextBox.Text = "";
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            ImperialUnitsButton.Checked = false;
            MetricUnitsButton.Checked = false;
            KgsLabel.Text = "";
            MetersLabel.Text = "";

        }
        /// <summary>
        ///  This is an Event Handler Method for the ResetButton which resets the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            _clear();
        }
        /// <summary>
        /// This is the Key press Method 
        /// It is use to control users input
        /// It accepts only numeric value
        /// This idea and parts of code is taken from The link below
        /// https://stackoverflow.com/questions/13253198/validating-a-textbox-to-allow-only-numeric-values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
    }


}
