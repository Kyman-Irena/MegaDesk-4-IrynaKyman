using System;
using System.Windows.Forms;


namespace MegaDesk_4_IrynaKyman
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
         }
        private void button1_Click(object sender, EventArgs e)
        {
            var MainMenuForm = (MainMenu)Tag;
            MainMenuForm.Show();
            Close();
        }

               
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
           if (int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("The width of the desk should be more than 24 and less than 96 inches");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.Focus();

                }
            }   
        }

        private void WidthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("The width of the desk should be more than 24 and less than 96 inches");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.Focus();

                }
                else
                { }
            }
        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

    }

}
