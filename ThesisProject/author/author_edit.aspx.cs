using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.author
{
    public partial class author_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();
                string authorName = author.AuthorGet(id)[0].NAME_;
                string authorLastName = author.AuthorGet(id)[0].LASTNAME_;
                decimal authorPhoneNumber = author.AuthorGet(id)[0].NUMBER_;
                string authorEmail = author.AuthorGet(id)[0].EMAIL;

                txtAuthorName.Text = authorName;
                txtAuthorSurname.Text = authorLastName;
                //Phone Number Operations
                txtAuthorEmail.Text = authorEmail;


            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();
            //author.AuthorUpdate(txtAuthorName.Text, txtAuthorSurname.Text, , txtAuthorEmail.Text, id);  //Phone Number Operations


        }
    }
}