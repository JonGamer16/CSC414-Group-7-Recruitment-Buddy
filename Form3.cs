using RecruitmentBuddyApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Final_SignUP
{
    public partial class Form3 : Form
    {
        private List<string> selectedOptions = new List<string>();
        public Form3()
        {
            InitializeComponent();
     
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void btnOpenToDoList_Click(object sender, EventArgs e)
        {
            // Clear previous selections
            selectedOptions.Clear();
            // Collect selected values from GroupBox for Question 1
            if (radioButton1_1.Checked) selectedOptions.Add(radioButton1_1.Text);
            if (radioButton1_2.Checked) selectedOptions.Add(radioButton1_2.Text);
            if (radioButton1_3.Checked) selectedOptions.Add(radioButton1_3.Text);

            // Collect selected values from GroupBox for Question 2
            if (comboBox2_1.SelectedItem != null)
            { selectedOptions.Add(comboBox2_1.SelectedItem.ToString()); }
            if (comboBox2_2.SelectedItem != null)
            { selectedOptions.Add(comboBox2_2.SelectedItem.ToString()); }
            if (comboBox2_3.SelectedItem != null)
            { selectedOptions.Add(comboBox2_3.SelectedItem.ToString()); }

            // Collect selected values from GroupBox for Question 3
            if (comboBox3_1.SelectedItem != null)
            { selectedOptions.Add(comboBox3_1.SelectedItem.ToString()); }
            if (comboBox3_2.SelectedItem != null)
            { selectedOptions.Add(comboBox3_2.SelectedItem.ToString()); }
            if (comboBox3_3.SelectedItem != null)
            { selectedOptions.Add(comboBox3_3.SelectedItem.ToString()); }

            // Collect selected values from GroupBox for Question 4
            if (checkBox4_1.Checked) selectedOptions.Add(checkBox4_1.Text);
            if (checkBox4_2.Checked) selectedOptions.Add(checkBox4_2.Text);
            if (checkBox4_3.Checked) selectedOptions.Add(checkBox4_3.Text);
            if (checkBox4_4.Checked) selectedOptions.Add(checkBox4_4.Text);
            if (checkBox4_5.Checked) selectedOptions.Add(checkBox4_5.Text);

            // Question 5
            if (radioButton5_1.Checked) selectedOptions.Add(radioButton5_1.Text);
            if (radioButton5_2.Checked) selectedOptions.Add(radioButton5_2.Text);
            if (radioButton5_3.Checked) selectedOptions.Add(radioButton5_3.Text);

            if (radioButton5_4.Checked) selectedOptions.Add(radioButton5_4.Text);
            if (radioButton5_5.Checked) selectedOptions.Add(radioButton5_5.Text);
            if (radioButton5_6.Checked) selectedOptions.Add(radioButton5_6.Text);

            if (radioButton5_7.Checked) selectedOptions.Add(radioButton5_7.Text);
            if (radioButton5_8.Checked) selectedOptions.Add(radioButton5_8.Text);
            if (radioButton5_9.Checked) selectedOptions.Add(radioButton5_9.Text);

            if (radioButton5_10.Checked) selectedOptions.Add(radioButton5_10.Text);
            if (radioButton5_11.Checked) selectedOptions.Add(radioButton5_11.Text);
            if (radioButton5_12.Checked) selectedOptions.Add(radioButton5_12.Text);

            // Question 6
            if (checkBox6_1.Checked) selectedOptions.Add(checkBox6_1.Text);
            if (checkBox6_2.Checked) selectedOptions.Add(checkBox6_2.Text);
            if (checkBox6_3.Checked) selectedOptions.Add(checkBox6_3.Text);
            if (checkBox6_4.Checked) selectedOptions.Add(checkBox6_4.Text);
            if (checkBox6_5.Checked) selectedOptions.Add(checkBox6_5.Text);
            if (checkBox6_6.Checked) selectedOptions.Add(checkBox6_6.Text);
            if (checkBox6_7.Checked) selectedOptions.Add(checkBox6_7.Text);
            if (checkBox6_8.Checked) selectedOptions.Add(checkBox6_8.Text);
            if (checkBox6_9.Checked) selectedOptions.Add(checkBox6_9.Text);
            if (checkBox6_10.Checked) selectedOptions.Add(checkBox6_10.Text);


            // Collect text box values
            if (!string.IsNullOrWhiteSpace(textBox7.Text))
            {
                selectedOptions.Add(textBox7.Text);
            }

            // Create an instance of ResultForm and pass the selected options
            ResultForm resultForm = new ResultForm(selectedOptions);
            resultForm.Show();

            // Optionally, hide the current form
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
