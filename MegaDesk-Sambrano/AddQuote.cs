using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_Sambrano
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void customerNameInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            if (String.IsNullOrEmpty(customerNameInput.Text))
            {
                validationOutput.Text = "Customer name is required";
                customerNameInput.Focus();
            }
            else validationOutput.Text = "";
        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            if (widthInput.Value < Desk.MINWIDTH|| widthInput.Value > Desk.MAXWIDTH)
            {
                validationOutput.Text = "Width must be between 24 and 96 inches";
                widthInput.Focus();
            }
            else validationOutput.Text = "";
        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            if (depthInput.Value < Desk.MINDEPTH || depthInput.Value > Desk.MAXDEPTH)
            {
                validationOutput.Text = "Depth must be between 12 and 48 inches";
                widthInput.Focus();
            }
            else validationOutput.Text = "";
        }

        private void widthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                validationOutput.Text = "Width must be a number";
                widthInput.Focus();
            }
            else validationOutput.Text = "";
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                validationOutput.Text = "Depth must be a number";
                depthInput.Focus();
            }
            else validationOutput.Text = "";
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            // Create desk with user input
            Desk desk = new Desk();
            desk.Width = (int)widthInput.Value;
            desk.Depth = (int)depthInput.Value;
            desk.NumOfDrawers = (int)numOfDrawersInput.Value;

            DesktopMaterial material;
            Enum.TryParse<DesktopMaterial>(surfaceMaterialInput.Text, out material);
            desk.Material = (DesktopMaterial)material;

            // Create quote with user input
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.CustomerName = customerNameInput.Text;
            deskQuote.Desk = desk;

            // Handle if they didn't put in rush days (optional field)
            try
            {
                deskQuote.ProductionDays = int.Parse(RushDaysInput.Text);
            }
            catch (Exception)
            {
                deskQuote.ProductionDays = 14;
            }
            finally
            {
                // Show the quote screen with the new quote
                DisplayQuote displayQuote = new DisplayQuote(deskQuote);
                displayQuote.Show();
                Close();
            }


        }

        private void mainMenu_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

    }
}
