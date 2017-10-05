using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_4_DalePerreault
{
    public partial class AddQuote : Form
    {
        static Dictionary<string, DesktopMaterial> dict = new Dictionary<string, DesktopMaterial>
        {
            {"Laminate",DesktopMaterial.Laminate },
            {"Oak",DesktopMaterial.Oak },
            {"Rosewood",DesktopMaterial.Rosewood },
            {"Veneer",DesktopMaterial.Veneer },
            {"Pine",DesktopMaterial.Pine }
        };

        public AddQuote()
        {
            InitializeComponent();
            List<DesktopMaterial> materials = new List<DesktopMaterial>();
            foreach(DesktopMaterial dm in Enum.GetValues(typeof(DesktopMaterial)))
            {
                materials.Add(dm);
            }
            // var message = string.Join(Environment.NewLine, materials);
            // MessageBox.Show(message);
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
                DesktopMaterial surface = dict[surfaceComboBox.SelectedValue.ToString()];
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
