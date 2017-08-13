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
 * Description: Assignment5 BMI calculator Form
 * Version: 0.4 Revised BMICalculator Form UI
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
        /// <summary>
        /// This is an Event Handler for the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
    }
}
