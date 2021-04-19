using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pertemuan1_51417266
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Bahasa pemrograman yang dipilih : ";
            foreach (ListItem items in CheckBoxList1.Items)
            { 
                if(items.Selected == true) {
                    Label1.Text += items.Text + " ";
                }
            }
        }
    }
}