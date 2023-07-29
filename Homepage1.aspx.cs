using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Homepage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayBox.Text = "";
            }
        }

        protected void displayBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            displayBox.Text = "";
        }

        private void AppendToDisplay(string value)
        {
            displayBox.Text += value;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            AppendToDisplay("1");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            AppendToDisplay("2");
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            AppendToDisplay("3");
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            AppendToDisplay("4");
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            AppendToDisplay("5");
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            AppendToDisplay("6");
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            AppendToDisplay("7");
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            AppendToDisplay("8");
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            AppendToDisplay("9");
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            AppendToDisplay("+");
        }

        protected void btnDot_Click(object sender, EventArgs e)
        {
            AppendToDisplay(".");
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            AppendToDisplay("0");
        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // Evaluate the expression using DataTable.Compute() method
                System.Data.DataTable dataTable = new System.Data.DataTable();
                object result = dataTable.Compute(displayBox.Text, "");
                displayBox.Text = result.ToString();
            }
            catch (Exception)
            {
                // Handle any errors that might occur during evaluation
                displayBox.Text = "Error";
            }
        }


        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            AppendToDisplay("*");
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            AppendToDisplay("-");
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            AppendToDisplay("/");
        }

        protected void btnBackspace_Click(object sender, EventArgs e)
        {
            if (displayBox.Text.Length > 0)
            {
                // Remove the last character from the displayBox.Text
                displayBox.Text = displayBox.Text.Substring(0, displayBox.Text.Length - 1);
            }
        }
    }
}