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
            this.CalculatorHeadingBox = new System.Windows.Forms.TableLayoutPanel();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeadingTextBox = new System.Windows.Forms.TextBox();
            this.MetricUnitsButton = new System.Windows.Forms.RadioButton();
            this.ImperialUnitsButton = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MetersLabel = new System.Windows.Forms.Label();
            this.KgsLabel = new System.Windows.Forms.Label();
            this.ResultDisplayAreaTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorHeadingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorHeadingBox
            // 
            this.CalculatorHeadingBox.ColumnCount = 4;
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorHeadingBox.Controls.Add(this.MetricUnitsButton, 0, 0);
            this.CalculatorHeadingBox.Controls.Add(this.textBox4, 2, 2);
            this.CalculatorHeadingBox.Controls.Add(this.textBox3, 2, 1);
            this.CalculatorHeadingBox.Controls.Add(this.MyWeightLabel, 0, 1);
            this.CalculatorHeadingBox.Controls.Add(this.HeightLabel, 0, 2);
            this.CalculatorHeadingBox.Controls.Add(this.MetersLabel, 3, 1);
            this.CalculatorHeadingBox.Controls.Add(this.KgsLabel, 3, 2);
            this.CalculatorHeadingBox.Controls.Add(this.ImperialUnitsButton, 2, 0);
            this.CalculatorHeadingBox.Location = new System.Drawing.Point(-7, 65);
            this.CalculatorHeadingBox.Name = "CalculatorHeadingBox";
            this.CalculatorHeadingBox.RowCount = 3;
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorHeadingBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorHeadingBox.Size = new System.Drawing.Size(313, 197);
            this.CalculatorHeadingBox.TabIndex = 0;
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(-7, 404);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(159, 38);
            this.ResultButton.TabIndex = 1;
            this.ResultButton.Text = "View Result";
            this.ResultButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(152, 404);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(158, 38);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset Result";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // HeadingTextBox
            // 
            this.HeadingTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.HeadingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingTextBox.Location = new System.Drawing.Point(2, 12);
            this.HeadingTextBox.Multiline = true;
            this.HeadingTextBox.Name = "HeadingTextBox";
            this.HeadingTextBox.Size = new System.Drawing.Size(310, 47);
            this.HeadingTextBox.TabIndex = 4;
            this.HeadingTextBox.Text = "Body Mass Index (BMI) Calculator";
            // 
            // MetricUnitsButton
            // 
            this.MetricUnitsButton.AutoSize = true;
            this.CalculatorHeadingBox.SetColumnSpan(this.MetricUnitsButton, 2);
            this.MetricUnitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricUnitsButton.Location = new System.Drawing.Point(3, 3);
            this.MetricUnitsButton.Name = "MetricUnitsButton";
            this.MetricUnitsButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.MetricUnitsButton.Size = new System.Drawing.Size(135, 33);
            this.MetricUnitsButton.TabIndex = 0;
            this.MetricUnitsButton.TabStop = true;
            this.MetricUnitsButton.Text = "Metric Units";
            this.MetricUnitsButton.UseVisualStyleBackColor = true;
            // 
            // ImperialUnitsButton
            // 
            this.ImperialUnitsButton.AutoSize = true;
            this.CalculatorHeadingBox.SetColumnSpan(this.ImperialUnitsButton, 2);
            this.ImperialUnitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialUnitsButton.Location = new System.Drawing.Point(159, 3);
            this.ImperialUnitsButton.Name = "ImperialUnitsButton";
            this.ImperialUnitsButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ImperialUnitsButton.Size = new System.Drawing.Size(140, 33);
            this.ImperialUnitsButton.TabIndex = 1;
            this.ImperialUnitsButton.TabStop = true;
            this.ImperialUnitsButton.Text = "Imperial Units";
            this.ImperialUnitsButton.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(156, 135);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 38);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(156, 70);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 38);
            this.textBox3.TabIndex = 4;
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
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "My Height";
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
            this.MyWeightLabel.TabIndex = 6;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // MetersLabel
            // 
            this.MetersLabel.AutoSize = true;
            this.MetersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetersLabel.Location = new System.Drawing.Point(234, 70);
            this.MetersLabel.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.MetersLabel.Name = "MetersLabel";
            this.MetersLabel.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.MetersLabel.Size = new System.Drawing.Size(63, 30);
            this.MetersLabel.TabIndex = 7;
            this.MetersLabel.Text = "Meters";
            // 
            // KgsLabel
            // 
            this.KgsLabel.AutoSize = true;
            this.KgsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgsLabel.Location = new System.Drawing.Point(234, 135);
            this.KgsLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.KgsLabel.Name = "KgsLabel";
            this.KgsLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.KgsLabel.Size = new System.Drawing.Size(78, 25);
            this.KgsLabel.TabIndex = 8;
            this.KgsLabel.Text = "Kilograms";
            // 
            // ResultDisplayAreaTextBox
            // 
            this.ResultDisplayAreaTextBox.BackColor = System.Drawing.Color.White;
            this.ResultDisplayAreaTextBox.Enabled = false;
            this.ResultDisplayAreaTextBox.Location = new System.Drawing.Point(2, 268);
            this.ResultDisplayAreaTextBox.Multiline = true;
            this.ResultDisplayAreaTextBox.Name = "ResultDisplayAreaTextBox";
            this.ResultDisplayAreaTextBox.ReadOnly = true;
            this.ResultDisplayAreaTextBox.Size = new System.Drawing.Size(301, 138);
            this.ResultDisplayAreaTextBox.TabIndex = 5;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultDisplayAreaTextBox);
            this.Controls.Add(this.HeadingTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.CalculatorHeadingBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.CalculatorHeadingBox.ResumeLayout(false);
            this.CalculatorHeadingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorHeadingBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RadioButton MetricUnitsButton;
        private System.Windows.Forms.RadioButton ImperialUnitsButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeadingTextBox;
        private System.Windows.Forms.Label MetersLabel;
        private System.Windows.Forms.Label KgsLabel;
        private System.Windows.Forms.TextBox ResultDisplayAreaTextBox;
    }
}

