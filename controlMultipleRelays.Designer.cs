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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftAll = new MissionPlanner.Controls.MyButton();
            this.LeftOnOff = new System.Windows.Forms.GroupBox();
            this.leftOn = new System.Windows.Forms.RadioButton();
            this.leftOff = new System.Windows.Forms.RadioButton();
            this.leftOne = new MissionPlanner.Controls.MyButton();
            this.leftFive = new MissionPlanner.Controls.MyButton();
            this.leftTwo = new MissionPlanner.Controls.MyButton();
            this.leftThree = new MissionPlanner.Controls.MyButton();
            this.leftFour = new MissionPlanner.Controls.MyButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rightOnOff = new System.Windows.Forms.GroupBox();
            this.rightOn = new System.Windows.Forms.RadioButton();
            this.rightOff = new System.Windows.Forms.RadioButton();
            this.rightAll = new MissionPlanner.Controls.MyButton();
            this.rightTwo = new MissionPlanner.Controls.MyButton();
            this.rightOne = new MissionPlanner.Controls.MyButton();
            this.rightFive = new MissionPlanner.Controls.MyButton();
            this.rightThree = new MissionPlanner.Controls.MyButton();
            this.rightFour = new MissionPlanner.Controls.MyButton();
            this.groupBox1.SuspendLayout();
            this.LeftOnOff.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rightOnOff.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leftAll);
            this.groupBox1.Controls.Add(this.LeftOnOff);
            this.groupBox1.Controls.Add(this.leftOne);
            this.groupBox1.Controls.Add(this.leftFive);
            this.groupBox1.Controls.Add(this.leftTwo);
            this.groupBox1.Controls.Add(this.leftThree);
            this.groupBox1.Controls.Add(this.leftFour);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(979, 450);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left";
            // 
            // leftAll
            // 
            this.leftAll.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftAll.Location = new System.Drawing.Point(404, 46);
            this.leftAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftAll.Name = "leftAll";
            this.leftAll.Size = new System.Drawing.Size(541, 164);
            this.leftAll.TabIndex = 6;
            this.leftAll.Text = "Select All";
            this.leftAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftAll.UseVisualStyleBackColor = true;
            this.leftAll.Click += new System.EventHandler(this.leftAll_Click);
            // 
            // LeftOnOff
            // 
            this.LeftOnOff.Controls.Add(this.leftOn);
            this.LeftOnOff.Controls.Add(this.leftOff);
            this.LeftOnOff.Location = new System.Drawing.Point(19, 30);
            this.LeftOnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftOnOff.Name = "LeftOnOff";
            this.LeftOnOff.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftOnOff.Size = new System.Drawing.Size(353, 182);
            this.LeftOnOff.TabIndex = 9;
            this.LeftOnOff.TabStop = false;
            // 
            // leftOn
            // 
            this.leftOn.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftOn.Location = new System.Drawing.Point(26, 18);
            this.leftOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftOn.Name = "leftOn";
            this.leftOn.Size = new System.Drawing.Size(281, 58);
            this.leftOn.TabIndex = 0;
            this.leftOn.TabStop = true;
            this.leftOn.Text = "Launch";
            this.leftOn.UseVisualStyleBackColor = true;
            this.leftOn.CheckedChanged += new System.EventHandler(this.leftOn_CheckedChanged);
            // 
            // leftOff
            // 
            this.leftOff.Checked = true;
            this.leftOff.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftOff.Location = new System.Drawing.Point(26, 114);
            this.leftOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftOff.Name = "leftOff";
            this.leftOff.Size = new System.Drawing.Size(209, 58);
            this.leftOff.TabIndex = 0;
            this.leftOff.TabStop = true;
            this.leftOff.Text = "Reset";
            this.leftOff.UseVisualStyleBackColor = true;
            this.leftOff.CheckedChanged += new System.EventHandler(this.leftOff_CheckedChanged);
            // 
            // leftOne
            // 
            this.leftOne.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftOne.Location = new System.Drawing.Point(19, 238);
            this.leftOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftOne.Name = "leftOne";
            this.leftOne.Size = new System.Drawing.Size(160, 164);
            this.leftOne.TabIndex = 2;
            this.leftOne.Text = "1";
            this.leftOne.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftOne.UseVisualStyleBackColor = true;
            this.leftOne.Click += new System.EventHandler(this.leftOne_Click);
            // 
            // leftFive
            // 
            this.leftFive.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftFive.Location = new System.Drawing.Point(786, 238);
            this.leftFive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftFive.Name = "leftFive";
            this.leftFive.Size = new System.Drawing.Size(160, 164);
            this.leftFive.TabIndex = 6;
            this.leftFive.Text = "5";
            this.leftFive.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftFive.UseVisualStyleBackColor = true;
            this.leftFive.Click += new System.EventHandler(this.leftFive_Click);
            // 
            // leftTwo
            // 
            this.leftTwo.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftTwo.Location = new System.Drawing.Point(211, 238);
            this.leftTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftTwo.Name = "leftTwo";
            this.leftTwo.Size = new System.Drawing.Size(160, 164);
            this.leftTwo.TabIndex = 3;
            this.leftTwo.Text = "2";
            this.leftTwo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftTwo.UseVisualStyleBackColor = true;
            this.leftTwo.Click += new System.EventHandler(this.leftTwo_Click);
            // 
            // leftThree
            // 
            this.leftThree.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftThree.Location = new System.Drawing.Point(404, 238);
            this.leftThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftThree.Name = "leftThree";
            this.leftThree.Size = new System.Drawing.Size(160, 164);
            this.leftThree.TabIndex = 4;
            this.leftThree.Text = "3";
            this.leftThree.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftThree.UseVisualStyleBackColor = true;
            this.leftThree.Click += new System.EventHandler(this.leftThree_Click);
            // 
            // leftFour
            // 
            this.leftFour.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftFour.Location = new System.Drawing.Point(593, 238);
            this.leftFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftFour.Name = "leftFour";
            this.leftFour.Size = new System.Drawing.Size(160, 164);
            this.leftFour.TabIndex = 5;
            this.leftFour.Text = "4";
            this.leftFour.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftFour.UseVisualStyleBackColor = true;
            this.leftFour.Click += new System.EventHandler(this.leftFour_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rightOnOff);
            this.groupBox2.Controls.Add(this.rightAll);
            this.groupBox2.Controls.Add(this.rightTwo);
            this.groupBox2.Controls.Add(this.rightOne);
            this.groupBox2.Controls.Add(this.rightFive);
            this.groupBox2.Controls.Add(this.rightThree);
            this.groupBox2.Controls.Add(this.rightFour);
            this.groupBox2.Location = new System.Drawing.Point(1004, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(969, 450);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right";
            // 
            // rightOnOff
            // 
            this.rightOnOff.Controls.Add(this.rightOn);
            this.rightOnOff.Controls.Add(this.rightOff);
            this.rightOnOff.Location = new System.Drawing.Point(20, 30);
            this.rightOnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightOnOff.Name = "rightOnOff";
            this.rightOnOff.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightOnOff.Size = new System.Drawing.Size(350, 182);
            this.rightOnOff.TabIndex = 10;
            this.rightOnOff.TabStop = false;
            // 
            // rightOn
            // 
            this.rightOn.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightOn.Location = new System.Drawing.Point(21, 18);
            this.rightOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightOn.Name = "rightOn";
            this.rightOn.Size = new System.Drawing.Size(243, 58);
            this.rightOn.TabIndex = 0;
            this.rightOn.TabStop = true;
            this.rightOn.Text = "Launch";
            this.rightOn.UseVisualStyleBackColor = true;
            this.rightOn.CheckedChanged += new System.EventHandler(this.rightOn_CheckedChanged);
            // 
            // rightOff
            // 
            this.rightOff.Checked = true;
            this.rightOff.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightOff.Location = new System.Drawing.Point(21, 114);
            this.rightOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightOff.Name = "rightOff";
            this.rightOff.Size = new System.Drawing.Size(199, 58);
            this.rightOff.TabIndex = 0;
            this.rightOff.TabStop = true;
            this.rightOff.Text = "Reset";
            this.rightOff.UseVisualStyleBackColor = true;
            this.rightOff.CheckedChanged += new System.EventHandler(this.rightOff_CheckedChanged);
            // 
            // rightAll
            // 
            this.rightAll.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightAll.Location = new System.Drawing.Point(403, 48);
            this.rightAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightAll.Name = "rightAll";
            this.rightAll.Size = new System.Drawing.Size(541, 164);
            this.rightAll.TabIndex = 6;
            this.rightAll.Text = "Select All";
            this.rightAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightAll.UseVisualStyleBackColor = true;
            this.rightAll.Click += new System.EventHandler(this.rightAll_Click);
            // 
            // rightTwo
            // 
            this.rightTwo.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightTwo.Location = new System.Drawing.Point(210, 238);
            this.rightTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightTwo.Name = "rightTwo";
            this.rightTwo.Size = new System.Drawing.Size(160, 164);
            this.rightTwo.TabIndex = 3;
            this.rightTwo.Text = "2";
            this.rightTwo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightTwo.UseVisualStyleBackColor = true;
            this.rightTwo.Click += new System.EventHandler(this.rightTwo_Click);
            // 
            // rightOne
            // 
            this.rightOne.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightOne.Location = new System.Drawing.Point(20, 238);
            this.rightOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightOne.Name = "rightOne";
            this.rightOne.Size = new System.Drawing.Size(160, 164);
            this.rightOne.TabIndex = 2;
            this.rightOne.Text = "1";
            this.rightOne.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightOne.UseVisualStyleBackColor = true;
            this.rightOne.Click += new System.EventHandler(this.rightOne_Click);
            // 
            // rightFive
            // 
            this.rightFive.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightFive.Location = new System.Drawing.Point(784, 238);
            this.rightFive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightFive.Name = "rightFive";
            this.rightFive.Size = new System.Drawing.Size(160, 164);
            this.rightFive.TabIndex = 6;
            this.rightFive.Text = "5";
            this.rightFive.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightFive.UseVisualStyleBackColor = true;
            this.rightFive.Click += new System.EventHandler(this.rightFive_Click);
            // 
            // rightThree
            // 
            this.rightThree.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightThree.Location = new System.Drawing.Point(403, 238);
            this.rightThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightThree.Name = "rightThree";
            this.rightThree.Size = new System.Drawing.Size(160, 164);
            this.rightThree.TabIndex = 4;
            this.rightThree.Text = "3";
            this.rightThree.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightThree.UseVisualStyleBackColor = true;
            this.rightThree.Click += new System.EventHandler(this.rightThree_Click);
            // 
            // rightFour
            // 
            this.rightFour.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightFour.Location = new System.Drawing.Point(591, 238);
            this.rightFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightFour.Name = "rightFour";
            this.rightFour.Size = new System.Drawing.Size(160, 164);
            this.rightFour.TabIndex = 5;
            this.rightFour.Text = "4";
            this.rightFour.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightFour.UseVisualStyleBackColor = true;
            this.rightFour.Click += new System.EventHandler(this.rightFour_Click);
            // 
            // controlMultipleRelays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1981, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "controlMultipleRelays";
            this.Text = "Control Multiple Relays";
            this.groupBox1.ResumeLayout(false);
            this.LeftOnOff.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.rightOnOff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.RadioButton leftOff;
        private System.Windows.Forms.RadioButton leftOn;
        private System.Windows.Forms.RadioButton rightOff;
        private System.Windows.Forms.RadioButton rightOn;
        private System.Windows.Forms.GroupBox LeftOnOff;
        private System.Windows.Forms.GroupBox rightOnOff;
    }
}