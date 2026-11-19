using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloma_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalSales_Danielle = 0;
        private double totalSales_Edward = 0;
        private double totalSales_Fatima = 0;



        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            if (salesInitial == "D")
            {
                totalSales_Danielle += salesAmount;
                lbl_output.Text = $"Updated Total Sales:\nDanielle: ₱{totalSales_Danielle}";
            }
            else if (salesInitial == "E")
            {
                totalSales_Edward += salesAmount;
                lbl_output.Text = $"Updated Total Sales:\nEdward: ₱{totalSales_Edward}";
            }
            else if (salesInitial == "F")
            {
                totalSales_Fatima += salesAmount;
                lbl_output.Text = $"Updated Total Sales:\nFatima: ₱{totalSales_Fatima}";
            }
            else
            {
                lbl_output.Text = "Invalid Sales Person Initial.";
            }
        }
        private void clearEntry()
        {
            textbox_initial.Text = "";
            textbox_amountofsale.Text = "";
            lbl_output.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox_amountofsale.Text, out double saleAmount))
            {
                getSalesPerson_Amount(textbox_initial.Text, saleAmount);
            }
            else
            {
                lbl_output.Text = "Please enter a valid number for the sale amount.";
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                   $"Sales:\n" +
                   $"Danielle: ₱{totalSales_Danielle}\n" +
                   $"Edward: ₱{totalSales_Edward}\n" +
                   $"Fatima: ₱{totalSales_Fatima}\n" +
                   $"Total: ₱{totalSales_Danielle + totalSales_Edward + totalSales_Fatima}"
             );
        }

        private void textbox_initial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_amountofsale_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_salesperson_Click(object sender, EventArgs e)
        {

        }

        private void lbl_amountofsales_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
