/*
 * Author: Nevil Patel, 000892482
 * Date: October 15, 2023
 * Purpose : This Class contains all the required logical formula of the form and design accordingly and it is also 
 *           created to fullfill all the requirements for the Lab2 Hair Salon Application.
 */

using System;
using System.Windows.Forms;

namespace Lab2b
{
    /// <summary>
    /// The Main Form Class called HairSalon containing all the required logic of application according to the Button and Textbox.
    /// </summary>
    public partial class HairSalon : Form
    {
        /// <summary>
        /// Initializing the Form Component.
        /// Calculate Button is by-default selected.
        /// </summary>
        public HairSalon()
        {
            InitializeComponent();
            this.AcceptButton = CalculateBtn;
        }

        /// <summary>
        /// Event Handler Method for the Client Label with no logic in it.
        /// </summary>
        /// <param name="sender">No Value Passed</param>
        /// <param name="e">No Value Passed</param>
        private void ClientLabel_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Event Handler Method for the Exit Button with help of Click Event.
        /// </summary>
        /// <param name="sender">No Value Passed</param>
        /// <param name="e">No Value Passed</param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event Handler Method for the Client textbox with no logic in it.
        /// </summary>
        /// <param name="sender">No Value Passed</param>
        /// <param name="e">No Value Passed</param>
        private void ClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event Handler Method for the Clear Button with help of Click Event.
        /// It clear all the Button and Textbox values and reset to by-default selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Jane.Checked = true;
            Cut.Checked = Colour.Checked = Highlights.Checked = Extensions.Checked = false;
            Adult.Checked = true;
            ClientTextBox.Text = string.Empty;
            PriceOutput.Text = string.Empty;
        }


        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // All variables are assigned to store values of rates and discounts.
            decimal hairArtistRate = 0;
            decimal serviceRate = 0;
            decimal clientDiscount = 0;

            if (!(Cut.Checked || Colour.Checked || Highlights.Checked || Extensions.Checked))
            {
                MessageBox.Show("You have to select atleast one service.");
                return;
            }

            if (int.TryParse(ClientTextBox.Text, out int numVisits) && numVisits >= 0)
            {
                // Store the values of Hair Artist Rate as per Radio Button Click
                if (Jane.Checked)
                    hairArtistRate = 30;
                else if (Pat.Checked)
                    hairArtistRate = 45;
                else if (Ron.Checked)
                    hairArtistRate = 40;
                else if (Sue.Checked)
                    hairArtistRate = 50;
                else if (Laura.Checked)
                    hairArtistRate = 55;

                // Store the values of multiple Services price as per CheckBox Button Click
                if (Cut.Checked)
                    serviceRate += 30;
                if (Colour.Checked)
                    serviceRate += 40;
                if (Highlights.Checked)
                    serviceRate += 50;
                if (Extensions.Checked)
                    serviceRate += 200;

                // Store the values of all the discount as per Radio Button Click
                if (Adult.Checked)
                    clientDiscount = 0; // No Discount
                else if (Student.Checked)
                    clientDiscount = 0.05M; // For the 5% Discount
                else if (Child.Checked)
                    clientDiscount = 0.1M; // For the 10% Discount
                else if (Senior.Checked)
                    clientDiscount = 0.15M; // For the 15% Discount

                // Additional discount according to the number of visits
                if (numVisits >= 1 && numVisits <= 3)
                    clientDiscount += 0; // No Discount
                else if (numVisits >= 4 && numVisits <= 8)
                    clientDiscount += 0.05M; // For the 5% Discount
                else if (numVisits >= 9 && numVisits <= 13)
                    clientDiscount += 0.1M; // For the 10% Discount
                else
                    clientDiscount += 0.15M; // For the 15% Discount

                // Calculate the total price after deducting the discount
                decimal totalPrice = hairArtistRate + serviceRate;
                totalPrice -= totalPrice * clientDiscount;

                // Display the Total Price in Label
                PriceOutput.Text = $"{totalPrice:C2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid postive number greater than 0.");
            }
        }
    }
}
