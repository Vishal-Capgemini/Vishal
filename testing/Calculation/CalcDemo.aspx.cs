using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculation
{
    public partial class CalcDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSUm_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirstNO.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = a + b;
            txtResult.Text = c.ToString();
        }

        protected void BtnSUb_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirstNO.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = a - b;
            txtResult.Text = c.ToString();
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirstNO.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = a * b;
            txtResult.Text = c.ToString();
        }
    }
}