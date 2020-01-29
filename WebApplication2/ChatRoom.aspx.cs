using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ChatRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label_count.Text = "当前在线人数为" + Application["count"].ToString() + "人";
            if (!IsPostBack)
            {
                if (Session["nickname"] != null)
                {
                    Application.Add(Session["nickname"].ToString(), Session["nickname"]);
                }
                textbox_records.Text = Application["content"].ToString();
            }
            listbox_usernames.Items.Clear();
            foreach (string str in Application.Contents)
            {
                if (!str.Equals("content") && !str.Equals("count") && !str.Equals("name"))
                {
                    listbox_usernames.Items.Add(new ListItem(Application[str].ToString(), Application[str].ToString()));
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["nickname"] != null)
            {
                Application["content"] += (Session["nickname"].ToString() + "说：" + textbox_sendmsg.Text + "\n");
                textbox_records.Text = Application["content"].ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application.Remove(Session["nickname"].ToString());
            Application["count"] = (int)Application["count"] - 1;
            Response.Redirect("WebCounter.aspx");
        }
    }
}