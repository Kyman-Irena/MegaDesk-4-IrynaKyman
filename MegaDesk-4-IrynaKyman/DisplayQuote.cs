using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_IrynaKyman
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote newQuote;
        public DisplayQuote(DeskQuote newQuote)
        {
            InitializeComponent();
            this.newQuote = newQuote;
            CustomerName.Text = newQuote.CustomerName;
            OrderDate.Text = newQuote.QuoteDate.ToString("dd MMM yyyy");
            DeskWidth.Text = newQuote.Desk.Width.ToString() + " inches";
            DeskDepth.Text = newQuote.Desk.Depth.ToString() + " inches";
        }

        private void GoToMainMenu(object sender, EventArgs e)
        {
            var MainMenuForm = (MainMenu) Tag;
            MainMenuForm.Show();
            Close();

        }
    }
}
