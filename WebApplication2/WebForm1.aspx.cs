using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application.Lock();
            //Application["Name"] = "小亮";
            //Application.UnLock();
            //Application["Age"] = 13;
            //Response.Write("Application[\"Name\"]的值为;"+Application["Name"].ToString()+"<br>");
            //Response.Write("Application[\"Age\"]的值为;" + Application["Age"].ToString());

            //Label1.Text = "您是该网站的第" + Application["count"].ToString()+ "个访问者";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                Session["nickname"] = TextBox1.Text;
            }
            Response.Redirect("ChatRoom.aspx");
        }
    }
}