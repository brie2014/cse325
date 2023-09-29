using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Sambrano
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            customerNameOutput.Text = deskQuote.CustomerName;
            widthOutput.Text = deskQuote.Desk.Width.ToString();
            depthOutput.Text = deskQuote.Desk.Depth.ToString();
            numOfDrawersOutput.Text = deskQuote.Desk.NumOfDrawers.ToString();
            materialOutput.Text = deskQuote.Desk.Material.ToString();
            rushDaysOutput.Text = deskQuote.RushDays.ToString();
            totalOutput.Text = deskQuote.calculateQuote().ToString();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
