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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.labelMinTempText = new System.Windows.Forms.Label();
            this.labelMaxTempText = new System.Windows.Forms.Label();
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
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(359, 137);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(86, 31);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "label1";
            this.labelTemperature.Visible = false;
            // 
            // labelLocationSearch
            // 
            this.labelLocationSearch.AutoSize = true;
            this.labelLocationSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLocationSearch.Location = new System.Drawing.Point(361, 53);
            this.labelLocationSearch.Name = "labelLocationSearch";
            this.labelLocationSearch.Size = new System.Drawing.Size(74, 20);
            this.labelLocationSearch.TabIndex = 1;
            this.labelLocationSearch.Text = "Location:";
            this.labelLocationSearch.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSearch_TextChanged
            // 
            this.textBoxSearch_TextChanged.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxSearch_TextChanged.Location = new System.Drawing.Point(435, 53);
            this.textBoxSearch_TextChanged.Name = "textBoxSearch_TextChanged";
            this.textBoxSearch_TextChanged.Size = new System.Drawing.Size(175, 20);
            this.textBoxSearch_TextChanged.TabIndex = 2;
            this.textBoxSearch_TextChanged.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_TextChanged);
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.BackColor = System.Drawing.Color.Transparent;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(362, 182);
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
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(596, 137);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(86, 31);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "label1";
            this.labelDateTime.Visible = false;
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Location = new System.Drawing.Point(473, 168);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(58, 41);
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(363, 212);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(51, 20);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "label1";
            this.labelDescription.Visible = false;
            // 
            // labelWindSpeedText
            // 
            this.labelWindSpeedText.AutoSize = true;
            this.labelWindSpeedText.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeedText.Location = new System.Drawing.Point(599, 294);
            this.labelWindSpeedText.Name = "labelWindSpeedText";
            this.labelWindSpeedText.Size = new System.Drawing.Size(101, 20);
            this.labelWindSpeedText.TabIndex = 8;
            this.labelWindSpeedText.Text = "Wind speed: ";
            this.labelWindSpeedText.Visible = false;
            // 
            // labelHumidityText
            // 
            this.labelHumidityText.AutoSize = true;
            this.labelHumidityText.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidityText.Location = new System.Drawing.Point(599, 264);
            this.labelHumidityText.Name = "labelHumidityText";
            this.labelHumidityText.Size = new System.Drawing.Size(74, 20);
            this.labelHumidityText.TabIndex = 9;
            this.labelHumidityText.Text = "Humidity:";
            this.labelHumidityText.Visible = false;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.Location = new System.Drawing.Point(679, 264);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(51, 20);
            this.labelHumidity.TabIndex = 10;
            this.labelHumidity.Text = "label1";
            this.labelHumidity.Visible = false;
            // 
            // labelMinTempText
            // 
            this.labelMinTempText.AutoSize = true;
            this.labelMinTempText.BackColor = System.Drawing.Color.Transparent;
            this.labelMinTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTempText.Location = new System.Drawing.Point(363, 294);
            this.labelMinTempText.Name = "labelMinTempText";
            this.labelMinTempText.Size = new System.Drawing.Size(38, 20);
            this.labelMinTempText.TabIndex = 11;
            this.labelMinTempText.Text = "Min:";
            this.labelMinTempText.Visible = false;
            // 
            // labelMaxTempText
            // 
            this.labelMaxTempText.AutoSize = true;
            this.labelMaxTempText.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTempText.Location = new System.Drawing.Point(362, 324);
            this.labelMaxTempText.Name = "labelMaxTempText";
            this.labelMaxTempText.Size = new System.Drawing.Size(42, 20);
            this.labelMaxTempText.TabIndex = 12;
            this.labelMaxTempText.Text = "Max:";
            this.labelMaxTempText.Visible = false;
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTemp.Location = new System.Drawing.Point(407, 324);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(51, 20);
            this.labelMaxTemp.TabIndex = 13;
            this.labelMaxTemp.Text = "label4";
            this.labelMaxTemp.Visible = false;
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTemp.Location = new System.Drawing.Point(404, 294);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(34, 20);
            this.labelMinTemp.TabIndex = 14;
            this.labelMinTemp.Text = "min";
            this.labelMinTemp.Visible = false;
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.Location = new System.Drawing.Point(699, 294);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(51, 20);
            this.labelWindSpeed.TabIndex = 15;
            this.labelWindSpeed.Text = "label1";
            this.labelWindSpeed.Visible = false;
            // 
            // labelPressureText
            // 
            this.labelPressureText.AutoSize = true;
            this.labelPressureText.BackColor = System.Drawing.Color.Transparent;
            this.labelPressureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureText.Location = new System.Drawing.Point(599, 324);
            this.labelPressureText.Name = "labelPressureText";
            this.labelPressureText.Size = new System.Drawing.Size(76, 20);
            this.labelPressureText.TabIndex = 18;
            this.labelPressureText.Text = "Pressure:";
            this.labelPressureText.Visible = false;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.BackColor = System.Drawing.Color.Transparent;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.Location = new System.Drawing.Point(681, 324);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(51, 20);
            this.labelPressure.TabIndex = 19;
            this.labelPressure.Text = "label1";
            this.labelPressure.Visible = false;
            // 
            // labelSunriseText
            // 
            this.labelSunriseText.AutoSize = true;
            this.labelSunriseText.BackColor = System.Drawing.Color.Transparent;
            this.labelSunriseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunriseText.Location = new System.Drawing.Point(599, 182);
            this.labelSunriseText.Name = "labelSunriseText";
            this.labelSunriseText.Size = new System.Drawing.Size(67, 20);
            this.labelSunriseText.TabIndex = 20;
            this.labelSunriseText.Text = "Sunrise:";
            this.labelSunriseText.Visible = false;
            // 
            // labelSunsetText
            // 
            this.labelSunsetText.AutoSize = true;
            this.labelSunsetText.BackColor = System.Drawing.Color.Transparent;
            this.labelSunsetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetText.Location = new System.Drawing.Point(599, 212);
            this.labelSunsetText.Name = "labelSunsetText";
            this.labelSunsetText.Size = new System.Drawing.Size(64, 20);
            this.labelSunsetText.TabIndex = 21;
            this.labelSunsetText.Text = "Sunset:";
            this.labelSunsetText.Visible = false;
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrise.Location = new System.Drawing.Point(672, 182);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(51, 20);
            this.labelSunrise.TabIndex = 22;
            this.labelSunrise.Text = "label1";
            this.labelSunrise.Visible = false;
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunset.Location = new System.Drawing.Point(669, 212);
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
            this.buttonGet.Location = new System.Drawing.Point(435, 80);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(56, 24);
            this.buttonGet.TabIndex = 24;
            this.buttonGet.Text = "Search";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.Location = new System.Drawing.Point(362, 264);
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
            this.labelFeels.BackColor = System.Drawing.Color.Transparent;
            this.labelFeels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeels.Location = new System.Drawing.Point(447, 264);
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
            this.listBoxList.Location = new System.Drawing.Point(56, 42);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(177, 340);
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
            this.buttonAdd.Location = new System.Drawing.Point(499, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 24);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Add to list";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShow.Location = new System.Drawing.Point(247, 49);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(60, 24);
            this.buttonShow.TabIndex = 30;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(247, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 24);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReadFile.Location = new System.Drawing.Point(247, 89);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(60, 24);
            this.buttonReadFile.TabIndex = 32;
            this.buttonReadFile.Text = "Read file";
            this.buttonReadFile.UseVisualStyleBackColor = false;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(247, 128);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 24);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Save ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // flowLayoutPanelForecast
            // 
            this.flowLayoutPanelForecast.AutoScroll = true;
            this.flowLayoutPanelForecast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelForecast.Location = new System.Drawing.Point(56, 415);
            this.flowLayoutPanelForecast.Name = "flowLayoutPanelForecast";
            this.flowLayoutPanelForecast.Size = new System.Drawing.Size(833, 211);
            this.flowLayoutPanelForecast.TabIndex = 34;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(247, 206);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 24);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "Clear ";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 658);
            this.Controls.Add(this.buttonClear);
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
            this.Controls.Add(this.labelMaxTempText);
            this.Controls.Add(this.labelMinTempText);
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
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
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
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelWindSpeedText;
        private System.Windows.Forms.Label labelHumidityText;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelMinTempText;
        private System.Windows.Forms.Label labelMaxTempText;
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
        private System.Windows.Forms.Button buttonClear;
    }
}

