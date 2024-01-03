using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.author
{
    public partial class author_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();
            author.AuthorDelete(id);
            Response.Redirect("/author/author_list.aspx");
        }
    }
}