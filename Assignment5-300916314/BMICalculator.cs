﻿using System;
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
 * Date: August13, 2017
 * Description: Assignment5 BMI calculator Form
 * Version: 0.8  Event Handler method for the CalculateBMIButton is Created
 */
namespace Assignment5_300916314
{
    public partial class BMICalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _isMetricButtonClicked;
        private bool _isImperialButtonClicked;
        private double _weightInKilograms;
        private double _weightInPounds;
        private double _heightInInches;
        private double _heightInMeters;
        private double _bMIResult;


        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public bool IsMetricButtonClicked
        {
            get
            {
                return this._isMetricButtonClicked;
            }
            set
            {
                this._isMetricButtonClicked = value;
            }
        }
        public bool IsImperialButtonClicked
        {
            get
            {
                return this._isImperialButtonClicked;
            }
            set
            {
                this._isImperialButtonClicked = value;
            }
        }
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
                this._weightInPounds= value;
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
                WeightInKilograms = Convert.ToDouble(WeightTextBox.Text);
                HeightInMeters = Convert.ToDouble(HeightTextBox.Text);
                BMIResult = (WeightInKilograms) / (HeightInMeters * HeightInMeters);
               
            }
            if (ImperialUnitsButton.Checked)
            {

                HeightInInches = Convert.ToDouble(HeightTextBox.Text);
                WeightInPounds = Convert.ToDouble(WeightTextBox.Text);
                BMIResult = (WeightInPounds * 703) / (HeightInInches * HeightInInches);

            }

        }
        /// <summary>
        /// This is an Event Handler for the CalculateBMIButton which onclick displays the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            {
                CalculateBMI();

                if (BMIResult < 18.5)
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + BMIResult + " It shows that you are under weight";

                }
                if ((BMIResult >= 18.5) && (BMIResult <= 24.9))
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + BMIResult + " It shows that your weight is  normal";

                }
                if ((BMIResult >= 25) && (BMIResult <= 29.9))
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + BMIResult + " It shows that you are overweight";

                }
                if (BMIResult >= 30)
                {
                    ResultDisplayAreaTextBox.Text = "Your BMI is: " + BMIResult + " It shows that you are obese";

                }

            }
        }
    }
}
