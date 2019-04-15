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
            this.cTempLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.csPic = new System.Windows.Forms.PictureBox();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.forecastButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.csPic)).BeginInit();
            this.SuspendLayout();
            // 
            // cTempLabel
            // 
            this.cTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.cTempLabel.Font = new System.Drawing.Font("Futura-Heavy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTempLabel.ForeColor = System.Drawing.Color.White;
            this.cTempLabel.Location = new System.Drawing.Point(109, 112);
            this.cTempLabel.Name = "cTempLabel";
            this.cTempLabel.Size = new System.Drawing.Size(174, 123);
            this.cTempLabel.TabIndex = 0;
            this.cTempLabel.Text = "cTempLabel";
            this.cTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Futura-Heavy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(109, 235);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(152, 58);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "label1";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayLabel
            // 
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Futura-Heavy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.dayLabel.Location = new System.Drawing.Point(243, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(129, 40);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "label1";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Futura-Heavy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(67, 380);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(91, 58);
            this.maxLabel.TabIndex = 3;
            this.maxLabel.Text = "label1";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Futura-Heavy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(67, 438);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(91, 58);
            this.minLabel.TabIndex = 4;
            this.minLabel.Text = "label1";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // csPic
            // 
            this.csPic.BackColor = System.Drawing.Color.Transparent;
            this.csPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.csPic.Location = new System.Drawing.Point(164, 368);
            this.csPic.Name = "csPic";
            this.csPic.Size = new System.Drawing.Size(127, 116);
            this.csPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.csPic.TabIndex = 5;
            this.csPic.TabStop = false;
            // 
            // forecastLabel
            // 
            this.forecastLabel.AutoSize = true;
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(147, 580);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(72, 20);
            this.forecastLabel.TabIndex = 6;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastButton
            // 
            this.forecastButton.BackColor = System.Drawing.Color.Transparent;
            this.forecastButton.ForeColor = System.Drawing.Color.Transparent;
            this.forecastButton.Location = new System.Drawing.Point(-10, 572);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(397, 48);
            this.forecastButton.TabIndex = 7;
            this.forecastButton.UseVisualStyleBackColor = false;
            this.forecastButton.Click += new System.EventHandler(this.forecastButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Blueback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.forecastButton);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.csPic);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cTempLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(375, 620);
            ((System.ComponentModel.ISupportInitialize)(this.csPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cTempLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.PictureBox csPic;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Button forecastButton;
    }
}
