using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.thesis
{
    public partial class thesis_edit : System.Web.UI.Page
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
                ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();


                int id = Convert.ToInt32(Request.QueryString["id"]);
                int pageNum = thesis.GEtThesis(id)[0].PAGENUM;
                string abs = thesis.GEtThesis(id)[0].ABSTRACT;
                DateTime year = thesis.GEtThesis(id)[0].YEAR_;




                authorList.Items.Clear();
                authorList.DataSource = author.GetAllAuthors();
                authorList.Items.Add(new ListItem("Choose your Author Lastname"));
                authorList.AppendDataBoundItems = true;
                authorList.DataTextField = "LASTNAME_";
                authorList.DataValueField = "AUTHORID";
                authorList.DataBind(); 
                authorList.SelectedIndex = 0;




                supervisorList.Items.Clear();
                supervisorList.DataSource = supervisor.GetAllSupervisor();
                supervisorList.Items.Add(new ListItem("Choose your supervisor Lastname"));
                supervisorList.AppendDataBoundItems = true;
                supervisorList.DataTextField = "LASTNAME_";
                supervisorList.DataValueField = "SUPERVISORID";
                supervisorList.DataBind();
                supervisorList.SelectedIndex = 0;


                cosupervisorList.Items.Clear();
                cosupervisorList.DataSource = cosupervisor.GetAllCosupervisor();
                cosupervisorList.Items.Add(new ListItem("Choose your cosupervisor Lastname"));
                cosupervisorList.AppendDataBoundItems = true;
                cosupervisorList.DataTextField = "LASTNAME_";
                cosupervisorList.DataValueField = "COSUPERVISORID";
                cosupervisorList.DataBind();
                cosupervisorList.SelectedIndex = 0;


                universityList.Items.Clear();
                universityList.DataSource = university.GetAllUniversity();
                universityList.Items.Add(new ListItem("Choose your university"));
                universityList.AppendDataBoundItems = true;
                universityList.DataTextField = "UNIVERSITY_NAME";
                universityList.DataValueField = "UNIVERSITYID";
                universityList.DataBind();
                universityList.SelectedIndex = 0;


                instutueList.Items.Clear();
                instutueList.DataSource = instute.GetAllInstutues();
                instutueList.Items.Add(new ListItem("Choose your instute"));
                instutueList.AppendDataBoundItems = true;
                instutueList.DataTextField = "INSTUTUES_NAME";
                instutueList.DataValueField = "INSTUTUESID";
                instutueList.DataBind();
                instutueList.SelectedIndex = 0;

                languageList.Items.Clear();
                languageList.DataSource = language.GetAllLanguages();
                languageList.Items.Add(new ListItem("Choose your language"));
                languageList.AppendDataBoundItems = true;
                languageList.DataTextField = "LANGUAGE_";
                languageList.DataValueField = "LANGUAGE_ID";
                languageList.DataBind();
                languageList.SelectedIndex = 0;


                typeList.Items.Clear();
                typeList.DataSource = type.GetAllTypes();
                typeList.Items.Add(new ListItem("Choose your type"));
                typeList.AppendDataBoundItems = true;
                typeList.DataTextField = "TYPES_NAME";
                typeList.DataValueField = "TYPES_ID";
                typeList.DataBind();
                typeList.SelectedIndex = 0;

                keywordList.Items.Clear();
                keywordList.DataSource = keyword.GetAllKeywords();
                keywordList.Items.Add(new ListItem("Choose your Keyword"));
                keywordList.AppendDataBoundItems = true;
                keywordList.DataTextField = "KEYWORD_NAME";
                keywordList.DataValueField = "KEYWORD_ID";
                keywordList.DataBind();
                keywordList.SelectedIndex = 0;

                string numPage = Convert.ToString(pageNum);
                string loadedYear = Convert.ToString(year);

                txtPageNum.Text = numPage;
                txtAbstract.Text = abs;
                txtYear.Text = loadedYear;



            }



            

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            int thesisID = Convert.ToInt32(Request.QueryString["id"]);
            int authorId = Convert.ToInt32(authorList.SelectedItem.Value); 
            int supervisorId = Convert.ToInt32(supervisorList.SelectedItem.Value); 
            int cosupervisorId = Convert.ToInt32(cosupervisorList.SelectedItem.Value); 
            int universityId = Convert.ToInt32(universityList.SelectedItem.Value); 
            int instutueId = Convert.ToInt32(instutueList.SelectedItem.Value); 
            int languageId = Convert.ToInt32(languageList.SelectedItem.Value); 
            int typeId = Convert.ToInt32(typeList.SelectedItem.Value); 
            int keywordId = Convert.ToInt32(keywordList.SelectedItem.Value);
            DateTime currentDateTime = DateTime.Now;

            int PageNumber = Convert.ToInt32(txtPageNum.Text);


            thesis.ThesisUpdate(authorId,supervisorId,cosupervisorId,universityId,instutueId,languageId,typeId,keywordId, PageNumber,txtAbstract.Text, txtYear.Text,currentDateTime,thesisID);
            Response.Redirect("/thesis/thesis_edit.aspx");

        }
    }
}