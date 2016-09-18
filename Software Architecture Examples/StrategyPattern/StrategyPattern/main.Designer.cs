namespace StrategyPattern
{
    partial class main
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
            this.btnDisplayDuck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFlyDuck = new System.Windows.Forms.Button();
            this.btnQuackDuck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRubber = new System.Windows.Forms.RadioButton();
            this.RadDecoy = new System.Windows.Forms.RadioButton();
            this.RadRedHead = new System.Windows.Forms.RadioButton();
            this.radMallard = new System.Windows.Forms.RadioButton();
            this.lbloutput = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNoWay = new System.Windows.Forms.RadioButton();
            this.radWithWings = new System.Windows.Forms.RadioButton();
            this.radRocketPowered = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayDuck
            // 
            this.btnDisplayDuck.Location = new System.Drawing.Point(159, 83);
            this.btnDisplayDuck.Name = "btnDisplayDuck";
            this.btnDisplayDuck.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayDuck.TabIndex = 0;
            this.btnDisplayDuck.Text = "Display";
            this.btnDisplayDuck.UseVisualStyleBackColor = true;
            this.btnDisplayDuck.Click += new System.EventHandler(this.btnDisplayDuck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duck Simulator";
            // 
            // btnFlyDuck
            // 
            this.btnFlyDuck.Location = new System.Drawing.Point(159, 127);
            this.btnFlyDuck.Name = "btnFlyDuck";
            this.btnFlyDuck.Size = new System.Drawing.Size(75, 23);
            this.btnFlyDuck.TabIndex = 2;
            this.btnFlyDuck.Text = "Fly";
            this.btnFlyDuck.UseVisualStyleBackColor = true;
            this.btnFlyDuck.Click += new System.EventHandler(this.btnFlyDuck_Click);
            // 
            // btnQuackDuck
            // 
            this.btnQuackDuck.Location = new System.Drawing.Point(159, 170);
            this.btnQuackDuck.Name = "btnQuackDuck";
            this.btnQuackDuck.Size = new System.Drawing.Size(75, 23);
            this.btnQuackDuck.TabIndex = 3;
            this.btnQuackDuck.Text = "Quack";
            this.btnQuackDuck.UseVisualStyleBackColor = true;
            this.btnQuackDuck.Click += new System.EventHandler(this.btnQuackDuck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRubber);
            this.groupBox1.Controls.Add(this.RadDecoy);
            this.groupBox1.Controls.Add(this.RadRedHead);
            this.groupBox1.Controls.Add(this.radMallard);
            this.groupBox1.Location = new System.Drawing.Point(21, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duck Type";
            // 
            // radRubber
            // 
            this.radRubber.AutoSize = true;
            this.radRubber.Location = new System.Drawing.Point(7, 93);
            this.radRubber.Name = "radRubber";
            this.radRubber.Size = new System.Drawing.Size(60, 17);
            this.radRubber.TabIndex = 3;
            this.radRubber.TabStop = true;
            this.radRubber.Text = "Rubber";
            this.radRubber.UseVisualStyleBackColor = true;
            // 
            // RadDecoy
            // 
            this.RadDecoy.AutoSize = true;
            this.RadDecoy.Location = new System.Drawing.Point(7, 70);
            this.RadDecoy.Name = "RadDecoy";
            this.RadDecoy.Size = new System.Drawing.Size(56, 17);
            this.RadDecoy.TabIndex = 2;
            this.RadDecoy.TabStop = true;
            this.RadDecoy.Text = "Decoy";
            this.RadDecoy.UseVisualStyleBackColor = true;
            // 
            // RadRedHead
            // 
            this.RadRedHead.AutoSize = true;
            this.RadRedHead.Location = new System.Drawing.Point(7, 47);
            this.RadRedHead.Name = "RadRedHead";
            this.RadRedHead.Size = new System.Drawing.Size(71, 17);
            this.RadRedHead.TabIndex = 1;
            this.RadRedHead.TabStop = true;
            this.RadRedHead.Text = "RedHead";
            this.RadRedHead.UseVisualStyleBackColor = true;
            // 
            // radMallard
            // 
            this.radMallard.AutoSize = true;
            this.radMallard.Location = new System.Drawing.Point(7, 24);
            this.radMallard.Name = "radMallard";
            this.radMallard.Size = new System.Drawing.Size(59, 17);
            this.radMallard.TabIndex = 0;
            this.radMallard.TabStop = true;
            this.radMallard.Text = "Mallard";
            this.radMallard.UseVisualStyleBackColor = true;
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(49, 224);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 13);
            this.lbloutput.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNoWay);
            this.groupBox2.Controls.Add(this.radWithWings);
            this.groupBox2.Controls.Add(this.radRocketPowered);
            this.groupBox2.Location = new System.Drawing.Point(297, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Fly";
            // 
            // radNoWay
            // 
            this.radNoWay.AutoSize = true;
            this.radNoWay.Location = new System.Drawing.Point(7, 70);
            this.radNoWay.Name = "radNoWay";
            this.radNoWay.Size = new System.Drawing.Size(64, 17);
            this.radNoWay.TabIndex = 2;
            this.radNoWay.TabStop = true;
            this.radNoWay.Text = "No Way";
            this.radNoWay.UseVisualStyleBackColor = true;
            // 
            // radWithWings
            // 
            this.radWithWings.AutoSize = true;
            this.radWithWings.Location = new System.Drawing.Point(7, 47);
            this.radWithWings.Name = "radWithWings";
            this.radWithWings.Size = new System.Drawing.Size(80, 17);
            this.radWithWings.TabIndex = 1;
            this.radWithWings.TabStop = true;
            this.radWithWings.Text = "With Wings";
            this.radWithWings.UseVisualStyleBackColor = true;
            // 
            // radRocketPowered
            // 
            this.radRocketPowered.AutoSize = true;
            this.radRocketPowered.Location = new System.Drawing.Point(7, 24);
            this.radRocketPowered.Name = "radRocketPowered";
            this.radRocketPowered.Size = new System.Drawing.Size(105, 17);
            this.radRocketPowered.TabIndex = 0;
            this.radRocketPowered.TabStop = true;
            this.radRocketPowered.Text = "Rocket Powered";
            this.radRocketPowered.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuackDuck);
            this.Controls.Add(this.btnFlyDuck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayDuck);
            this.Name = "main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayDuck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFlyDuck;
        private System.Windows.Forms.Button btnQuackDuck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRubber;
        private System.Windows.Forms.RadioButton RadDecoy;
        private System.Windows.Forms.RadioButton RadRedHead;
        private System.Windows.Forms.RadioButton radMallard;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNoWay;
        private System.Windows.Forms.RadioButton radWithWings;
        private System.Windows.Forms.RadioButton radRocketPowered;
    }
}

