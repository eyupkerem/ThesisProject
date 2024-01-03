﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.languages
{
    public partial class languages_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);    
            ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter language = new ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter();
            language.LanguageDelete(id);
            Response.Redirect("/languages/languages_list.aspx");
        }
    }
}