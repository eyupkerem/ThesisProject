using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ThesisProject.thesis
{
    public partial class thesis_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();
                ThesisProjectDataTableAdapters.SUPERVISORTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORTableAdapter();
                ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
                ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
                ThesisProjectDataTableAdapters.INSTUTUESTableAdapter instute = new ThesisProjectDataTableAdapters.INSTUTUESTableAdapter();
                ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter language = new ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter();
                ThesisProjectDataTableAdapters.TYPES_TableAdapter type = new ThesisProjectDataTableAdapters.TYPES_TableAdapter();
                ThesisProjectDataTableAdapters.KEYWORDSTableAdapter keyword = new ThesisProjectDataTableAdapters.KEYWORDSTableAdapter();


                AuthorList.Items.Clear();
                AuthorList.Items.Add(new ListItem("Choose your Author Lastname"));
                AuthorList.AppendDataBoundItems = true;
                AuthorList.DataSource = author.GetAllAuthors();
                AuthorList.DataTextField = "LASTNAME_";
                AuthorList.DataValueField = "AUTHORID";
                AuthorList.DataBind();



                SupervisorList.Items.Clear();
                SupervisorList.Items.Add(new ListItem("Choose your Supervisor Lastname"));
                SupervisorList.AppendDataBoundItems = true;
                SupervisorList.DataSource = supervisor.GetAllSupervisor();
                SupervisorList.DataTextField = "LASTNAME_";
                SupervisorList.DataValueField = "SUPERVISORID";
                SupervisorList.DataBind();

                CosupervisorList.Items.Clear();
                CosupervisorList.Items.Add(new ListItem("Choose your Cosupervisor Lastname"));
                CosupervisorList.AppendDataBoundItems = true;
                CosupervisorList.DataSource = cosupervisor.GetAllCosupervisor();
                CosupervisorList.DataTextField = "LASTNAME_";
                CosupervisorList.DataValueField = "COSUPERVISORID";
                CosupervisorList.DataBind();


                UnivertyList.Items.Clear();
                UnivertyList.Items.Add(new ListItem("Choose your University"));
                UnivertyList.AppendDataBoundItems = true;
                UnivertyList.DataSource = university.GetAllUniversity();
                UnivertyList.DataTextField = "UNIVERSITY_NAME";
                UnivertyList.DataValueField = "UNIVERSITYID";
                UnivertyList.DataBind();


                InstutuesList.Items.Clear();
                InstutuesList.Items.Add(new ListItem("Choose your Instutue"));
                InstutuesList.AppendDataBoundItems = true;
                InstutuesList.DataSource = instute.GetAllInstutues();
                InstutuesList.DataTextField = "INSTUTUES_NAME";
                InstutuesList.DataValueField = "INSTUTUESID";
                InstutuesList.DataBind();



                LanguageList.Items.Clear();
                LanguageList.Items.Add(new ListItem("Choose your Language"));
                LanguageList.AppendDataBoundItems = true;
                LanguageList.DataSource = language.GetAllLanguages();
                LanguageList.DataTextField = "LANGUAGE_";
                LanguageList.DataValueField = "LANGUAGE_ID";
                LanguageList.DataBind();


                TypeList.Items.Clear();
                TypeList.Items.Add(new ListItem("Choose your Type"));
                TypeList.AppendDataBoundItems = true;
                TypeList.DataSource = type.GetAllTypes();
                TypeList.DataTextField = "TYPES_NAME";
                TypeList.DataValueField = "TYPES_ID";
                TypeList.DataBind();


                KeywordList.Items.Clear();
                KeywordList.Items.Add(new ListItem("Choose your Keyword"));
                KeywordList.AppendDataBoundItems = true;
                KeywordList.DataSource = keyword.GetAllKeywords();
                KeywordList.DataTextField = "KEYWORD_NAME";
                KeywordList.DataValueField = "KEYWORD_ID";
                KeywordList.DataBind();

            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            int authorId = Convert.ToInt32(AuthorList.SelectedItem.Value);
            int supervisorId = Convert.ToInt32(SupervisorList.SelectedItem.Value);
            int cosupervisorId = Convert.ToInt32(CosupervisorList.SelectedItem.Value);
            int universityId = Convert.ToInt32(UnivertyList.SelectedItem.Value);
            int instutueId = Convert.ToInt32(InstutuesList.SelectedItem.Value);
            int languageId = Convert.ToInt32(LanguageList.SelectedItem.Value);
            int typeId = Convert.ToInt32(TypeList.SelectedItem.Value);
            int keywordId = Convert.ToInt32(KeywordList.SelectedItem.Value);

            int PageNumber = Convert.ToInt32(txtPageNum.Text);
            DateTime currentDateTime  = DateTime.Now;
             

            thesis.ThesisAdd(authorId,supervisorId,cosupervisorId,universityId,instutueId,languageId,typeId,keywordId, PageNumber, txtAbstract.Text, TxtYear.Text,currentDateTime);
            Response.Redirect("/thesis/thesis_list.aspx");

            
        }
    }
}