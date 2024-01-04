using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.userViews
{
    public partial class user_types_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.TYPES_TableAdapter type = new ThesisProjectDataTableAdapters.TYPES_TableAdapter();
            typeList.DataSource = type.GetAllTypes();
            typeList.DataBind();
        }
    }
}