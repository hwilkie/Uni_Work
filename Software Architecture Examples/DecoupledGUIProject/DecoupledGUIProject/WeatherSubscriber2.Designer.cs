namespace DecoupledDLL
{
    partial class WeatherSubscriber2
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
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAverageTemp = new System.Windows.Forms.Label();
            this.lblDisplayAverageTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblDisplayMinTemp = new System.Windows.Forms.Label();
            this.lblDisplayMaxTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Location = new System.Drawing.Point(96, 267);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(75, 23);
            this.btnDeRegister.TabIndex = 24;
            this.btnDeRegister.Text = "De-Register";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(96, 238);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(92, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 13);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Weather Station (Observer)";
            // 
            // lblAverageTemp
            // 
            this.lblAverageTemp.AutoSize = true;
            this.lblAverageTemp.Location = new System.Drawing.Point(71, 73);
            this.lblAverageTemp.Name = "lblAverageTemp";
            this.lblAverageTemp.Size = new System.Drawing.Size(77, 13);
            this.lblAverageTemp.TabIndex = 25;
            this.lblAverageTemp.Text = "Average Temp";
            // 
            // lblDisplayAverageTemp
            // 
            this.lblDisplayAverageTemp.AutoSize = true;
            this.lblDisplayAverageTemp.Location = new System.Drawing.Point(154, 73);
            this.lblDisplayAverageTemp.Name = "lblDisplayAverageTemp";
            this.lblDisplayAverageTemp.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayAverageTemp.TabIndex = 26;
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(89, 119);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(57, 13);
            this.lblMaxTemp.TabIndex = 27;
            this.lblMaxTemp.Text = "Max Temp";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(92, 161);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(54, 13);
            this.lblMinTemp.TabIndex = 28;
            this.lblMinTemp.Text = "Min Temp";
            // 
            // lblDisplayMinTemp
            // 
            this.lblDisplayMinTemp.AutoSize = true;
            this.lblDisplayMinTemp.Location = new System.Drawing.Point(166, 161);
            this.lblDisplayMinTemp.Name = "lblDisplayMinTemp";
            this.lblDisplayMinTemp.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayMinTemp.TabIndex = 29;
            // 
            // lblDisplayMaxTemp
            // 
            this.lblDisplayMaxTemp.AutoSize = true;
            this.lblDisplayMaxTemp.Location = new System.Drawing.Point(157, 118);
            this.lblDisplayMaxTemp.Name = "lblDisplayMaxTemp";
            this.lblDisplayMaxTemp.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayMaxTemp.TabIndex = 30;
            // 
            // WeatherSubscriber2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lblDisplayMaxTemp);
            this.Controls.Add(this.lblDisplayMinTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblDisplayAverageTemp);
            this.Controls.Add(this.lblAverageTemp);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblTitle);
            this.Name = "WeatherSubscriber2";
            this.Text = "WeatherSubscriber2";
            this.Load += new System.EventHandler(this.WeatherSubscriber2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAverageTemp;
        private System.Windows.Forms.Label lblDisplayAverageTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblDisplayMinTemp;
        private System.Windows.Forms.Label lblDisplayMaxTemp;
    }
}