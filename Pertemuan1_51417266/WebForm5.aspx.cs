using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pertemuan1_51417266
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Bahasa pemrograman yang dipilih : ";
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected == true)
                {
                    Label1.Text += item.Text + " ";
                }
            }
        }
    }
}