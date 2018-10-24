using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MegaDesk_3_BradRAllen
{
    public partial class SearchQuotes : Form
    {

        private const string QUOTE_FILE = @"qoutes.txt"; //path or location of csv file of quotes
        private int firstChange = 0;
        public SearchQuotes()
        {
            InitializeComponent();
            //build List<T> class to populate the SurfaceMaterial_tb combo box
            List<SurfaceMaterial> surfaceMaterials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            SurfaceMaterial_cb.DataSource = surfaceMaterials;
            SurfaceMaterial_cb.SelectedIndex = -1;
        }

        private void closeForm_btn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        
        //clear list if necessary and then show selected material
        private void SurfaceMaterial_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstChange < 2)
            {
                //selected index gets changed twice before we even see the form...
                firstChange++;
                return;
            }
            else
            {
                try
                {
                    // clear then get the selected material from the combo box
                    SearchResultsListView.Clear();
                    string MaterialSelected = SurfaceMaterial_cb.SelectedItem.ToString();

                    // get qoutes from qoute file
                    if (!File.Exists(QUOTE_FILE))
                    {
                        MessageBox.Show("No qoute file found in the application root", "Error Reading File");
                    }
                    else
                    {
                        //build out the list view
                        SearchResultsListView.Columns.Add("Name", 150, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Date", 180, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Days", 50, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Total", 95, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Width", 50, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Depth", 50, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Drawers", 50, HorizontalAlignment.Center);
                        SearchResultsListView.Columns.Add("Surface", 100, HorizontalAlignment.Center);

                        using (StreamReader sr = new StreamReader(QUOTE_FILE))
                        {

                            while (!sr.EndOfStream)
                            {
                                string[] fieldvalue = sr.ReadLine().Split('|');
                                if (fieldvalue[7] == MaterialSelected)
                                {
                                    SearchResultsListView.Items.Add(new ListViewItem(new[]{
                                    fieldvalue[0], fieldvalue[1], fieldvalue[2], "$"+ fieldvalue[3], fieldvalue[4],
                                    fieldvalue[5], fieldvalue[6], fieldvalue[7]
                                }));
                                }
                            }
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ListView from Quote File." + "\n\n" + ex);
                }
            }
        }
    }
}
