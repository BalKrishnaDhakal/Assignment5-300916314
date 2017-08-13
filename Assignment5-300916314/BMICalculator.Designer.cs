namespace Assignment5_300916314
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeadingTextBox = new System.Windows.Forms.TextBox();
            this.ResultDisplayAreaTextBox = new System.Windows.Forms.TextBox();
            this.ImperialUnitsButton = new System.Windows.Forms.RadioButton();
            this.KgsLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MetricUnitsButton = new System.Windows.Forms.RadioButton();
            this.CalculatorHeadingBox = new System.Windows.Forms.TableLayoutPanel();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MetersLabel = new System.Windows.Forms.Label();
            this.CalculatorHeadingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.SkyBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(-7, 404);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(159, 38);
            this.CalculateBMIButton.TabIndex = 10;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(152, 404);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(158, 38);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeadingTextBox
            // 
            this.HeadingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HeadingTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.HeadingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HeadingTextBox.Location = new System.Drawing.Point(-4, 12);
            this.HeadingTextBox.Multiline = true;
            this.HeadingTextBox.Name = "HeadingTextBox";
            this.HeadingTextBox.Size = new System.Drawing.Size(315, 50);
            this.HeadingTextBox.TabIndex = 0;
            this.HeadingTextBox.Text = "Body Mass Index (BMI) Calculator";
            this.HeadingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultDisplayAreaTextBox
            // 
            this.ResultDisplayAreaTextBox.BackColor = System.Drawing.Color.White;
            this.ResultDisplayAreaTextBox.Enabled = false;
            this.ResultDisplayAreaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultDisplayAreaTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.ResultDisplayAreaTextBox.Location = new System.Drawing.Point(2, 268);
            this.ResultDisplayAreaTextBox.Multiline = true;
            this.ResultDisplayAreaTextBox.Name = "ResultDisplayAreaTextBox";
            this.ResultDisplayAreaTextBox.ReadOnly = true;
            this.ResultDisplayAreaTextBox.Size = new System.Drawing.Size(301, 138);
            this.ResultDisplayAreaTextBox.TabIndex = 9;
            // 
            // ImperialUnitsButton
            // 
            this.ImperialUnitsButton.AutoSize = true;
            this.ImperialUnitsButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.CalculatorHeadingBox.SetColumnSpan(this.ImperialUnitsButton, 2);
            this.ImperialUnitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialUnitsButton.Location = new System.Drawing.Point(159, 3);
            this.ImperialUnitsButton.Name = "ImperialUnitsButton";
            this.ImperialUnitsButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ImperialUnitsButton.Size = new System.Drawing.Size(140, 33);
            this.ImperialUnitsButton.TabIndex = 2;
            this.ImperialUnitsButton.Text = "Imperial Units";
            this.ImperialUnitsButton.UseVisualStyleBackColor = false;
            this.ImperialUnitsButton.CheckedChanged += new System.EventHandler(this.ImperialUnitsButton_CheckedChanged);
            // 
            // KgsLabel
            // 
            this.KgsLabel.AutoSize = true;
            this.KgsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgsLabel.Location = new System.Drawing.Point(234, 70);
            this.KgsLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.KgsLabel.Name = "KgsLabel";
            this.KgsLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.KgsLabel.Size = new System.Drawing.Size(0, 25);
            this.KgsLabel.TabIndex = 5;
            this.KgsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.CalculatorHeadingBox.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(10, 135);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.HeightLabel.Size = new System.Drawing.Size(105, 29);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.CalculatorHeadingBox.SetColumnSpan(this.MyWeightLabel, 2);
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(10, 70);
            this.MyWeightLabel.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.MyWeightLabel.Size = new System.Drawing.Size(109, 29);
            this.MyWeightLabel.TabIndex = 3;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MetricUnitsButton
            // 
            this.MetricUnitsButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.CalculatorHeadingBox.SetColumnSpan(this.MetricUnitsButton, 2);
            this.MetricUnitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricUnitsButton.Location = new System.Drawing.Point(3, 3);
            this.MetricUnitsButton.Name = "MetricUnitsButton";
            this.MetricUnitsButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.MetricUnitsButton.Size = new System.Drawing.Size(150, 35);
            this.MetricUnitsButton.TabIndex = 1;
            this.MetricUnitsButton.Text = "Metric Units";
            this.MetricUnitsButton.UseVisualStyleBackColor = false;
            this.MetricUnitsButton.CheckedChanged += new System.EventHandler(this.MetricUnitsButton_CheckedChanged);
            // 
            // CalculatorHeadingBox
            // 
            this.CalculatorHeadingBox.BackColor = System.Drawing.Color.Gainsboro;
            this.CalculatorHeadingBox.ColumnCount = 4;
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.Controls.Add(this.MetricUnitsButton, 0, 0);
            this.CalculatorHeadingBox.Controls.Add(this.MyWeightLabel, 0, 1);
            this.CalculatorHeadingBox.Controls.Add(this.HeightLabel, 0, 2);
            this.CalculatorHeadingBox.Controls.Add(this.ImperialUnitsButton, 2, 0);
            this.CalculatorHeadingBox.Controls.Add(this.KgsLabel, 3, 1);
            this.CalculatorHeadingBox.Controls.Add(this.WeightTextBox, 2, 1);
            this.CalculatorHeadingBox.Controls.Add(this.HeightTextBox, 2, 2);
            this.CalculatorHeadingBox.Controls.Add(this.MetersLabel, 3, 2);
            this.CalculatorHeadingBox.Location = new System.Drawing.Point(-7, 65);
            this.CalculatorHeadingBox.Name = "CalculatorHeadingBox";
            this.CalculatorHeadingBox.RowCount = 3;
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorHeadingBox.Size = new System.Drawing.Size(313, 197);
            this.CalculatorHeadingBox.TabIndex = 5;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.White;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(159, 68);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(72, 29);
            this.WeightTextBox.TabIndex = 4;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(159, 133);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(72, 29);
            this.HeightTextBox.TabIndex = 7;
            // 
            // MetersLabel
            // 
            this.MetersLabel.AutoSize = true;
            this.MetersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetersLabel.Location = new System.Drawing.Point(234, 135);
            this.MetersLabel.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.MetersLabel.Name = "MetersLabel";
            this.MetersLabel.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.MetersLabel.Size = new System.Drawing.Size(5, 30);
            this.MetersLabel.TabIndex = 8;
            this.MetersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultDisplayAreaTextBox);
            this.Controls.Add(this.HeadingTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.CalculatorHeadingBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.CalculatorHeadingBox.ResumeLayout(false);
            this.CalculatorHeadingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox HeadingTextBox;
        private System.Windows.Forms.TextBox ResultDisplayAreaTextBox;
        private System.Windows.Forms.RadioButton ImperialUnitsButton;
        private System.Windows.Forms.TableLayoutPanel CalculatorHeadingBox;
        private System.Windows.Forms.RadioButton MetricUnitsButton;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label KgsLabel;
        private System.Windows.Forms.Label MetersLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
    }
}

