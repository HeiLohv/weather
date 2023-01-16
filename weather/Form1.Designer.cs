namespace weather
{
    partial class Form1
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
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelLocationSearch = new System.Windows.Forms.Label();
            this.textBoxSearch_TextChanged = new System.Windows.Forms.TextBox();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelWindSpeedText = new System.Windows.Forms.Label();
            this.labelHumidityText = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.labelTempFeel = new System.Windows.Forms.Label();
            this.labelPressureText = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelSunriseText = new System.Windows.Forms.Label();
            this.labelSunsetText = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(273, 210);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(86, 31);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "label1";
            // 
            // labelLocationSearch
            // 
            this.labelLocationSearch.AutoSize = true;
            this.labelLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLocationSearch.Location = new System.Drawing.Point(151, 143);
            this.labelLocationSearch.Name = "labelLocationSearch";
            this.labelLocationSearch.Size = new System.Drawing.Size(74, 20);
            this.labelLocationSearch.TabIndex = 1;
            this.labelLocationSearch.Text = "Location:";
            this.labelLocationSearch.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSearch_TextChanged
            // 
            this.textBoxSearch_TextChanged.Location = new System.Drawing.Point(225, 143);
            this.textBoxSearch_TextChanged.Name = "textBoxSearch_TextChanged";
            this.textBoxSearch_TextChanged.Size = new System.Drawing.Size(151, 20);
            this.textBoxSearch_TextChanged.TabIndex = 2;
            this.textBoxSearch_TextChanged.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_TextChanged);
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(275, 245);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(51, 20);
            this.labelWeather.TabIndex = 3;
            this.labelWeather.Text = "label3";
            this.labelWeather.Click += new System.EventHandler(this.labelWeather_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(408, 65);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(408, 89);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 20);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "label1";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(153, 210);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(99, 87);
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(275, 273);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(51, 20);
            this.labelLocation.TabIndex = 7;
            this.labelLocation.Text = "label1";
            // 
            // labelWindSpeedText
            // 
            this.labelWindSpeedText.AutoSize = true;
            this.labelWindSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeedText.Location = new System.Drawing.Point(151, 438);
            this.labelWindSpeedText.Name = "labelWindSpeedText";
            this.labelWindSpeedText.Size = new System.Drawing.Size(101, 20);
            this.labelWindSpeedText.TabIndex = 8;
            this.labelWindSpeedText.Text = "Wind speed: ";
            // 
            // labelHumidityText
            // 
            this.labelHumidityText.AutoSize = true;
            this.labelHumidityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityText.Location = new System.Drawing.Point(151, 409);
            this.labelHumidityText.Name = "labelHumidityText";
            this.labelHumidityText.Size = new System.Drawing.Size(74, 20);
            this.labelHumidityText.TabIndex = 9;
            this.labelHumidityText.Text = "Humidity:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.Location = new System.Drawing.Point(258, 409);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(51, 20);
            this.labelHumidity.TabIndex = 10;
            this.labelHumidity.Text = "label1";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(151, 315);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(38, 20);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(151, 346);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(42, 20);
            this.labelMax.TabIndex = 12;
            this.labelMax.Text = "Max:";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTemp.Location = new System.Drawing.Point(199, 346);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(51, 20);
            this.labelMaxTemp.TabIndex = 13;
            this.labelMaxTemp.Text = "label4";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTemp.Location = new System.Drawing.Point(189, 315);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(51, 20);
            this.labelMinTemp.TabIndex = 14;
            this.labelMinTemp.Text = "label1";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.Location = new System.Drawing.Point(258, 438);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(51, 20);
            this.labelWindSpeed.TabIndex = 15;
            this.labelWindSpeed.Text = "label1";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.Location = new System.Drawing.Point(151, 377);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(79, 20);
            this.labelFeelsLike.TabIndex = 16;
            this.labelFeelsLike.Text = "Feels like:";
            // 
            // labelTempFeel
            // 
            this.labelTempFeel.AutoSize = true;
            this.labelTempFeel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempFeel.Location = new System.Drawing.Point(236, 377);
            this.labelTempFeel.Name = "labelTempFeel";
            this.labelTempFeel.Size = new System.Drawing.Size(51, 20);
            this.labelTempFeel.TabIndex = 17;
            this.labelTempFeel.Text = "label2";
            // 
            // labelPressureText
            // 
            this.labelPressureText.AutoSize = true;
            this.labelPressureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureText.Location = new System.Drawing.Point(151, 467);
            this.labelPressureText.Name = "labelPressureText";
            this.labelPressureText.Size = new System.Drawing.Size(76, 20);
            this.labelPressureText.TabIndex = 18;
            this.labelPressureText.Text = "Pressure:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.Location = new System.Drawing.Point(258, 467);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(51, 20);
            this.labelPressure.TabIndex = 19;
            this.labelPressure.Text = "label1";
            // 
            // labelSunriseText
            // 
            this.labelSunriseText.AutoSize = true;
            this.labelSunriseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunriseText.Location = new System.Drawing.Point(408, 245);
            this.labelSunriseText.Name = "labelSunriseText";
            this.labelSunriseText.Size = new System.Drawing.Size(67, 20);
            this.labelSunriseText.TabIndex = 20;
            this.labelSunriseText.Text = "Sunrise:";
            // 
            // labelSunsetText
            // 
            this.labelSunsetText.AutoSize = true;
            this.labelSunsetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetText.Location = new System.Drawing.Point(408, 276);
            this.labelSunsetText.Name = "labelSunsetText";
            this.labelSunsetText.Size = new System.Drawing.Size(64, 20);
            this.labelSunsetText.TabIndex = 21;
            this.labelSunsetText.Text = "Sunset:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.Location = new System.Drawing.Point(515, 245);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(51, 20);
            this.labelSunrise.TabIndex = 22;
            this.labelSunrise.Text = "label1";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.Location = new System.Drawing.Point(515, 276);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(51, 20);
            this.labelSunset.TabIndex = 23;
            this.labelSunset.Text = "label1";
            // 
            // buttonGet
            // 
            this.buttonGet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGet.Location = new System.Drawing.Point(382, 142);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(49, 22);
            this.buttonGet.TabIndex = 24;
            this.buttonGet.Text = "Ok";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(815, 591);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelSunsetText);
            this.Controls.Add(this.labelSunriseText);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelPressureText);
            this.Controls.Add(this.labelTempFeel);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelHumidityText);
            this.Controls.Add(this.labelWindSpeedText);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.textBoxSearch_TextChanged);
            this.Controls.Add(this.labelLocationSearch);
            this.Controls.Add(this.labelTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelLocationSearch;
        private System.Windows.Forms.TextBox textBoxSearch_TextChanged;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelWindSpeedText;
        private System.Windows.Forms.Label labelHumidityText;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label labelTempFeel;
        private System.Windows.Forms.Label labelPressureText;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelSunriseText;
        private System.Windows.Forms.Label labelSunsetText;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Button buttonGet;
    }
}

