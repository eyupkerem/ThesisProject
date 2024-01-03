using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.instutues
{
    public partial class instutues_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.INSTUTUESTableAdapter instutes = new ThesisProjectDataTableAdapters.INSTUTUESTableAdapter();
            instutes.InstutesDelete(id);
            Response.Redirect("/instutues/instutues_list.aspx");
        }
    }
}