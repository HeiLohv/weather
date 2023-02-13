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
            this.pictureBoxIconFuc = new System.Windows.Forms.PictureBox();
            this.labelDateTimeFuc = new System.Windows.Forms.Label();
            this.labelWeatherFuc = new System.Windows.Forms.Label();
            this.labelTempFuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconFuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIconFuc
            // 
            this.pictureBoxIconFuc.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxIconFuc.Name = "pictureBoxIconFuc";
            this.pictureBoxIconFuc.Size = new System.Drawing.Size(55, 52);
            this.pictureBoxIconFuc.TabIndex = 0;
            this.pictureBoxIconFuc.TabStop = false;
            // 
            // labelDateTimeFuc
            // 
            this.labelDateTimeFuc.AutoSize = true;
            this.labelDateTimeFuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTimeFuc.Location = new System.Drawing.Point(74, 33);
            this.labelDateTimeFuc.Name = "labelDateTimeFuc";
            this.labelDateTimeFuc.Size = new System.Drawing.Size(45, 16);
            this.labelDateTimeFuc.TabIndex = 1;
            this.labelDateTimeFuc.Text = "label1";
            // 
            // labelWeatherFuc
            // 
            this.labelWeatherFuc.AutoSize = true;
            this.labelWeatherFuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeatherFuc.Location = new System.Drawing.Point(74, 50);
            this.labelWeatherFuc.Name = "labelWeatherFuc";
            this.labelWeatherFuc.Size = new System.Drawing.Size(45, 16);
            this.labelWeatherFuc.TabIndex = 2;
            this.labelWeatherFuc.Text = "label1";
            // 
            // labelTempFuc
            // 
            this.labelTempFuc.AutoSize = true;
            this.labelTempFuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempFuc.Location = new System.Drawing.Point(74, 16);
            this.labelTempFuc.Name = "labelTempFuc";
            this.labelTempFuc.Size = new System.Drawing.Size(45, 16);
            this.labelTempFuc.TabIndex = 3;
            this.labelTempFuc.Text = "label1";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.labelTempFuc);
            this.Controls.Add(this.labelWeatherFuc);
            this.Controls.Add(this.labelDateTimeFuc);
            this.Controls.Add(this.pictureBoxIconFuc);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(197, 81);
            this.Load += new System.EventHandler(this.Forecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconFuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxIconFuc;
        public System.Windows.Forms.Label labelDateTimeFuc;
        public System.Windows.Forms.Label labelWeatherFuc;
        public System.Windows.Forms.Label labelTempFuc;
    }
}
