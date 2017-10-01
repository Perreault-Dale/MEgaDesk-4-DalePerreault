using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_3_DalePerreault
{
    public partial class AddQuote : Form
    {
        static Dictionary<string, Surface> dict = new Dictionary<string, Surface>
        {
            {"Laminate",Surface.Laminate },
            {"Oak",Surface.Oak },
            {"Rosewood",Surface.Rosewood },
            {"Veneer",Surface.Veneer },
            {"Pine",Surface.Pine }
        };

        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelButton_click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void rusCheckBox_click(object sender, EventArgs e)
        {
            if (rushCheckBox.Checked) { rushComboBox.Enabled = true; }
            else { rushComboBox.Enabled = false; }
        }

        private void submitButton_click(object sender, EventArgs e)
        {
            try
            {
                string name = custNameBox.Text;
                int wide = Convert.ToInt32(widthTextBox.Text);
                int deep = Convert.ToInt32(depthTextBox.Text);
                int draw = Convert.ToInt32(drawTextBox.Text);
                int days;
                if (!rushCheckBox.Checked) { days = Convert.ToInt32(rushComboBox.SelectedValue); } else { days = 14; }
                Surface surface = dict[surfaceComboBox.SelectedValue.ToString()];
                Deskquote dq = new Deskquote(name, wide, deep, days, draw, surface);
                dq.writeQuote();
                MessageBox.Show("Your order submitted successfully. We will complete the order in " + days + " days.", "Order Submitted");
            }
            catch
            {
                MessageBox.Show("There is an error in your submission; try again.", "Submit Failed");
            }
            finally
            {
                MainMenu main = new MainMenu();
                main.Show();
                this.Close();
            }
        }
    }
}
