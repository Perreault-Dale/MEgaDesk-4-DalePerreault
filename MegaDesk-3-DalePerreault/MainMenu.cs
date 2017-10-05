using System;
using System.Windows.Forms;

namespace MegaDesk_4_DalePerreault
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteClick(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
            this.Hide();
        }

        private void viewQuoteClick(object sender, EventArgs e)
        {
            DisplayQuote viewQuoteForm = new DisplayQuote();
            viewQuoteForm.Show();
            this.Hide();
        }

        private void searchQuoteClick(object sender, EventArgs e)
        {
            SearchQuotes searchQuoteForm = new SearchQuotes();
            searchQuoteForm.Show();
            this.Hide();
        }

        private void exitApp(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
