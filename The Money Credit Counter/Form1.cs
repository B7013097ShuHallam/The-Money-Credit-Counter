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

        private void credits_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TltValuePound_txtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TtlValuePence_txtbox_TextChanged(object sender, EventArgs e)
        {
           
        }
      

        private void penny_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_Penny;
            amountClick_Penny = Convert.ToInt16(PennyCounter_lbl.Text);
            PennyCounter_lbl.Text = Convert.ToString(amountClick_Penny+1);




            }

        private void twentyPence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_20p;
            amountClick_20p = Convert.ToInt16(twentyPenceCounter_lbl.Text);
            twentyPenceCounter_lbl.Text = Convert.ToString(amountClick_20p + 1);
        }

        private void twoPence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_2p;
            amountClick_2p = Convert.ToInt16(twoPenceCounter_lbl.Text);
            twoPenceCounter_lbl.Text = Convert.ToString(amountClick_2p + 1);
        }

        private void fiftyPence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_50p;
            amountClick_50p = Convert.ToInt16(fifityPenceCounter_lbl.Text);
            fifityPenceCounter_lbl.Text = Convert.ToString(amountClick_50p + 1);
        }

        private void fivePence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_5p;
            amountClick_5p = Convert.ToInt16(fivePenceCounter_lbl.Text);
            fivePenceCounter_lbl.Text = Convert.ToString(amountClick_5p + 1);
        }

        private void onePound_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_1pound;
            amountClick_1pound = Convert.ToInt16(onePoundCounter_lbl.Text);
            onePoundCounter_lbl.Text = Convert.ToString(amountClick_1pound + 1);
        }

        private void tenPence_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_10p;
            amountClick_10p = Convert.ToInt16(tenPenceCounter_lbl.Text);
            tenPenceCounter_lbl.Text = Convert.ToString(amountClick_10p + 1);
        }

        private void twoPound_pctbox_Click(object sender, EventArgs e)
        {
            int amountClick_2pound;
            amountClick_2pound = Convert.ToInt16(twoPoundCounter_lbl.Text);
            twoPoundCounter_lbl.Text = Convert.ToString(amountClick_2pound + 1);
        }
    }

    }
                
                
                
                
        
    

