using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG_200_Lab1_PowerBill_Dean_Jones_
{
    //**********************************************************************
    //**********************************************************************

    //POWER BILL CALCULATOR (Lab 1)
    //Author: Dean Jones
    //Date: Nov.23, 2016

    //**********************************************************************
    //**********************************************************************

    public partial class frmMain : Form
    {
        // CONSTANTS (CUSTOMER TYPES)
        const string CUSTOMER_RES = "RES";           //Residential
        const string CUSTOMER_COM = "COM";           //Commercial
        const string CUSTOMER_IND = "IND";           //Industrial

        // CONSTANTS (Flat Rates)($)
        const double FLATRATE_RES = 6.00;           //Residential
        const double FLATRATE_COM = 60.00;          //Commercial
        const double FLATRATE_IND_PEAK = 76.00;     //Industrial(Peak hours)
        const double FLATRATE_IND_OFFPEAK = 40.00;  //Industrial(Off-Peak hours)

        // CONSTANTS (Additional Rates)($ per kWh)
        const double EXTRA_RES = 0.052;             //Residential
        const double EXTRA_COM = 0.045;             //Commercial
        const double EXTRA_IND_PEAK = 0.065;        //Industrial(Peak hours)
        const double EXTRA_IND_OFFPEAK = 0.028;     //Industrial(Off-Peak hours)

        // CONSTANTS (Validation Residential)
        const decimal MIN_POWER_USE_RES = 0;
        const decimal MAX_POWER_USE_RES = 2000.0m;      //based on highest monthly on google.com

        // CONSTANTS (Validation Commercial)
        const decimal MIN_POWER_USE_COM = 0;
        const decimal MAX_POWER_USE_COM = 10000.0m;      //based on my guess that commercial could be way higher

        // CONSTANTS (Validation Industrial)
        const decimal MIN_POWER_USE_IND = 0;
        const decimal MAX_POWER_USE_IND = 50000.0m;      //based on my guess that industrial is the highest

        //MAIN METHOD
        public frmMain()
        {
            InitializeComponent();
            MyInit();
        }

        //INITIALIZATION METHOD (Form)(default to Residential format)
        private void MyInit()
        {
            //load image
            picDisplayImage.Image = Image.FromFile("../../images/residential.jpg");

            //focus to first input
            txtPowerUsage.Focus();

            //message
            lblMessage.Text = "Welcome Residential Customer";
            lblMessage.Visible = true;

            //power usage labels
            lblUsage1.Text = "Power Usage:";

            //hide 2nd power usage labels
            lblUsage2.Visible = false;
            txtPowerUsage2.Visible = false;
            lblKw2.Visible = false;
        }

        //BUTTON CALCULATE (display usage)
        private void btnCalculateUsage_Click(object sender, EventArgs e)
        {
            double resultDisplay;                   //calculation result to display

            if (getCustomerType() == "RES")         //if Residential
            {
                if (IsValidDataRES())
                {
                    //Calculate and display...
                    resultDisplay = CalculateUsageRES(Convert.ToDouble(txtPowerUsage.Text));
                    //Display result as CURRENCY
                    txtDisplayCharge.Text = resultDisplay.ToString("c");
                }
            }
            else if (getCustomerType() == "COM")  //if Commercial
            {
                if (IsValidDataCOM())
                {
                    //Calculate and display...
                    resultDisplay = CalculateUsageCOM(Convert.ToDouble(txtPowerUsage.Text));
                    //Display result as CURRENCY
                    txtDisplayCharge.Text = resultDisplay.ToString("c");
                }
            }
            else if (getCustomerType() == "IND") //if Industrial
            {
                if (IsValidDataIND())
                {
                    //Calculate and display...
                    resultDisplay = CalculateUsageIND(Convert.ToDouble(txtPowerUsage.Text), Convert.ToDouble(txtPowerUsage2.Text));
                    //Display result as CURRENCY
                    txtDisplayCharge.Text = resultDisplay.ToString("c");
                }
            }
        }

        //CALCULATE USAGE (Residential)
        private double CalculateUsageRES(double usage)
        {
            double result;                  //result for residential power use

            //calculation
            result = (usage * EXTRA_RES) + FLATRATE_RES;

            return result;
        }

        //CALCULATE USAGE (Commercial)
        private double CalculateUsageCOM(double usage)
        {           
            double result;                  //result for commercial power use

            //calculation
            if(usage <= 1000.0)             //test for (0 to 1000 kWh)
            {
                result = FLATRATE_COM;      //result is flat rate only if between (0..1000 kWh)
                return result;
            }
            else
            {
                result = ((usage - 1000) * EXTRA_COM) + FLATRATE_COM;   //result is flat rate, plus rate * over 1000 kWh
                return result;
            }

        }

        //CALCULATE USAGE (Industrial)
        private double CalculateUsageIND(double usagePeak, double usageOffPeak)
        {           
            double resultPeak;                      //result for (peak hours) industrial power use
            double resultOffPeak;                   //result for (off-peak hours) industrial power use
            double resultSum;                       //result sum for (peak hours + off-peak hours) industrial power use

            //calculation
            // peak hours calc
            if (usagePeak <= 1000.0)                    //test for (0 to 1000 kWh)
            {
                resultPeak = FLATRATE_IND_PEAK;         //result is flat rate only if between (0..1000 kWh)               
            }
            else
            {
                resultPeak = ((usagePeak - 1000) * EXTRA_IND_PEAK) + FLATRATE_IND_PEAK;   //result is flat rate, plus rate * over 1000 kWh
            }

            // off-peak hours calc
            if (usageOffPeak <= 1000.0)                 //test for (0 to 1000 kWh)
            {
                resultOffPeak = FLATRATE_IND_OFFPEAK;      //result is flat rate only if between (0..1000 kWh)               
            }
            else
            {
                resultOffPeak = ((usageOffPeak - 1000) * EXTRA_IND_OFFPEAK) + FLATRATE_IND_OFFPEAK;   //result is flat rate, plus rate * over 1000 kWh
            }

            // sum of peak and off-peak hours
            resultSum = resultPeak + resultOffPeak;
            return resultSum;
        }

        //VALIDATE TESTS (Residential)
        private bool IsValidDataRES()
        {
            return
                Validator.IsPresent(txtPowerUsage) &&   //(empty textbox)
                Validator.IsDouble(txtPowerUsage) &&    //(input is a double)
                Validator.IsWithinRange(txtPowerUsage, MIN_POWER_USE_RES, MAX_POWER_USE_RES);   //(check range)
        }

        //VALIDATE TESTS (Commercial)
        private bool IsValidDataCOM()
        {
            return
                Validator.IsPresent(txtPowerUsage) &&   //(empty textbox)
                Validator.IsDouble(txtPowerUsage) &&    //(input is a double)
                Validator.IsWithinRange(txtPowerUsage, MIN_POWER_USE_COM, MAX_POWER_USE_COM);   //(check range)
        }

        //VALIDATE TESTS (Industrial)
        private bool IsValidDataIND()
        {
            return
                // check peak hours
                Validator.IsPresent(txtPowerUsage) &&   //(empty textbox)
                Validator.IsDouble(txtPowerUsage) &&    //(input is a double)
                Validator.IsWithinRange(txtPowerUsage, MIN_POWER_USE_IND, MAX_POWER_USE_IND) &&   //(check range)
                // check off-peak hours
                Validator.IsPresent(txtPowerUsage2) &&   //(empty textbox)
                Validator.IsDouble(txtPowerUsage2) &&    //(input is a double)
                Validator.IsWithinRange(txtPowerUsage2, MIN_POWER_USE_IND, MAX_POWER_USE_IND);   //(check range)
        }

        //CHECKS THE CUSTOMER TYPE
        private string getCustomerType ()
        {
            if(radResidential.Checked == true)
            {
                return "RES";
            }
            else if (radCommercial.Checked == true)
            {
                return "COM";
            }
            else if (radIndustrial.Checked == true)
            {
                return "IND";
            }
            else
            {
                //SOMETHING WENT WRONG
                lblMessage.Text = "Something went wrong with getCustomerType";
                return "ERROR";
            }
            
        }

        //RESET FORM
        private void btnReset_Click(object sender, EventArgs e)
        {
            //blank textboxes
            txtPowerUsage.Text = "";
            txtPowerUsage2.Text = "";
            txtDisplayCharge.Text = "";

            //put focus back on input usage
            txtPowerUsage.Focus();

            //default customer is residential
            radResidential.Checked = true;

            //reset message
            lblMessage.Text = "Welcome Residential Customer";
            lblMessage.Visible = true;       //Error Message is off by default
        }

        //EXITS FORM
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //RESIDENTIAL (RADIOBUTTON)(updates form for residential)
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            //blank field if changed
            txtPowerUsage.Text = "";
            txtPowerUsage2.Text = "";

            //load image
            picDisplayImage.Image = Image.FromFile("../../images/residential.jpg");

            //focus to first input
            txtPowerUsage.Focus();

            //update tags (for validation method)
            txtPowerUsage.Tag = "Power Usage";
            txtPowerUsage2.Tag = "Power Usage"; //reset even though it's hidden

            //message
            lblMessage.Text = "Welcome Residential Customer";
            lblMessage.Visible = true;

            //power usage labels
            lblUsage1.Text = "Power Usage:";

            //hide 2nd power usage labels
            lblUsage2.Visible = false;
            txtPowerUsage2.Visible = false;
            lblKw2.Visible = false;
        }

        //COMMERCIAL (RADIOBUTTON)(updates form for commercial)
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            //blank field if changed
            txtPowerUsage.Text = "";
            txtPowerUsage2.Text = "";

            //load image
            picDisplayImage.Image = Image.FromFile("../../images/commercial.png");

            //focus to first input
            txtPowerUsage.Focus();

            //update tags (for validation method)
            txtPowerUsage.Tag = "Power Usage";
            txtPowerUsage2.Tag = "Power Usage"; //reset even though it's hidden

            //message
            lblMessage.Text = "Welcome Commercial Customer";
            lblMessage.Visible = true;

            //power usage labels
            lblUsage1.Text = "Power Usage:";

            //hide 2nd power usage labels
            lblUsage2.Visible = false;
            txtPowerUsage2.Visible = false;
            lblKw2.Visible = false;
        }

        //INDUSTRIAL (RADIOBUTTON)(updates form for industrial)
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            //blank field if changed
            txtPowerUsage.Text = "";
            txtPowerUsage2.Text = "";

            //load image
            picDisplayImage.Image = Image.FromFile("../../images/industrial.jpg");

            //focus to first input
            txtPowerUsage.Focus();

            //update tags (for validation method)
            txtPowerUsage.Tag = "Power Usage(peak)";
            txtPowerUsage2.Tag = "Power Usage(off-peak)";

            //message
            lblMessage.Text = "Welcome Industrial Customer";
            lblMessage.Visible = true;

            //power usage labels
            lblUsage1.Text = "Power Usage(peak):";
            lblUsage2.Text = "Power Usage(off-peak):";

            //show 2nd power usage labels
            lblUsage2.Visible = true;       
            txtPowerUsage2.Visible = true;
            lblKw2.Visible = true;
        }

    }
}
