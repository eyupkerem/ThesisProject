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
                string authorPhoneNumber = Convert.ToString(author.AuthorGet(id)[0].NUMBER_);
                string authorEmail = author.AuthorGet(id)[0].EMAIL;

                txtAuthorName.Text = authorName;
                txtAuthorSurname.Text = authorLastName;
                txtAuthorPhoneNumber.Text = authorPhoneNumber;
                txtAuthorEmail.Text = authorEmail;


            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();

            decimal authorPhoneNumber = Convert.ToDecimal(txtAuthorPhoneNumber.Text);


            author.AuthorUpdate(txtAuthorName.Text, txtAuthorSurname.Text, authorPhoneNumber, txtAuthorEmail.Text, id);
            Response.Redirect("/author/author_list.aspx");


        }
    }
}