namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.textBack = new System.Windows.Forms.Label();
            this.currentDateOutput = new System.Windows.Forms.Label();
            this.currentCondOutput = new System.Windows.Forms.Label();
            this.visibilityOutput = new System.Windows.Forms.Label();
            this.windspeedOutput = new System.Windows.Forms.Label();
            this.precipitationOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.citySearchImput = new System.Windows.Forms.TextBox();
            this.citySearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(66, 97);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(106, 23);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(142, 193);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(50, 27);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Blue;
            this.minOutput.Location = new System.Drawing.Point(47, 193);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(48, 27);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Baskerville Old Face", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(64, 131);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(108, 62);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "CT";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(139, 29);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // textBack
            // 
            this.textBack.BackColor = System.Drawing.Color.Transparent;
            this.textBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBack.ForeColor = System.Drawing.Color.White;
            this.textBack.Location = new System.Drawing.Point(19, 97);
            this.textBack.Name = "textBack";
            this.textBack.Size = new System.Drawing.Size(194, 123);
            this.textBack.TabIndex = 42;
            this.textBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentDateOutput
            // 
            this.currentDateOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateOutput.ForeColor = System.Drawing.Color.White;
            this.currentDateOutput.Location = new System.Drawing.Point(67, 15);
            this.currentDateOutput.Name = "currentDateOutput";
            this.currentDateOutput.Size = new System.Drawing.Size(106, 14);
            this.currentDateOutput.TabIndex = 43;
            this.currentDateOutput.Text = "current date";
            // 
            // currentCondOutput
            // 
            this.currentCondOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentCondOutput.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCondOutput.ForeColor = System.Drawing.Color.White;
            this.currentCondOutput.Location = new System.Drawing.Point(28, 233);
            this.currentCondOutput.Name = "currentCondOutput";
            this.currentCondOutput.Size = new System.Drawing.Size(185, 38);
            this.currentCondOutput.TabIndex = 44;
            this.currentCondOutput.Text = "Current outdoor conditions";
            this.currentCondOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // visibilityOutput
            // 
            this.visibilityOutput.BackColor = System.Drawing.Color.Transparent;
            this.visibilityOutput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilityOutput.ForeColor = System.Drawing.Color.White;
            this.visibilityOutput.Location = new System.Drawing.Point(6, 319);
            this.visibilityOutput.Name = "visibilityOutput";
            this.visibilityOutput.Size = new System.Drawing.Size(106, 23);
            this.visibilityOutput.TabIndex = 45;
            this.visibilityOutput.Text = "visibility";
            this.visibilityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // windspeedOutput
            // 
            this.windspeedOutput.BackColor = System.Drawing.Color.Transparent;
            this.windspeedOutput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeedOutput.ForeColor = System.Drawing.Color.White;
            this.windspeedOutput.Location = new System.Drawing.Point(51, 377);
            this.windspeedOutput.Name = "windspeedOutput";
            this.windspeedOutput.Size = new System.Drawing.Size(121, 23);
            this.windspeedOutput.TabIndex = 46;
            this.windspeedOutput.Text = "windspeed";
            this.windspeedOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // precipitationOutput
            // 
            this.precipitationOutput.BackColor = System.Drawing.Color.Transparent;
            this.precipitationOutput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationOutput.ForeColor = System.Drawing.Color.White;
            this.precipitationOutput.Location = new System.Drawing.Point(118, 322);
            this.precipitationOutput.Name = "precipitationOutput";
            this.precipitationOutput.Size = new System.Drawing.Size(132, 23);
            this.precipitationOutput.TabIndex = 47;
            this.precipitationOutput.Text = "precipitation";
            this.precipitationOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Precipitation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Visibility";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Windspeed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // citySearchImput
            // 
            this.citySearchImput.Location = new System.Drawing.Point(22, 70);
            this.citySearchImput.Name = "citySearchImput";
            this.citySearchImput.Size = new System.Drawing.Size(115, 20);
            this.citySearchImput.TabIndex = 51;
            // 
            // citySearchButton
            // 
            this.citySearchButton.Location = new System.Drawing.Point(164, 70);
            this.citySearchButton.Name = "citySearchButton";
            this.citySearchButton.Size = new System.Drawing.Size(57, 19);
            this.citySearchButton.TabIndex = 52;
            this.citySearchButton.Text = "Search";
            this.citySearchButton.UseVisualStyleBackColor = true;
            this.citySearchButton.Click += new System.EventHandler(this.citySearchButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.citySearchButton);
            this.Controls.Add(this.citySearchImput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precipitationOutput);
            this.Controls.Add(this.windspeedOutput);
            this.Controls.Add(this.visibilityOutput);
            this.Controls.Add(this.currentCondOutput);
            this.Controls.Add(this.currentDateOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.textBack);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label textBack;
        private System.Windows.Forms.Label currentDateOutput;
        private System.Windows.Forms.Label currentCondOutput;
        private System.Windows.Forms.Label visibilityOutput;
        private System.Windows.Forms.Label windspeedOutput;
        private System.Windows.Forms.Label precipitationOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox citySearchImput;
        private System.Windows.Forms.Button citySearchButton;
    }
}
