using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.languages
{
    public partial class language_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter language = new ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter();
            language.LanguageAdd(txtLanguage.Text);
            Response.Redirect("/languages/languages_list.aspx");
        }
    }
}