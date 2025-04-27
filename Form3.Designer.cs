namespace Final_SignUP
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenToSubmission = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton61 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Question1 = new System.Windows.Forms.GroupBox();
            this.Question2 = new System.Windows.Forms.GroupBox();
            this.Question3 = new System.Windows.Forms.GroupBox();
            this.Question4 = new System.Windows.Forms.GroupBox();
            this.Question6 = new System.Windows.Forms.GroupBox();
            this.Question5 = new System.Windows.Forms.GroupBox();
            this.Question1.SuspendLayout();
            this.Question2.SuspendLayout();
            this.Question3.SuspendLayout();
            this.Question4.SuspendLayout();
            this.Question6.SuspendLayout();
            this.Question5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Selection";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOpenToSubmission
            // 
            this.btnOpenToSubmission.Location = new System.Drawing.Point(397, 634);
            this.btnOpenToSubmission.Name = "btnOpenToSubmission";
            this.btnOpenToSubmission.Size = new System.Drawing.Size(306, 50);
            this.btnOpenToSubmission.TabIndex = 1;
            this.btnOpenToSubmission.Text = "Submit";
            this.btnOpenToSubmission.UseVisualStyleBackColor = true;
            this.btnOpenToSubmission.Click += new System.EventHandler(this.btnOpenToDoList_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "High School ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Associate Degree";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 122);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 24);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bachelor Degree";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 45);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 24);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Part-time";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-Arts and Humanities",
            "Fine Arts",
            "Music",
            "Theatre",
            "Literature",
            "Philosophy",
            "History",
            "Art History",
            "-Business",
            "Business Administration",
            "Marketing",
            "Finance",
            "Accounting",
            "Management",
            "Entrepreneurship",
            "International Business",
            "-Science and Technology",
            "Biology",
            "Chemistry",
            "Physics",
            "Computer Science",
            "Information Technology",
            "Environmental Science",
            "Mathematics",
            "-Health Sciences",
            "Nursing",
            "Public Health",
            "Pharmacy",
            "Physical Therapy",
            "Nutrition",
            "Occupational Therapy",
            "Health Administration",
            "-Social Sciences",
            "Psychology",
            "Sociology",
            "Political Science",
            "Economics",
            "Anthropology",
            "International Relations",
            "Education",
            "-Engineering",
            "Civil Engineering",
            "Mechanical Engineering",
            "Electrical Engineering",
            "Chemical Engineering",
            "Computer Engineering",
            "Aerospace Engineering",
            "-Applied Sciences",
            "Graphic Design",
            "Culinary Arts",
            "Hospitality Management",
            "Interior Design",
            "Fashion Design",
            "Interdisciplinary Studies",
            "Women\'s Studies",
            "Environmental Studies",
            "Ethnic Studies",
            "Global Studies"});
            this.comboBox1.Location = new System.Drawing.Point(32, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "What is your current level of education?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "What are your main interests?(Select all that apply)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "What type of program do you prefer?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Any additional comments?";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(35, 75);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 24);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Full-time";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(35, 102);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 24);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Online";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = " Which subject do you excel in?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "What is your personality type?(Select One)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(461, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "What qualities do you value in a workplace?(Select all that apply)";
            // 
            // radioButton61
            // 
            this.radioButton61.AutoSize = true;
            this.radioButton61.Location = new System.Drawing.Point(6, 76);
            this.radioButton61.Name = "radioButton61";
            this.radioButton61.Size = new System.Drawing.Size(115, 24);
            this.radioButton61.TabIndex = 24;
            this.radioButton61.TabStop = true;
            this.radioButton61.Text = "Extroverted";
            this.radioButton61.UseVisualStyleBackColor = true;
            this.radioButton61.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged_1);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 106);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(111, 24);
            this.radioButton7.TabIndex = 25;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Introverted";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 46);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(96, 24);
            this.radioButton8.TabIndex = 26;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Ambivert";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 136);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(78, 24);
            this.radioButton9.TabIndex = 27;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Other:";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 28;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(10, 45);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(127, 24);
            this.radioButton10.TabIndex = 29;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Collaboration";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(10, 104);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(137, 24);
            this.radioButton11.TabIndex = 30;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Independence";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(10, 134);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(108, 24);
            this.radioButton12.TabIndex = 31;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Innovation";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(10, 164);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(100, 24);
            this.radioButton13.TabIndex = 32;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Structure";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(10, 74);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(93, 24);
            this.radioButton14.TabIndex = 33;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Diversity";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "Literature",
            "Social Studies",
            "Arts",
            "Computer Science",
            "Sports"});
            this.comboBox2.Location = new System.Drawing.Point(32, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 28);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 593);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 26);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Question1
            // 
            this.Question1.BackColor = System.Drawing.Color.Transparent;
            this.Question1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Question1.Controls.Add(this.label3);
            this.Question1.Controls.Add(this.radioButton1);
            this.Question1.Controls.Add(this.radioButton2);
            this.Question1.Controls.Add(this.radioButton3);
            this.Question1.Location = new System.Drawing.Point(29, 62);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(384, 169);
            this.Question1.TabIndex = 36;
            this.Question1.TabStop = false;
            // 
            // Question2
            // 
            this.Question2.Controls.Add(this.label4);
            this.Question2.Controls.Add(this.comboBox2);
            this.Question2.Location = new System.Drawing.Point(29, 236);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(384, 89);
            this.Question2.TabIndex = 37;
            this.Question2.TabStop = false;
            // 
            // Question3
            // 
            this.Question3.Controls.Add(this.label7);
            this.Question3.Controls.Add(this.comboBox1);
            this.Question3.Location = new System.Drawing.Point(29, 331);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(384, 87);
            this.Question3.TabIndex = 35;
            this.Question3.TabStop = false;
            // 
            // Question4
            // 
            this.Question4.Controls.Add(this.label5);
            this.Question4.Controls.Add(this.radioButton4);
            this.Question4.Controls.Add(this.radioButton5);
            this.Question4.Controls.Add(this.radioButton6);
            this.Question4.Location = new System.Drawing.Point(29, 424);
            this.Question4.Name = "Question4";
            this.Question4.Size = new System.Drawing.Size(384, 143);
            this.Question4.TabIndex = 38;
            this.Question4.TabStop = false;
            // 
            // Question6
            // 
            this.Question6.Controls.Add(this.label9);
            this.Question6.Controls.Add(this.radioButton10);
            this.Question6.Controls.Add(this.radioButton14);
            this.Question6.Controls.Add(this.radioButton11);
            this.Question6.Controls.Add(this.radioButton12);
            this.Question6.Controls.Add(this.radioButton13);
            this.Question6.Location = new System.Drawing.Point(493, 297);
            this.Question6.Name = "Question6";
            this.Question6.Size = new System.Drawing.Size(539, 253);
            this.Question6.TabIndex = 39;
            this.Question6.TabStop = false;
            this.Question6.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Question5
            // 
            this.Question5.Controls.Add(this.label8);
            this.Question5.Controls.Add(this.radioButton8);
            this.Question5.Controls.Add(this.radioButton61);
            this.Question5.Controls.Add(this.radioButton7);
            this.Question5.Controls.Add(this.radioButton9);
            this.Question5.Controls.Add(this.textBox3);
            this.Question5.Location = new System.Drawing.Point(500, 78);
            this.Question5.Name = "Question5";
            this.Question5.Size = new System.Drawing.Size(520, 183);
            this.Question5.TabIndex = 40;
            this.Question5.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1219, 696);
            this.Controls.Add(this.Question5);
            this.Controls.Add(this.Question6);
            this.Controls.Add(this.Question4);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOpenToSubmission);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Question1.ResumeLayout(false);
            this.Question1.PerformLayout();
            this.Question2.ResumeLayout(false);
            this.Question2.PerformLayout();
            this.Question3.ResumeLayout(false);
            this.Question3.PerformLayout();
            this.Question4.ResumeLayout(false);
            this.Question4.PerformLayout();
            this.Question6.ResumeLayout(false);
            this.Question6.PerformLayout();
            this.Question5.ResumeLayout(false);
            this.Question5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenToSubmission;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton61;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Question1;
        private System.Windows.Forms.GroupBox Question2;
        private System.Windows.Forms.GroupBox Question3;
        private System.Windows.Forms.GroupBox Question4;
        private System.Windows.Forms.GroupBox Question6;
        private System.Windows.Forms.GroupBox Question5;
    }
}