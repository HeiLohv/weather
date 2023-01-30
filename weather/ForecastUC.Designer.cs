namespace weather
{
    partial class ForecastUC
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
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(77, 78);
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(96, 34);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(45, 16);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "label1";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(96, 52);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(45, 16);
            this.labelWeather.TabIndex = 2;
            this.labelWeather.Text = "label1";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(96, 70);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(45, 16);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "label1";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(96, 16);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(45, 16);
            this.labelTemp.TabIndex = 4;
            this.labelTemp.Text = "label1";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.pictureBoxIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(292, 105);
            this.Load += new System.EventHandler(this.Forecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxIcon;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Label labelWeather;
        public System.Windows.Forms.Label labelDescription;
        public System.Windows.Forms.Label labelTemp;
    }
}
