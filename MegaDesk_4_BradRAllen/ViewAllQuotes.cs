using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradRAllen
{
    public partial class ViewAllQuotes : Form
    {
        private const string QUOTE_FILE = @"qoutes.txt"; //path or location of csv file of quotes

        public ViewAllQuotes()
        {
            InitializeComponent();
            try
            {
                // clear then get the selected material from the combo box
                allQuotesListView.Clear();

                // get qoutes from qoute file
                if (!File.Exists(QUOTE_FILE))
                {
                    MessageBox.Show("No qoute file found in the application root", "Error Reading File");
                }
                else
                {
                    //build out the list view
                    allQuotesListView.Columns.Add("Name", 150, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Date", 180, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Days", 50, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Total", 95, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Width", 50, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Depth", 50, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Drawers", 50, HorizontalAlignment.Center);
                    allQuotesListView.Columns.Add("Surface", 100, HorizontalAlignment.Center);

                    using (StreamReader sr = new StreamReader(QUOTE_FILE))
                    {

                        while (!sr.EndOfStream)
                        {
                            string[] fieldvalue = sr.ReadLine().Split('|');
                            allQuotesListView.Items.Add(new ListViewItem(new[]{
                                    fieldvalue[0], fieldvalue[1], fieldvalue[2], "$"+ fieldvalue[3], fieldvalue[4],
                                    fieldvalue[5], fieldvalue[6], fieldvalue[7]
                            }));
                         
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ListView from Quote File." + "\n\n" + ex);
            }
        }

    

        private void closeForm_btn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
