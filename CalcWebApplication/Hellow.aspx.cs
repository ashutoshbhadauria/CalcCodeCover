using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingWebApp
{
    public partial class Hellow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
                Response.Write("2nd time visitor.");
        }

        protected void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                String ops = ddlOps.SelectedValue;
                int result = 0;
                int number1 = int.Parse(input1.Text);
                int number2 = int.Parse(input2.Text);
                switch (ops)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    default:
                        break;
                }
                lblResult.Text = String.Format("Result =  {0}" , result.ToString());
            }
            catch (Exception ex)
            {
                lblResult.Text = String.Format("Unable to calculate result , error - {0}", ex.Message);   
            }
            
        }
    }
}