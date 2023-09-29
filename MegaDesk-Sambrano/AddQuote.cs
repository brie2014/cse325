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

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            if (widthInput.Value < 24 || widthInput.Value > 96)
            {
                MessageBox.Show("Width must be between 24 and 96 inches");
                widthInput.Focus();
            }
        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            if (depthInput.Value < 12 || depthInput.Value > 48)
            {
                MessageBox.Show("Depth must be between 12 and 48 inches");
                depthInput.Focus();
            }
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Depth must be a number");
                depthInput.Focus();
            }
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
            deskQuote.RushDays = int.Parse(rushDaysInput.Text);

            // Show the quote screen with the new quote
            DisplayQuote displayQuote = new DisplayQuote(deskQuote);
            displayQuote.Show();
            Close();

        }
    }
}
