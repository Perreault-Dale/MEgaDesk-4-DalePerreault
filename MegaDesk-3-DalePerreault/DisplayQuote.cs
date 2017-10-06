using System;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_4_DalePerreault
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
            this.label1.Text = LabelText();
        }

        public string LabelText()
        {
            string rushCost = File.ReadAllText(@"rushOrderPrices.txt");
            string[] rushSplit = rushCost.Split('\n');
            int[] rushInts = new int[rushSplit.Length];
            for (int i = 0; i < rushSplit.Length; i++)
            {
                rushInts[i] = int.Parse(rushSplit[i]);
            }
            var rushTest = rushInts[0] + ", " + rushInts[1] + ", " + rushInts[2];
            return rushTest;
        }

        private void DisPlayQuote_closing(object sender, FormClosingEventArgs e)
        {
            FormProvider.menu1.Show();
        }
    }
}
