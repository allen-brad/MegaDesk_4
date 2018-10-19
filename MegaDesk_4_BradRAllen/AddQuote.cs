using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int DeskQuoteTotal = 0;
        SurfaceMaterial surfaceMaterial;

        public AddQuote()
        {
            InitializeComponent();
            //build List<T> class to populate the SurfaceMaterial_tb combo box
            List<SurfaceMaterial> surfaceMaterials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            SurfaceMaterial_tb.DataSource = surfaceMaterials;

        }
            
        private void closeForm_btn_Click(object sender, EventArgs e)
        {
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
                DeskQoute NewQuote = new DeskQoute(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, surfaceMaterial, RushDays);

                //calculate the qoute total



            }
            catch (Exception)
            {

                throw;
            }
            
            //call the contructor of the DeskQuote

            //calculate the total value 

            //save DeskQuote as CSV file


        }
    }
}
