﻿namespace weather
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelWindSpeedText = new System.Windows.Forms.Label();
            this.labelHumidityText = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelPressureText = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelSunriseText = new System.Windows.Forms.Label();
            this.labelSunsetText = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.labelFeels = new System.Windows.Forms.Label();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(273, 159);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(86, 31);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "label1";
            this.labelTemperature.Visible = false;
            // 
            // labelLocationSearch
            // 
            this.labelLocationSearch.AutoSize = true;
            this.labelLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLocationSearch.Location = new System.Drawing.Point(265, 64);
            this.labelLocationSearch.Name = "labelLocationSearch";
            this.labelLocationSearch.Size = new System.Drawing.Size(74, 20);
            this.labelLocationSearch.TabIndex = 1;
            this.labelLocationSearch.Text = "Location:";
            this.labelLocationSearch.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSearch_TextChanged
            // 
            this.textBoxSearch_TextChanged.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearch_TextChanged.Location = new System.Drawing.Point(339, 64);
            this.textBoxSearch_TextChanged.Name = "textBoxSearch_TextChanged";
            this.textBoxSearch_TextChanged.Size = new System.Drawing.Size(175, 20);
            this.textBoxSearch_TextChanged.TabIndex = 2;
            this.textBoxSearch_TextChanged.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_TextChanged);
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(275, 194);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(51, 20);
            this.labelWeather.TabIndex = 3;
            this.labelWeather.Text = "label3";
            this.labelWeather.Visible = false;
            this.labelWeather.Click += new System.EventHandler(this.labelWeather_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(174, 62);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(174, 84);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 20);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "label1";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(155, 159);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(95, 83);
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(275, 222);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(51, 20);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "label1";
            this.labelDescription.Visible = false;
            // 
            // labelWindSpeedText
            // 
            this.labelWindSpeedText.AutoSize = true;
            this.labelWindSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeedText.Location = new System.Drawing.Point(413, 198);
            this.labelWindSpeedText.Name = "labelWindSpeedText";
            this.labelWindSpeedText.Size = new System.Drawing.Size(101, 20);
            this.labelWindSpeedText.TabIndex = 8;
            this.labelWindSpeedText.Text = "Wind speed: ";
            // 
            // labelHumidityText
            // 
            this.labelHumidityText.AutoSize = true;
            this.labelHumidityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityText.Location = new System.Drawing.Point(413, 169);
            this.labelHumidityText.Name = "labelHumidityText";
            this.labelHumidityText.Size = new System.Drawing.Size(74, 20);
            this.labelHumidityText.TabIndex = 9;
            this.labelHumidityText.Text = "Humidity:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.Location = new System.Drawing.Point(520, 169);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(51, 20);
            this.labelHumidity.TabIndex = 10;
            this.labelHumidity.Text = "label1";
            this.labelHumidity.Visible = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(267, 264);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(38, 20);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(267, 295);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(42, 20);
            this.labelMax.TabIndex = 12;
            this.labelMax.Text = "Max:";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTemp.Location = new System.Drawing.Point(315, 295);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(51, 20);
            this.labelMaxTemp.TabIndex = 13;
            this.labelMaxTemp.Text = "label4";
            this.labelMaxTemp.Visible = false;
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTemp.Location = new System.Drawing.Point(315, 264);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(34, 20);
            this.labelMinTemp.TabIndex = 14;
            this.labelMinTemp.Text = "min";
            this.labelMinTemp.Visible = false;
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.Location = new System.Drawing.Point(520, 198);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(51, 20);
            this.labelWindSpeed.TabIndex = 15;
            this.labelWindSpeed.Text = "label1";
            this.labelWindSpeed.Visible = false;
            // 
            // labelPressureText
            // 
            this.labelPressureText.AutoSize = true;
            this.labelPressureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureText.Location = new System.Drawing.Point(413, 227);
            this.labelPressureText.Name = "labelPressureText";
            this.labelPressureText.Size = new System.Drawing.Size(76, 20);
            this.labelPressureText.TabIndex = 18;
            this.labelPressureText.Text = "Pressure:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.Location = new System.Drawing.Point(520, 227);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(51, 20);
            this.labelPressure.TabIndex = 19;
            this.labelPressure.Text = "label1";
            this.labelPressure.Visible = false;
            // 
            // labelSunriseText
            // 
            this.labelSunriseText.AutoSize = true;
            this.labelSunriseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunriseText.Location = new System.Drawing.Point(413, 264);
            this.labelSunriseText.Name = "labelSunriseText";
            this.labelSunriseText.Size = new System.Drawing.Size(67, 20);
            this.labelSunriseText.TabIndex = 20;
            this.labelSunriseText.Text = "Sunrise:";
            // 
            // labelSunsetText
            // 
            this.labelSunsetText.AutoSize = true;
            this.labelSunsetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetText.Location = new System.Drawing.Point(413, 295);
            this.labelSunsetText.Name = "labelSunsetText";
            this.labelSunsetText.Size = new System.Drawing.Size(64, 20);
            this.labelSunsetText.TabIndex = 21;
            this.labelSunsetText.Text = "Sunset:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.Location = new System.Drawing.Point(520, 264);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(51, 20);
            this.labelSunrise.TabIndex = 22;
            this.labelSunrise.Text = "label1";
            this.labelSunrise.Visible = false;
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.Location = new System.Drawing.Point(520, 295);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(51, 20);
            this.labelSunset.TabIndex = 23;
            this.labelSunset.Text = "label1";
            this.labelSunset.Visible = false;
            // 
            // buttonGet
            // 
            this.buttonGet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGet.Location = new System.Drawing.Point(339, 91);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(56, 22);
            this.buttonGet.TabIndex = 24;
            this.buttonGet.Text = "Search";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(331, 131);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(35, 13);
            this.labelError.TabIndex = 25;
            this.labelError.Text = "label1";
            this.labelError.Visible = false;
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.Location = new System.Drawing.Point(155, 264);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(75, 20);
            this.labelFeelsLike.TabIndex = 26;
            this.labelFeelsLike.Text = "Feels like";
            this.labelFeelsLike.Visible = false;
            // 
            // labelFeels
            // 
            this.labelFeels.AutoSize = true;
            this.labelFeels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeels.Location = new System.Drawing.Point(156, 286);
            this.labelFeels.Name = "labelFeels";
            this.labelFeels.Size = new System.Drawing.Size(51, 20);
            this.labelFeels.TabIndex = 27;
            this.labelFeels.Text = "label2";
            this.labelFeels.Visible = false;
            // 
            // listBoxList
            // 
            this.listBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 16;
            this.listBoxList.Location = new System.Drawing.Point(12, 47);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(105, 292);
            this.listBoxList.TabIndex = 28;
            this.listBoxList.UseTabStops = false;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBoxList_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(401, 91);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 22);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Add to list";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(647, 389);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.labelFeels);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelSunsetText);
            this.Controls.Add(this.labelSunriseText);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelPressureText);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelHumidityText);
            this.Controls.Add(this.labelWindSpeedText);
            this.Controls.Add(this.labelDescription);
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
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelWindSpeedText;
        private System.Windows.Forms.Label labelHumidityText;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelPressureText;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelSunriseText;
        private System.Windows.Forms.Label labelSunsetText;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label labelFeels;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Button buttonAdd;
    }
}

