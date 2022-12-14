namespace MissionPlanner
{
    partial class controlMultipleRelays
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
            this.leftOn = new MissionPlanner.Controls.MavlinkCheckBox();
            this.leftOff = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rightOn = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rightOff = new MissionPlanner.Controls.MavlinkCheckBox();
            this.leftOne = new MissionPlanner.Controls.MyButton();
            this.leftTwo = new MissionPlanner.Controls.MyButton();
            this.leftThree = new MissionPlanner.Controls.MyButton();
            this.leftFour = new MissionPlanner.Controls.MyButton();
            this.leftFive = new MissionPlanner.Controls.MyButton();
            this.rightOne = new MissionPlanner.Controls.MyButton();
            this.rightTwo = new MissionPlanner.Controls.MyButton();
            this.rightThree = new MissionPlanner.Controls.MyButton();
            this.rightFour = new MissionPlanner.Controls.MyButton();
            this.rightFive = new MissionPlanner.Controls.MyButton();
            this.rightAll = new MissionPlanner.Controls.MyButton();
            this.leftAll = new MissionPlanner.Controls.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // leftOn
            // 
            this.leftOn.AutoSize = true;
            this.leftOn.Enabled = false;
            this.leftOn.Location = new System.Drawing.Point(12, 26);
            this.leftOn.Name = "leftOn";
            this.leftOn.OffValue = 0D;
            this.leftOn.OnValue = 1D;
            this.leftOn.ParamName = null;
            this.leftOn.Size = new System.Drawing.Size(40, 16);
            this.leftOn.TabIndex = 0;
            this.leftOn.Text = "On";
            this.leftOn.UseVisualStyleBackColor = true;
            this.leftOn.CheckedChanged += new System.EventHandler(this.leftOn_CheckedChanged);
            // 
            // leftOff
            // 
            this.leftOff.AutoSize = true;
            this.leftOff.Enabled = false;
            this.leftOff.Location = new System.Drawing.Point(12, 48);
            this.leftOff.Name = "leftOff";
            this.leftOff.OffValue = 0D;
            this.leftOff.OnValue = 1D;
            this.leftOff.ParamName = null;
            this.leftOff.Size = new System.Drawing.Size(39, 16);
            this.leftOff.TabIndex = 1;
            this.leftOff.Text = "Off";
            this.leftOff.UseVisualStyleBackColor = true;
            this.leftOff.CheckedChanged += new System.EventHandler(this.leftOff_CheckedChanged);
            // 
            // rightOn
            // 
            this.rightOn.AutoSize = true;
            this.rightOn.Enabled = false;
            this.rightOn.Location = new System.Drawing.Point(192, 27);
            this.rightOn.Name = "rightOn";
            this.rightOn.OffValue = 0D;
            this.rightOn.OnValue = 1D;
            this.rightOn.ParamName = null;
            this.rightOn.Size = new System.Drawing.Size(40, 16);
            this.rightOn.TabIndex = 0;
            this.rightOn.Text = "On";
            this.rightOn.UseVisualStyleBackColor = true;
            this.rightOn.CheckedChanged += new System.EventHandler(this.rightOn_CheckedChanged);
            // 
            // rightOff
            // 
            this.rightOff.AutoSize = true;
            this.rightOff.Enabled = false;
            this.rightOff.Location = new System.Drawing.Point(192, 49);
            this.rightOff.Name = "rightOff";
            this.rightOff.OffValue = 0D;
            this.rightOff.OnValue = 1D;
            this.rightOff.ParamName = null;
            this.rightOff.Size = new System.Drawing.Size(39, 16);
            this.rightOff.TabIndex = 1;
            this.rightOff.Text = "Off";
            this.rightOff.UseVisualStyleBackColor = true;
            this.rightOff.CheckedChanged += new System.EventHandler(this.rightOff_CheckedChanged);
            // 
            // leftOne
            // 
            this.leftOne.Location = new System.Drawing.Point(12, 82);
            this.leftOne.Name = "leftOne";
            this.leftOne.Size = new System.Drawing.Size(75, 23);
            this.leftOne.TabIndex = 2;
            this.leftOne.Text = "1";
            this.leftOne.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftOne.UseVisualStyleBackColor = true;
            this.leftOne.Click += new System.EventHandler(this.leftOne_Click);
            // 
            // leftTwo
            // 
            this.leftTwo.Location = new System.Drawing.Point(93, 82);
            this.leftTwo.Name = "leftTwo";
            this.leftTwo.Size = new System.Drawing.Size(75, 23);
            this.leftTwo.TabIndex = 3;
            this.leftTwo.Text = "2";
            this.leftTwo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftTwo.UseVisualStyleBackColor = true;
            this.leftTwo.Click += new System.EventHandler(this.leftTwo_Click);
            // 
            // leftThree
            // 
            this.leftThree.Location = new System.Drawing.Point(12, 111);
            this.leftThree.Name = "leftThree";
            this.leftThree.Size = new System.Drawing.Size(75, 23);
            this.leftThree.TabIndex = 4;
            this.leftThree.Text = "3";
            this.leftThree.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftThree.UseVisualStyleBackColor = true;
            this.leftThree.Click += new System.EventHandler(this.leftThree_Click);
            // 
            // leftFour
            // 
            this.leftFour.Location = new System.Drawing.Point(93, 111);
            this.leftFour.Name = "leftFour";
            this.leftFour.Size = new System.Drawing.Size(75, 23);
            this.leftFour.TabIndex = 5;
            this.leftFour.Text = "4";
            this.leftFour.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftFour.UseVisualStyleBackColor = true;
            this.leftFour.Click += new System.EventHandler(this.leftFour_Click);
            // 
            // leftFive
            // 
            this.leftFive.Location = new System.Drawing.Point(55, 140);
            this.leftFive.Name = "leftFive";
            this.leftFive.Size = new System.Drawing.Size(75, 23);
            this.leftFive.TabIndex = 6;
            this.leftFive.Text = "5";
            this.leftFive.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftFive.UseVisualStyleBackColor = true;
            this.leftFive.Click += new System.EventHandler(this.leftFive_Click);
            // 
            // rightOne
            // 
            this.rightOne.Location = new System.Drawing.Point(191, 83);
            this.rightOne.Name = "rightOne";
            this.rightOne.Size = new System.Drawing.Size(75, 23);
            this.rightOne.TabIndex = 2;
            this.rightOne.Text = "1";
            this.rightOne.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightOne.UseVisualStyleBackColor = true;
            this.rightOne.Click += new System.EventHandler(this.rightOne_Click);
            // 
            // rightTwo
            // 
            this.rightTwo.Location = new System.Drawing.Point(272, 83);
            this.rightTwo.Name = "rightTwo";
            this.rightTwo.Size = new System.Drawing.Size(75, 23);
            this.rightTwo.TabIndex = 3;
            this.rightTwo.Text = "2";
            this.rightTwo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightTwo.UseVisualStyleBackColor = true;
            this.rightTwo.Click += new System.EventHandler(this.rightTwo_Click);
            // 
            // rightThree
            // 
            this.rightThree.Location = new System.Drawing.Point(191, 112);
            this.rightThree.Name = "rightThree";
            this.rightThree.Size = new System.Drawing.Size(75, 23);
            this.rightThree.TabIndex = 4;
            this.rightThree.Text = "3";
            this.rightThree.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightThree.UseVisualStyleBackColor = true;
            this.rightThree.Click += new System.EventHandler(this.rightThree_Click);
            // 
            // rightFour
            // 
            this.rightFour.Location = new System.Drawing.Point(272, 112);
            this.rightFour.Name = "rightFour";
            this.rightFour.Size = new System.Drawing.Size(75, 23);
            this.rightFour.TabIndex = 5;
            this.rightFour.Text = "4";
            this.rightFour.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightFour.UseVisualStyleBackColor = true;
            this.rightFour.Click += new System.EventHandler(this.rightFour_Click);
            // 
            // rightFive
            // 
            this.rightFive.Location = new System.Drawing.Point(234, 141);
            this.rightFive.Name = "rightFive";
            this.rightFive.Size = new System.Drawing.Size(75, 23);
            this.rightFive.TabIndex = 6;
            this.rightFive.Text = "5";
            this.rightFive.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightFive.UseVisualStyleBackColor = true;
            this.rightFive.Click += new System.EventHandler(this.rightFive_Click);
            // 
            // rightAll
            // 
            this.rightAll.Location = new System.Drawing.Point(238, 27);
            this.rightAll.Name = "rightAll";
            this.rightAll.Size = new System.Drawing.Size(109, 38);
            this.rightAll.TabIndex = 6;
            this.rightAll.Text = "모두 (All)";
            this.rightAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightAll.UseVisualStyleBackColor = true;
            this.rightAll.Click += new System.EventHandler(this.rightAll_Click);
            // 
            // leftAll
            // 
            this.leftAll.Location = new System.Drawing.Point(59, 26);
            this.leftAll.Name = "leftAll";
            this.leftAll.Size = new System.Drawing.Size(109, 38);
            this.leftAll.TabIndex = 6;
            this.leftAll.Text = "모두 (All)";
            this.leftAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftAll.UseVisualStyleBackColor = true;
            this.leftAll.Click += new System.EventHandler(this.leftAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left Set of Relays";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(183, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right Set of Relays";
            // 
            // control_multiple_relay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 174);
            this.Controls.Add(this.leftAll);
            this.Controls.Add(this.rightAll);
            this.Controls.Add(this.rightFive);
            this.Controls.Add(this.rightFour);
            this.Controls.Add(this.leftFive);
            this.Controls.Add(this.rightThree);
            this.Controls.Add(this.leftFour);
            this.Controls.Add(this.rightTwo);
            this.Controls.Add(this.leftThree);
            this.Controls.Add(this.rightOne);
            this.Controls.Add(this.leftTwo);
            this.Controls.Add(this.leftOne);
            this.Controls.Add(this.rightOff);
            this.Controls.Add(this.rightOn);
            this.Controls.Add(this.leftOff);
            this.Controls.Add(this.leftOn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "control_multiple_relay";
            this.Text = "Control Multiple Relays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MavlinkCheckBox leftOn;
        private Controls.MavlinkCheckBox leftOff;
        private Controls.MavlinkCheckBox rightOn;
        private Controls.MavlinkCheckBox rightOff;
        private Controls.MyButton leftOne;
        private Controls.MyButton leftTwo;
        private Controls.MyButton leftThree;
        private Controls.MyButton leftFour;
        private Controls.MyButton leftFive;
        private Controls.MyButton rightOne;
        private Controls.MyButton rightTwo;
        private Controls.MyButton rightThree;
        private Controls.MyButton rightFour;
        private Controls.MyButton rightFive;
        private Controls.MyButton rightAll;
        private Controls.MyButton leftAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}