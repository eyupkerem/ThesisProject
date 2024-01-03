using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.author
{
    public partial class author_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.AUTHORTableAdapter newAuthor = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();

            //decimal authorPhoneNumber = decimal.Parse(txtAuthorPhoneNumber.Text);
            //newAuthor.AuthorAdd(txtAuthorName.Text, txtAuthorSurname.Text, authorPhonenumber.Text, txtAuthorEmail.Text);
        }
    }
}