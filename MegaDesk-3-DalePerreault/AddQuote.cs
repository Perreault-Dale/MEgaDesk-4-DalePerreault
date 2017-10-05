using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_4_DalePerreault
{
    public partial class AddQuote : Form
    {
        private static List<DesktopMaterial> materials = new List<DesktopMaterial>();

        public AddQuote()
        {
            foreach (DesktopMaterial dm in Enum.GetValues(typeof(DesktopMaterial)))
            {
                Materials.Add(dm);
            }
            InitializeComponent();
            // var message = string.Join(Environment.NewLine, materials);
            // MessageBox.Show(message);
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
                int draw = Convert.ToInt32(drawTextBox.Text);
                int days;
                if (!rushCheckBox.Checked) { days = Convert.ToInt32(rushComboBox.SelectedValue); } else { days = 14; }
                DesktopMaterial surface = (DesktopMaterial)surfaceComboBox.SelectedValue;
                Deskquote dq = new Deskquote(name, wide, deep, days, draw, surface);
                MessageBox.Show(dq.ToString());
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
    }
}
