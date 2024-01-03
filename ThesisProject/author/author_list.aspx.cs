﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.author
{
    public partial class author_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();
            authorList.DataSource = author.GetAllAuthors();
            authorList.DataBind();
        }
    }
}