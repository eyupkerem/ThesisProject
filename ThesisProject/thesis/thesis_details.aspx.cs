using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.thesis
{
    public partial class thesis_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            int id= Convert.ToInt32(Request.QueryString["id"]);
            thesisList.DataSource = thesis.GEtThesis(id);
            thesisList.DataBind();

        }
        public string getAuthorName(int authorId)
        {
            ThesisProjectDataTableAdapters.AUTHORTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORTableAdapter();
            string authorName = " ";
            string authorSurname = " ";
            try
            {
                authorName = author.AuthorGet(authorId)[0].NAME_;
                authorSurname = author.AuthorGet(authorId)[0].LASTNAME_;
            }
            catch
            {
                authorName = "-";
                authorSurname = "-";
            }
            return authorName + " " + authorSurname;
        }
        public string getSupervisorName(int supervisorId)
        {
            ThesisProjectDataTableAdapters.SUPERVISORTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORTableAdapter();
            string supervisorName = " ";
            string supervisorSurname = " ";
            try
            {
                supervisorName = supervisor.GetSupervisor(supervisorId)[0].NAME_;
                supervisorSurname = supervisor.GetSupervisor(supervisorId)[0].LASTNAME_;
            }
            catch
            {
                supervisorName = "-";
                supervisorSurname = "-";
            }
            return supervisorName + " " + supervisorSurname;
        }
        public string getCoSupervisorName(int CoSupervisorId)
        {
            ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
            string CoSupervisorName = " ";
            string CoSupervisorSurname = " ";
            try
            {
                CoSupervisorName = cosupervisor.CosupervisorGet(CoSupervisorId)[0].NAME_;
                CoSupervisorSurname = cosupervisor.CosupervisorGet(CoSupervisorId)[0].LASTNAME_;
            }
            catch
            {
                CoSupervisorName = "-";
                CoSupervisorSurname = "-";
            }
            return CoSupervisorName + " " + CoSupervisorSurname;
        }
        public string getUniversityName(int universityId)
        {
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
            string universityName = " ";
            try
            {
                universityName = university.GetUniversity(universityId)[0].UNIVERSITY_NAME;
            }
            catch
            {
                universityName = "-";
            }
            return universityName;
        }
        public string getInstutes(int instutueId)
        {
            ThesisProjectDataTableAdapters.INSTUTUESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTUTUESTableAdapter();
            string instutue = " ";
            try
            {
                instutue = instutues.GetInstutue(instutueId)[0].INSTUTUES_NAME;
            }
            catch
            {
                instutue = "-";
            }
            return instutue;
        }
        public string getLanguage(int languageId)
        {
            ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter lang = new ThesisProjectDataTableAdapters.LANGUAGES_TableAdapter();
            string language = " ";
            try
            {
                language = lang.GetLanguage(languageId)[0].LANGUAGE_;
            }
            catch
            {
                language = "-";
            }
            return language;
        }
        public string getType(int TypeId)
        {
            ThesisProjectDataTableAdapters.TYPES_TableAdapter types = new ThesisProjectDataTableAdapters.TYPES_TableAdapter();
            string type = " ";
            try
            {
                type = types.GetType(TypeId)[0].TYPES_NAME;

            }
            catch
            {
                type = "-";
            }
            return type;
        }
        public string getKeyword(int keywordId)
        {
            ThesisProjectDataTableAdapters.KEYWORDSTableAdapter key = new ThesisProjectDataTableAdapters.KEYWORDSTableAdapter();
            string keyword = " ";
            try
            {
                keyword = key.GetKeyword(keywordId)[0].KEYWORD_NAME;
            }
            catch
            {
                keyword = "-";
            }
            return keyword;
        }
    }
}