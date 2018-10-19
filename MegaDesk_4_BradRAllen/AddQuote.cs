using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class AddQuote : Form
    {
        //declare variables so we can pass them later
        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        int RushDays = 0;
        SurfaceMaterial surfaceMaterial;

        public AddQuote()
        {
            InitializeComponent();
            //build List<T> class to populate the SurfaceMaterial_tb combo box
            List<SurfaceMaterial> surfaceMaterials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            SurfaceMaterial_tb.DataSource = surfaceMaterials;

        }
        private DeskQoute NewQuote;//we'll call the constructor later
        private void closeForm_btn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void FormReset()
        {
            //AddQuote NewQuoteForm = new AddQuote();
            //NewQuoteForm.Tag = this;
            //NewQuoteForm.Show();
            //Close();
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void DeskWidth_tb_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(DeskWidth_tb.Text, out int WidthInput))
            {
                if(WidthInput < Desk.WIDTH_MIN || WidthInput > Desk.WIDTH_MAX)
                {
                    MessageBox.Show(@"Minimum Width is 24"" and Maximum Width is 96"". Please enter a valid Width");
                    DeskWidth_tb.Text = String.Empty;
                    DeskWidth_tb.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter width as a whole number.");
                DeskWidth_tb.Text = string.Empty;
                DeskWidth_tb.Focus();
            }
        }

        private void DeskDepth_tb_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(DeskDepth_tb.Text, out int DepthInput))
            {
                if (DepthInput < Desk.DEPTH_MIN || DepthInput > Desk.DEPTH_MAX)
                {
                    MessageBox.Show(@"Minimum Depth is 12"" and Maximum Depth is 48"". Please enter a valid Depth");
                    DeskDepth_tb.Text = String.Empty;
                    DeskDepth_tb.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter width as a whole number.");
                DeskDepth_tb.Text = string.Empty;
                DeskDepth_tb.Focus();
            }
        }

        private void IsWholeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Please enter a whole number.");
                // Stop the character from being entered into the control by cutting off the rest of the method
                e.Handled = true;
                this.Focus();
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        public void SaveQuoteToCSV (DeskQoute Quote)
        {
            //open file for writting
            using (StreamWriter sw = new StreamWriter("qoutes.txt",append:true))
            {
                string line = "";
                //loop through quote object and get properties. Add text qualifier just for fun (because I want an A)
                foreach (var property in Quote.GetType().GetProperties())
                {
                    line += "\"" + property.GetValue(Quote, null)+ "\",";
                }
                //must loop through desk object for it's properties
                foreach (var property in Quote.Desk.GetType().GetProperties())
                {
                    line += "\"" + property.GetValue(Quote.Desk, null) + "\",";
                }
                sw.WriteLine(line.Remove(line.Length-1));//strip off last , so it is a well formed CSV
            }
        }

        private void generateQuote_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                //collect values
                CustomerName = CustomerName_tb.Text;
                DeskWidth = int.Parse(DeskWidth_tb.Text);
                DeskDepth = int.Parse(DeskDepth_tb.Text);
                Drawers = Decimal.ToInt32(DeskDrawers_tb.Value);
                surfaceMaterial = (SurfaceMaterial)SurfaceMaterial_tb.SelectedValue;
                if (radioButtonStandard.Checked)
                    {
                        RushDays = 14;
                    }
                if (radioButton7Day.Checked)
                {
                    RushDays = 7;
                }
                if (radioButton5Day.Checked)
                {
                    RushDays = 5;
                }
                if (radioButton3Day.Checked)
                {
                    RushDays = 3;
                }

                //now we have our parts so create the qoute object by calling the constructor
                NewQuote = new DeskQoute(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, surfaceMaterial, RushDays);

                //let user know it worked
                MessageBox.Show("New Qoute Successful.\nQuoute total:" + NewQuote.QuoteTotal.ToString("C2"));
            }
            catch (Exception exception)
            {
                Console.WriteLine("Generic Exception Handler: {0}", exception.ToString());
            }

            //save DeskQuote as CSV file
            try
            {
                SaveQuoteToCSV(NewQuote);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //all done, so refresh form
            FormReset(); //not working so just go back to main menu
            
        }
    }
}
