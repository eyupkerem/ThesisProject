using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.instutues
{
    public partial class instutues_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ThesisProjectDataTableAdapters.INSTUTUESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTUTUESTableAdapter();
                string instutueName = instutues.GetInstutue(id)[0].INSTUTUES_NAME;
                txtInstutue.Text = instutueName;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.INSTUTUESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTUTUESTableAdapter();
            instutues.InstutuesUpdate(txtInstutue.Text, id);
            Response.Redirect("/instutues/instutues_list.aspx");

        }
    }
}