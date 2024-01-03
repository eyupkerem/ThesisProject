using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.supervisor
{
    public partial class supervisor_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.SUPERVISORTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORTableAdapter();
            supervisorList.DataSource=supervisor.GetAllSupervisor();
            supervisorList.DataBind();

        }
    }
}