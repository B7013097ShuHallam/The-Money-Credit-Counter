using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Money_Credit_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int percredit;
        int credits;


   
 
        private void penny_pctbox_Click(object sender, EventArgs e)
        {
            int PennyTotalValue_p;
            int amountClick_Penny;
            double PennyTotalValue_pound;

            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_Penny = Convert.ToInt16(PennyCounter_lbl.Text);
                PennyCounter_lbl.Text = Convert.ToString(amountClick_Penny + 1);

                PennyTotalValue_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(PennyTotalValue_p + 1);

                PennyTotalValue_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(PennyTotalValue_pound / 100);

                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();
            }
            






        }

        private void twentyPence_pctbox_Click(object sender, EventArgs e)
        {
            int TotalValue20p_p;
            int amountClick_20p;
            double TotalValue20p_pound;

            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                percredit = Convert.ToInt16(costPerCredit_txtbox.Text);
                amountClick_20p = Convert.ToInt16(twentyPenceCounter_lbl.Text);
                twentyPenceCounter_lbl.Text = Convert.ToString(amountClick_20p + 1);

                TotalValue20p_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue20p_p + 20);

                TotalValue20p_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue20p_pound / 100);

                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();

            }
        }

        private void twoPence_pctbox_Click(object sender, EventArgs e)
        {
       
            int TotalValue2p_p;
            int amountClick_2p;
            double TotalValue2p_pound;
            
            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_2p = Convert.ToInt16(twoPenceCounter_lbl.Text);
                twoPenceCounter_lbl.Text = Convert.ToString(amountClick_2p + 1);

                TotalValue2p_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue2p_p + 2);

                TotalValue2p_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue2p_pound / 100);

                
                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();

            }
        }

        private void fiftyPence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_50p;
            int TotalValue50p_p;
            double TotalValue50p_pound;

            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_50p = Convert.ToInt16(fifityPenceCounter_lbl.Text);
                fifityPenceCounter_lbl.Text = Convert.ToString(amountClick_50p + 1);

                TotalValue50p_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue50p_p + 50);

                TotalValue50p_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue50p_pound / 100);

               
                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();
            }

        }

        private void fivePence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_5p;
            int TotalValue5p_p;
            double TotalValue5p_pound;
        
            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_5p = Convert.ToInt16(fivePenceCounter_lbl.Text);
                fivePenceCounter_lbl.Text = Convert.ToString(amountClick_5p + 1);

                TotalValue5p_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue5p_p + 5);

                TotalValue5p_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue5p_pound / 100);

                
                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();
            }
        }

        private void onePound_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_1pound;
            int TotalValue1pound_p;
            double TotalValue1pound_pound;

            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_1pound = Convert.ToInt16(onePoundCounter_lbl.Text);
                onePoundCounter_lbl.Text = Convert.ToString(amountClick_1pound + 1);

                TotalValue1pound_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue1pound_p + 100);

                TotalValue1pound_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue1pound_pound / 100);

                
                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();
            }
        }

        private void tenPence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_10p;
            int TotalValue10p_p;
            double TotalValue10p_pound;
           
            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_10p = Convert.ToInt16(tenPenceCounter_lbl.Text);
                tenPenceCounter_lbl.Text = Convert.ToString(amountClick_10p + 1);

                TotalValue10p_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue10p_p + 10);

                TotalValue10p_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue10p_pound / 100);

                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();
            }
        }

        private void twoPound_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_2pound;
            int TotalValue2pound_p;
            double TotalValue2pound_pound;
           
            percredit = Convert.ToInt16(costPerCredit_txtbox.Text);

            if (percredit == 0)
            {
                MessageBox.Show("You have not set the cost of the credit!");
            }
            else
            {
                amountClick_2pound = Convert.ToInt16(twoPoundCounter_lbl.Text);
                twoPoundCounter_lbl.Text = Convert.ToString(amountClick_2pound + 1);

                TotalValue2pound_p = Convert.ToInt16(TtlValuePence_txtbox.Text);
                TtlValuePence_txtbox.Text = Convert.ToString(TotalValue2pound_p + 200);

                TotalValue2pound_pound = Convert.ToDouble(TtlValuePence_txtbox.Text);
                TltValuePound_txtbox.Text = Convert.ToString(TotalValue2pound_pound / 100);

                credits = Convert.ToInt16(TtlValuePence_txtbox.Text) / percredit;
                credits_txtbox.Text = credits.ToString();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            TtlValuePence_txtbox.Text="0";
            TltValuePound_txtbox.Text = "0.00";
            costPerCredit_txtbox.Text = "0";
            credits_txtbox.Text = "0";
            PennyCounter_lbl.Text = "0";
            twoPenceCounter_lbl.Text = "0";
            fivePenceCounter_lbl.Text = "0";
            tenPenceCounter_lbl.Text = "0";
            twentyPenceCounter_lbl.Text = "0";
            fifityPenceCounter_lbl.Text = "0";
            fifityPenceCounter_lbl.Text = "0";
            onePoundCounter_lbl.Text = "0";
            twoPoundCounter_lbl.Text = "0";

        }
    }

    }
                
                
                
                
        
    

