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
using RadioButton = System.Windows.Forms.RadioButton;

namespace VotingSystemByZee
{
    public partial class Vote : Form
    {
        private int[] voteCounts; // Declare the array, no need to initialize here
        public Vote()
        {
            InitializeComponent();
            voteCounts = new int[6]; // An array to store counts for 6 options.
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

            if (selectedRadioButton != null)
            {
                int optionNumber = Convert.ToInt32(selectedRadioButton.Tag) - 1; // Adjust to 0-based index

                // Increment the vote count for the selected option.
                voteCounts[optionNumber]++;
                // Update the result label for the selected option.
                string resultLabelName = "resultLabel" + selectedRadioButton.Tag; // Use the Tag for the label
                Controls.Find(resultLabelName, true)[0].Text = voteCounts[optionNumber].ToString();
            }
            else
            {
                MessageBox.Show("Please select an option.");
            }
        }
    }
}
