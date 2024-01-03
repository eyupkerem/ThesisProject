﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject.Cosupervisor
{
    public partial class Cosupervisor_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
                string CosuperviorName = cosupervisor.CosupervisorGet(id)[0].NAME_;
                string CosuperviorLastname = cosupervisor.CosupervisorGet(id)[0].LASTNAME_;
                string CosuperviorNumber = cosupervisor.CosupervisorGet(id)[0].NUMBER_;
                string CosuperviorEmail = cosupervisor.CosupervisorGet(id)[0].EMAIL;

                txtCosupervisorName.Text = CosuperviorName;
                txtCosupervisorSurname.Text = CosuperviorLastname;
                txtCosupervisorPhoneNumber.Text = CosuperviorNumber;
                txtCosupervisorEmail.Text = CosuperviorEmail;

            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
            cosupervisor.CosupervisorUpdate(txtCosupervisorName.Text, txtCosupervisorSurname.Text, txtCosupervisorPhoneNumber.Text, txtCosupervisorEmail.Text, id);
            Response.Redirect("/Cosupervisor/Cosupervisor_list.aspx");

        }
    }
}