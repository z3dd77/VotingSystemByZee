using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemByZee
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            opt1TB.Text = "";
            opt2TB.Text = "";
            opt3TB.Text = "";
            opt4TB.Text = "";
            opt5TB.Text = "";
            opt6TB.Text = "";
            pollTitleTB.Text = "";
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void createBTN_Click_1(object sender, EventArgs e)
        {
            // Check if at least two text boxes are filled.
            List<TextBox> textBoxes = new List<TextBox> { opt1TB, opt2TB, opt3TB, opt4TB, opt5TB, opt6TB };
            int filledCount = textBoxes.Count(tb => !string.IsNullOrWhiteSpace(tb.Text));

            if (filledCount < 2)
            {
                MessageBox.Show("Please fill at least two options.");
            }
            else
            {
                // Set the text in the "Vote" form's labels.
                Vote voteForm = new Vote();
                voteForm.opt1Label.Text = opt1TB.Text;
                voteForm.opt2Label.Text = opt2TB.Text;
                voteForm.opt3Label.Text = opt3TB.Text;
                voteForm.opt4Label.Text = opt4TB.Text;
                voteForm.opt5Label.Text = opt5TB.Text;
                voteForm.opt6Label.Text = opt6TB.Text;
                // Add similar lines for the other text boxes.
                voteForm.pollTitleLabel.Text = pollTitleTB.Text;

                // Show the "Vote" form.
                voteForm.ShowDialog();
            }
        }
    }
}

