using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradRAllen
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_btn_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewQuotes_btn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void searchQuotes_btn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQoutesForm = new SearchQuotes();
            searchQoutesForm.Tag = this;
            searchQoutesForm.Show(this);
            Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //exit program
        }
    }
}
