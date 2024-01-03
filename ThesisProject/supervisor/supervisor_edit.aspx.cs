using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.supervisor
{
    public partial class supervisor_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.SUPERVISORTableAdapter supervisor =  new ThesisProjectDataTableAdapters.SUPERVISORTableAdapter();
            string supervisorName = supervisor.GetSupervisor(id)[0].NAME_;
            string supervisorSurname = supervisor.GetSupervisor(id)[0].LASTNAME_;
            string supervisorPhoneNumber = supervisor.GetSupervisor(id)[0].NUMBER_;
            string supervisorEmail = supervisor.GetSupervisor(id)[0].EMAIL;

            txtSupervisorName.Text = supervisorName;
            txtSupervisorSurname.Text = supervisorSurname;
            txtSupervisorPhoneNumber.Text = supervisorPhoneNumber;
            txtSupervisorEmail.Text = supervisorEmail;

            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.SUPERVISORTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORTableAdapter();
            supervisor.SupervisorUpdate(txtSupervisorName.Text, txtSupervisorSurname.Text, txtSupervisorPhoneNumber.Text, txtSupervisorEmail.Text, id);
            Response.Redirect("/supervisor/supervisor_list.aspx");

        }
    }
}