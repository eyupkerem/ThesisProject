﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.supervisor
{
    public partial class supervisor_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.SUPERVISORTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORTableAdapter();
            supervisor.SupervisorDelete(id);
            Response.Redirect("/supervisor/supervisor_list.aspx");
        }
    }
}