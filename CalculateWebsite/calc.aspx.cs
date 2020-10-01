using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calc;

public partial class calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
            Response.Write("2nd time visitor.");
    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        try
        {
            Calculator calc = new Calculator(input1.Text, input2.Text);
            double result = calc.Calculate(ddlOps.SelectedValue);
            lblResult.Text = String.Format("Result =  {0}", result.ToString());
        }
        catch (Exception ex)
        {
            lblResult.Text = String.Format("Unable to calculate result , error - {0}", ex.Message);
        }

    }
}