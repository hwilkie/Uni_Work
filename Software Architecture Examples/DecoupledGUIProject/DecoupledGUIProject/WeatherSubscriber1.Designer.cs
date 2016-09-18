namespace DecoupledDLL
{
    partial class WeatherSubscriber1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDisplayTemp = new System.Windows.Forms.Label();
            this.lblDisplayHumidity = new System.Windows.Forms.Label();
            this.lblDisplayPressure = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(87, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 13);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Weather Station (Observer)";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(87, 205);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(48, 13);
            this.lblPressure.TabIndex = 10;
            this.lblPressure.Text = "Pressure";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(88, 156);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 13);
            this.lblHumidity.TabIndex = 9;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(68, 108);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 7;
            this.lblTemp.Text = "Temperature";
            // 
            // lblDisplayTemp
            // 
            this.lblDisplayTemp.AutoSize = true;
            this.lblDisplayTemp.Location = new System.Drawing.Point(159, 108);
            this.lblDisplayTemp.Name = "lblDisplayTemp";
            this.lblDisplayTemp.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayTemp.TabIndex = 14;
            // 
            // lblDisplayHumidity
            // 
            this.lblDisplayHumidity.AutoSize = true;
            this.lblDisplayHumidity.Location = new System.Drawing.Point(159, 156);
            this.lblDisplayHumidity.Name = "lblDisplayHumidity";
            this.lblDisplayHumidity.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayHumidity.TabIndex = 15;
            // 
            // lblDisplayPressure
            // 
            this.lblDisplayPressure.AutoSize = true;
            this.lblDisplayPressure.Location = new System.Drawing.Point(159, 205);
            this.lblDisplayPressure.Name = "lblDisplayPressure";
            this.lblDisplayPressure.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayPressure.TabIndex = 16;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(91, 266);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Location = new System.Drawing.Point(91, 295);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(75, 23);
            this.btnDeRegister.TabIndex = 18;
            this.btnDeRegister.Text = "De-Register";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            this.btnDeRegister.Click += new System.EventHandler(this.btnDeRegister_Click);
            // 
            // WeatherSubscriber1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblDisplayPressure);
            this.Controls.Add(this.lblDisplayHumidity);
            this.Controls.Add(this.lblDisplayTemp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Name = "WeatherSubscriber1";
            this.Text = "WeatherSubscriber1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDisplayTemp;
        private System.Windows.Forms.Label lblDisplayHumidity;
        private System.Windows.Forms.Label lblDisplayPressure;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDeRegister;
    }
}