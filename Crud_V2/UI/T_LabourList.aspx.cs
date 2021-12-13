using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using Crud_V2.DAO;
using Crud_V2.Manager;
using Crud_V2.Gateway;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Label = System.Web.UI.WebControls.Label;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using CheckBox = System.Web.UI.WebControls.CheckBox;
using System.Drawing;

namespace Crud_V2.UI
{
    public partial class T_LabourList : System.Web.UI.Page
    {
        T_LabourListDAO objT_LabourListDAO = new T_LabourListDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
              
                FillgvVoucherrInfo();
               
            }                      
        }

        protected void btnEmpSave_Click(object sender, EventArgs e)
        {
            T_LabourListDAO objT_LabourListDAO = new T_LabourListDAO();
            int result = 0;
            string employeeid = txtbox_employeeid.Text;
            DataTable dt = T_LabourListManager.GetT_LabourListInfo(employeeid);

            objT_LabourListDAO.employeeid = txtbox_employeeid.Text;
            objT_LabourListDAO.employeename = txtbox_name.Text.Trim();
            objT_LabourListDAO.email = txtbox_mail.Text;
            objT_LabourListDAO.department = txtbox_department.Text;
            objT_LabourListDAO.designation = txtbox_designation.Text;
            objT_LabourListDAO.joining_date = DateTime.Parse(txtbox_join_date.Text);
            objT_LabourListDAO.salary = Convert.ToDecimal(txtbox_salary.Text);

            if (dt.Rows.Count == 0 && objT_LabourListDAO.employeeid != "" && objT_LabourListDAO.employeename != "")
            {
                result = T_LabourListManager.InsertT_LabourListInfo(objT_LabourListDAO);
                MessageBox.Show("Successfully Inserted");
                clear();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please Enter ID and Name Correctly');", true);
            }
            FillgvVoucherrInfo();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            T_LabourListDAO objT_LabourListDAO = new T_LabourListDAO();
            int result = 0;

            string employeeid = txtbox_employeeid.Text;

            DataTable dt = T_LabourListManager.GetT_LabourListInfo(employeeid);
            objT_LabourListDAO.employeeid = txtbox_employeeid.Text;
            objT_LabourListDAO.employeename = txtbox_name.Text.Trim();
            objT_LabourListDAO.email = txtbox_mail.Text;
            objT_LabourListDAO.department = txtbox_department.Text;
            objT_LabourListDAO.designation = txtbox_designation.Text;
            objT_LabourListDAO.joining_date = DateTime.Parse(txtbox_join_date.Text);
            objT_LabourListDAO.salary = Convert.ToDecimal(txtbox_salary.Text);

            if (dt.Rows.Count == 1 && objT_LabourListDAO.employeeid != "" && objT_LabourListDAO.employeename != "")
            {
                result = T_LabourListManager.UpdateT_LabourListInfo(objT_LabourListDAO);
                clear();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please Enter ID and Name Correctly');", true);
            }
            FillgvVoucherrInfo();
        }

        protected void gv_T_LabourInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)gv_T_LabourInfo.Rows[e.RowIndex];

            string employeeid = ((Label)gv_T_LabourInfo.Rows[e.RowIndex].FindControl("lbl_id")).Text;
            T_LabourListManager.DeleteT_LabourListInfo(employeeid);
            FillgvVoucherrInfo();
            clear();
        }

        protected void gv_T_LabourInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gv_T_LabourInfo.SelectedRow;

            txtbox_employeeid.Text = (row.FindControl("lbl_id") as System.Web.UI.WebControls.Label).Text;
            string empid = txtbox_employeeid.Text;
            txtbox_employeeid.Enabled = false;
            DataTable dt = T_LabourListManager.GetT_LabourListInfo(empid);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtbox_name.Text = dt.Rows[i]["EmployeeName"].ToString();
                txtbox_mail.Text = dt.Rows[i]["Email"].ToString();
                txtbox_department.Text = dt.Rows[i]["Department"].ToString();
                txtbox_designation.Text = dt.Rows[i]["Designation"].ToString();
                txtbox_join_date.Text = dt.Rows[i]["Joining_Date"].ToString();
                txtbox_salary.Text = dt.Rows[i]["Salary"].ToString();
            }
        }

        private void FillgvVoucherrInfo()
        {
            DataTable dt = FIN_VoucherTypeManager.GetAllFIN_VoucherTypeInfo();
            voucherGrid.DataSource = dt;
            voucherGrid.DataBind();

            for (int i = 0; i < voucherGrid.Rows.Count; i++)
            {
                GridViewRow row = voucherGrid.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("selectChkBox");
                int id = int.Parse(((Label)voucherGrid.Rows[i].FindControl("lblid")).Text);
                chkbox.Enabled = false;
                if (id % 2 == 0 && rbtnEvenEnable.Checked==true)
                {
                    chkbox.Enabled= true;
                    //voucherGrid.Rows[i].BackColor = Color.Gray;
                }
                else if(id % 2 != 0 && rbtnOddEnable.Checked==true)
                {
                    chkbox.Enabled = true;
                    //voucherGrid.Rows[i].BackColor = Color.LightSkyBlue;
                } 
                else if(rbtnEnableBoth.Checked==true)
                {
                    chkbox.Enabled = true;
                }
            }
        }

        protected void btninsertGrid_Click(object sender, EventArgs e)
        {
            int result = 0;

            FIN_VoucherTypeDAO objfIN_VoucherTypeDAO = new FIN_VoucherTypeDAO();


            for (int i = 0; i < voucherGrid.Rows.Count; i++)
            {
                GridViewRow row = voucherGrid.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("selectChkBox");
                
                if (chkbox.Checked==true)
                { 
                    objfIN_VoucherTypeDAO.vouchername = ((Label)voucherGrid.Rows[i].FindControl("lblVoucherName")).Text;
                    objfIN_VoucherTypeDAO.namebehind = ((Label)voucherGrid.Rows[i].FindControl("lblNameBehind")).Text;
                    objfIN_VoucherTypeDAO.companyname = ((Label)voucherGrid.Rows[i].FindControl("lblCompanyName")).Text;
                    
                    result = FIN_VoucherTypeManager.InsertFIN_VoucherTypeInfo(objfIN_VoucherTypeDAO);
                }

            }
                     
            FillgvVoucherrInfo();
        }

        private void GetAllObjProperties()
        {
            objT_LabourListDAO.employeeid = "";
            objT_LabourListDAO.employeename = "";
            objT_LabourListDAO.email = "";
            objT_LabourListDAO.department = "";
            objT_LabourListDAO.designation = "";
            objT_LabourListDAO.joining_date = DateTime.Parse ("");
            objT_LabourListDAO.salary = Convert.ToDecimal ("");
        }

        void clear()
        {
            txtbox_employeeid.Enabled = true;
            txtbox_employeeid.Text = string.Empty;
            txtbox_name.Text = string.Empty;
            txtbox_mail.Text = string.Empty;
            txtbox_department.Text = string.Empty;
            txtbox_designation.Text = string.Empty;
            txtbox_join_date.Text = string.Empty;
            txtbox_salary.Text = string.Empty;
        }

        protected void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void btn_labourReport_Click(object sender, EventArgs e)
        {
            DataTable dt = T_LabourListManager.GetAllT_LabourListInfo();
           
            ReportDocument reportDocument = new ReportDocument();          
            reportDocument.Load(Server.MapPath("~/Report/LabourReport.rpt"));        
            reportDocument.SetDataSource(dt);

            crviewer.ReportSource = reportDocument;

            MemoryStream ostream = (MemoryStream)reportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);

            reportDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("~/Report/LabourReport.pdf"));
           
            reportDocument.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Labour Information");
            
        }

        protected void btndeleteodd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < voucherGrid.Rows.Count; i++)
            {
                GridViewRow row = voucherGrid.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("selectChkBox");
                int result = 0;
                if (chkbox.Checked == true)
                {                    
                    int id=int.Parse(((Label)voucherGrid.Rows[i].FindControl("lblid")).Text);
                   
                    if (id % 2 != 0)
                    {
                        result = FIN_VoucherTypeManager.DeleteFIN_VoucherTypeByID(id);
                    }
                    else
                    {
                        MessageBox.Show("You Have Selected Even Number");
                    }
                }
            }
            
           FillgvVoucherrInfo();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {          
            FillgvVoucherrInfo();
        }

        protected void rbtnOddEnable_CheckedChanged(object sender, EventArgs e)
        {
            FillgvVoucherrInfo();
        }

        protected void testradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            FillgvVoucherrInfo();
        }
    }
}