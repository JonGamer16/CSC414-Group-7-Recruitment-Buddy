using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentBuddyApp
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<string> selectedOptions)
        {
            InitializeComponent();
            DisplayResults(selectedOptions);
        }

        private void DisplayResults(List<string> selectedOptions)
        {
            lblMessage.Text = "Congratulations! We've found a program for you!";
            lblOptions.Text = "Your selections: \n" + string.Join(", ", selectedOptions);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
