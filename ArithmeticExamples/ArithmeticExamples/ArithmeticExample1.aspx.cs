using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ArithmeticExamples
{
    public partial class ArithmeticExample1 : System.Web.UI.Page
    {
        protected void calculate(object sender, CommandEventArgs e)
        {
            int Num1, Num2, Result = 0;
            Num1 = Convert.ToInt32(txtNum1.Text);
            Num2 = Convert.ToInt32(txtNum2.Text);
            if (e.CommandName.Equals("Add"))
                Result = Num1 + Num2;
            else if (e.CommandName.Equals("Substract"))
                Result = Num1 - Num2;
            else if (e.CommandName.Equals("Multiply"))
                Result = Num1 * Num2;
            else if (e.CommandName.Equals("Divide"))
                Result = Num1 / Num2;
            txtResult.Text = Result.ToString();
        }
    }
}