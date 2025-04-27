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
            if (radioButton1.Checked) selectedOptions.Add(radioButton1.Text);
            if (radioButton2.Checked) selectedOptions.Add(radioButton2.Text);
            if (radioButton3.Checked) selectedOptions.Add(radioButton3.Text);

            // Collect selected values from GroupBox for Question 2
            if (radioButton4.Checked) selectedOptions.Add(radioButton4.Text);
            if (radioButton5.Checked) selectedOptions.Add(radioButton5.Text);
            if (radioButton6.Checked) selectedOptions.Add(radioButton6.Text);

            // Collect selected values from GroupBox for Question 3
            if (radioButton7.Checked) selectedOptions.Add(radioButton7.Text);
            if (radioButton8.Checked) selectedOptions.Add(radioButton8.Text);
            if (radioButton9.Checked) selectedOptions.Add(radioButton9.Text);
            if (radioButton61.Checked) selectedOptions.Add(radioButton61.Text);

            // Collect selected values from GroupBox for Question 4
            if (radioButton10.Checked) selectedOptions.Add(radioButton10.Text);
            if (radioButton11.Checked) selectedOptions.Add(radioButton11.Text);
            if (radioButton12.Checked) selectedOptions.Add(radioButton12.Text);
            if (radioButton13.Checked) selectedOptions.Add(radioButton13.Text);
            if (radioButton14.Checked) selectedOptions.Add(radioButton14.Text);

            // Collect selected combo box values
            if (comboBox1.SelectedItem != null)
            {
                selectedOptions.Add(comboBox1.SelectedItem.ToString());
            }
            if (comboBox2.SelectedItem != null)
            {
                selectedOptions.Add(comboBox2.SelectedItem.ToString());
            }

            // Collect text box values
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                selectedOptions.Add(textBox1.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                selectedOptions.Add(textBox3.Text);
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
    }
}
