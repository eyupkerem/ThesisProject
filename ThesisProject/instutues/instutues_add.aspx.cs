using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.instutues
{
    public partial class instutues_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.INSTUTUESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTUTUESTableAdapter();
            instutues.InstutuesAdd(txtInstues.Text);
            Response.Redirect("/instutues/instutues_list.aspx");
        }
    }
}