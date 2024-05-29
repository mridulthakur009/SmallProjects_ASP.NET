using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text));                   
        }
        protected void Sum_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text));
        }
        protected void Sub_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text));
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text));
        }
    }
}