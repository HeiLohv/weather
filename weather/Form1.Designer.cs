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
            this.labelDateTime = new System.Windows.Forms.Label();
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
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.labelFeels = new System.Windows.Forms.Label();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.flowLayoutPanelForecast = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTempForecast = new System.Windows.Forms.Label();
            this.labelWeatherForecast = new System.Windows.Forms.Label();
            this.labelDateTimeForecast = new System.Windows.Forms.Label();
            this.pictureBoxIconForecast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(344, 162);
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
            this.labelLocationSearch.Location = new System.Drawing.Point(347, 57);
            this.labelLocationSearch.Name = "labelLocationSearch";
            this.labelLocationSearch.Size = new System.Drawing.Size(74, 20);
            this.labelLocationSearch.TabIndex = 1;
            this.labelLocationSearch.Text = "Location:";
            this.labelLocationSearch.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSearch_TextChanged
            // 
            this.textBoxSearch_TextChanged.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxSearch_TextChanged.Location = new System.Drawing.Point(421, 57);
            this.textBoxSearch_TextChanged.Name = "textBoxSearch_TextChanged";
            this.textBoxSearch_TextChanged.Size = new System.Drawing.Size(175, 20);
            this.textBoxSearch_TextChanged.TabIndex = 2;
            this.textBoxSearch_TextChanged.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_TextChanged);
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(345, 203);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(51, 20);
            this.labelWeather.TabIndex = 3;
            this.labelWeather.Text = "label3";
            this.labelWeather.Visible = false;
            this.labelWeather.Click += new System.EventHandler(this.labelWeather_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(584, 162);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(86, 31);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "label1";
            this.labelDateTime.Visible = false;
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(472, 191);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(48, 44);
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(346, 232);
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
            this.labelWindSpeedText.Location = new System.Drawing.Point(587, 313);
            this.labelWindSpeedText.Name = "labelWindSpeedText";
            this.labelWindSpeedText.Size = new System.Drawing.Size(101, 20);
            this.labelWindSpeedText.TabIndex = 8;
            this.labelWindSpeedText.Text = "Wind speed: ";
            // 
            // labelHumidityText
            // 
            this.labelHumidityText.AutoSize = true;
            this.labelHumidityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityText.Location = new System.Drawing.Point(587, 284);
            this.labelHumidityText.Name = "labelHumidityText";
            this.labelHumidityText.Size = new System.Drawing.Size(74, 20);
            this.labelHumidityText.TabIndex = 9;
            this.labelHumidityText.Text = "Humidity:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.Location = new System.Drawing.Point(667, 284);
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
            this.labelMin.Location = new System.Drawing.Point(351, 313);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(38, 20);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(350, 342);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(42, 20);
            this.labelMax.TabIndex = 12;
            this.labelMax.Text = "Max:";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTemp.Location = new System.Drawing.Point(395, 342);
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
            this.labelMinTemp.Location = new System.Drawing.Point(392, 313);
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
            this.labelWindSpeed.Location = new System.Drawing.Point(687, 313);
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
            this.labelPressureText.Location = new System.Drawing.Point(587, 342);
            this.labelPressureText.Name = "labelPressureText";
            this.labelPressureText.Size = new System.Drawing.Size(76, 20);
            this.labelPressureText.TabIndex = 18;
            this.labelPressureText.Text = "Pressure:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.Location = new System.Drawing.Point(669, 342);
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
            this.labelSunriseText.Location = new System.Drawing.Point(587, 203);
            this.labelSunriseText.Name = "labelSunriseText";
            this.labelSunriseText.Size = new System.Drawing.Size(67, 20);
            this.labelSunriseText.TabIndex = 20;
            this.labelSunriseText.Text = "Sunrise:";
            // 
            // labelSunsetText
            // 
            this.labelSunsetText.AutoSize = true;
            this.labelSunsetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetText.Location = new System.Drawing.Point(587, 232);
            this.labelSunsetText.Name = "labelSunsetText";
            this.labelSunsetText.Size = new System.Drawing.Size(64, 20);
            this.labelSunsetText.TabIndex = 21;
            this.labelSunsetText.Text = "Sunset:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.Location = new System.Drawing.Point(660, 203);
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
            this.labelSunset.Location = new System.Drawing.Point(657, 232);
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
            this.buttonGet.Location = new System.Drawing.Point(421, 84);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(56, 22);
            this.buttonGet.TabIndex = 24;
            this.buttonGet.Text = "Search";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.Location = new System.Drawing.Point(350, 284);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(79, 20);
            this.labelFeelsLike.TabIndex = 26;
            this.labelFeelsLike.Text = "Feels like:";
            this.labelFeelsLike.Visible = false;
            this.labelFeelsLike.Click += new System.EventHandler(this.labelFeelsLike_Click);
            // 
            // labelFeels
            // 
            this.labelFeels.AutoSize = true;
            this.labelFeels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeels.Location = new System.Drawing.Point(435, 284);
            this.labelFeels.Name = "labelFeels";
            this.labelFeels.Size = new System.Drawing.Size(51, 20);
            this.labelFeels.TabIndex = 27;
            this.labelFeels.Text = "label2";
            this.labelFeels.Visible = false;
            this.labelFeels.Click += new System.EventHandler(this.labelFeels_Click);
            // 
            // listBoxList
            // 
            this.listBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 16;
            this.listBoxList.Location = new System.Drawing.Point(36, 57);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(164, 340);
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
            this.buttonAdd.Location = new System.Drawing.Point(483, 84);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 22);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Add to list";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShow.Location = new System.Drawing.Point(214, 69);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(60, 22);
            this.buttonShow.TabIndex = 30;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(214, 107);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 22);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReadFile.Location = new System.Drawing.Point(214, 182);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(60, 22);
            this.buttonReadFile.TabIndex = 32;
            this.buttonReadFile.Text = "Read file";
            this.buttonReadFile.UseVisualStyleBackColor = false;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(214, 145);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 22);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Save ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // flowLayoutPanelForecast
            // 
            this.flowLayoutPanelForecast.AutoScroll = true;
            this.flowLayoutPanelForecast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelForecast.Location = new System.Drawing.Point(36, 421);
            this.flowLayoutPanelForecast.Name = "flowLayoutPanelForecast";
            this.flowLayoutPanelForecast.Size = new System.Drawing.Size(833, 109);
            this.flowLayoutPanelForecast.TabIndex = 34;
            this.flowLayoutPanelForecast.WrapContents = false;
            // 
            // labelTempForecast
            // 
            this.labelTempForecast.AutoSize = true;
            this.labelTempForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempForecast.Location = new System.Drawing.Point(97, 557);
            this.labelTempForecast.Name = "labelTempForecast";
            this.labelTempForecast.Size = new System.Drawing.Size(51, 20);
            this.labelTempForecast.TabIndex = 38;
            this.labelTempForecast.Text = "label1";
            this.labelTempForecast.Visible = false;
            // 
            // labelWeatherForecast
            // 
            this.labelWeatherForecast.AutoSize = true;
            this.labelWeatherForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeatherForecast.Location = new System.Drawing.Point(97, 597);
            this.labelWeatherForecast.Name = "labelWeatherForecast";
            this.labelWeatherForecast.Size = new System.Drawing.Size(51, 20);
            this.labelWeatherForecast.TabIndex = 37;
            this.labelWeatherForecast.Text = "label1";
            this.labelWeatherForecast.Visible = false;
            // 
            // labelDateTimeForecast
            // 
            this.labelDateTimeForecast.AutoSize = true;
            this.labelDateTimeForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTimeForecast.Location = new System.Drawing.Point(97, 577);
            this.labelDateTimeForecast.Name = "labelDateTimeForecast";
            this.labelDateTimeForecast.Size = new System.Drawing.Size(51, 20);
            this.labelDateTimeForecast.TabIndex = 36;
            this.labelDateTimeForecast.Text = "label1";
            this.labelDateTimeForecast.Visible = false;
            // 
            // pictureBoxIconForecast
            // 
            this.pictureBoxIconForecast.Location = new System.Drawing.Point(36, 557);
            this.pictureBoxIconForecast.Name = "pictureBoxIconForecast";
            this.pictureBoxIconForecast.Size = new System.Drawing.Size(55, 52);
            this.pictureBoxIconForecast.TabIndex = 35;
            this.pictureBoxIconForecast.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(909, 663);
            this.Controls.Add(this.labelTempForecast);
            this.Controls.Add(this.labelWeatherForecast);
            this.Controls.Add(this.labelDateTimeForecast);
            this.Controls.Add(this.pictureBoxIconForecast);
            this.Controls.Add(this.flowLayoutPanelForecast);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.labelFeels);
            this.Controls.Add(this.labelFeelsLike);
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
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.textBoxSearch_TextChanged);
            this.Controls.Add(this.labelLocationSearch);
            this.Controls.Add(this.labelTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconForecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelLocationSearch;
        private System.Windows.Forms.TextBox textBoxSearch_TextChanged;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelDateTime;
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
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label labelFeels;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelForecast;
        public System.Windows.Forms.Label labelTempForecast;
        public System.Windows.Forms.Label labelWeatherForecast;
        public System.Windows.Forms.Label labelDateTimeForecast;
        public System.Windows.Forms.PictureBox pictureBoxIconForecast;
    }
}

