using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_4_DalePerreault
{
    public partial class AddQuote : Form
    {
        private static List<DesktopMaterial> materials = new List<DesktopMaterial>();

        private const int MINWIDTH = 24;
        private const int MAXWIDTH = 96;
        private const int MINDEPTH = 12;
        private const int MAXDEPTH = 48;

        public AddQuote()
        {
            foreach (DesktopMaterial dm in Enum.GetValues(typeof(DesktopMaterial)))
            {
                Materials.Add(dm);
            }
            InitializeComponent();
            surfaceComboBox.DataSource = materials;
        }

        internal static List<DesktopMaterial> Materials { get => materials; set => materials = value; }

        private void cancelButton_click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.menu1.Show();
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
                int draw = Convert.ToInt32(drawComboBox.SelectedItem);
                int days;
                if (rushCheckBox.Checked == true) { days = Convert.ToInt32(rushComboBox.SelectedItem); } else { days = 14; }
                DesktopMaterial surface = (DesktopMaterial)surfaceComboBox.SelectedValue;
                Deskquote dq = new Deskquote(name, days, wide, deep, draw, surface);
                dq.writeQuote();
                MessageBox.Show("Your order submitted successfully. We will complete the order in " + days + " days.", "Order Submitted");
            }
            catch
            {
                MessageBox.Show("There is an error in your submission; try again.", "Submit Failed");
            }
            finally
            {
                this.Close();
                FormProvider.menu1.Show();
            }
        }

        private void WidthTextBox_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int width;
            if (int.TryParse(widthTextBox.Text, out width))
            {
                if (width < MINWIDTH || width > MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width between 24 and 96 inches.", "Validation Error");
                    widthTextBox.Text = string.Empty;
                    widthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a width as a whole number.", "Validation Error");
                widthTextBox.Text = string.Empty;
                widthTextBox.Focus();
            }
        }

        private void DepthTextBox_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int depth;
            if (int.TryParse(depthTextBox.Text, out depth))
            {
                if (depth < MINDEPTH || depth > MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth between 12 and 48 inches.", "Validation Error");
                    depthTextBox.Text = string.Empty;
                    depthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a depth as a whole number.", "Validation Error");
                depthTextBox.Text = string.Empty;
                depthTextBox.Focus();
            }
        }
    }
}
