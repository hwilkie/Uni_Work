namespace DecoupledDLL
{
    partial class WeatherPublisher
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.tbTmp = new System.Windows.Forms.TextBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(72, 115);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperature";
            // 
            // tbTmp
            // 
            this.tbTmp.Location = new System.Drawing.Point(145, 112);
            this.tbTmp.Name = "tbTmp";
            this.tbTmp.Size = new System.Drawing.Size(62, 20);
            this.tbTmp.TabIndex = 1;
            this.tbTmp.TextChanged += new System.EventHandler(this.tbTmp_TextChanged);
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(92, 163);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 13);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(91, 212);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(48, 13);
            this.lblPressure.TabIndex = 3;
            this.lblPressure.Text = "Pressure";
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(145, 160);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(62, 20);
            this.tbHumidity.TabIndex = 4;
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(145, 209);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(62, 20);
            this.tbPressure.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(91, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Weather Station (Subject)";
            // 
            // WeatherPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 266);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbPressure);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.tbTmp);
            this.Controls.Add(this.lblTemp);
            this.Name = "WeatherPublisher";
            this.Text = "WeatherPublisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox tbTmp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.Label lblTitle;
    }
}