using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Crud_V2.DAO;
using Crud_V2.Manager;
using Crud_V2.Gateway;
using System.Windows.Forms;
using Label = System.Web.UI.WebControls.Label;

namespace Crud_V2.UI
{
    public partial class PR_UserInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropdownComapnyName();
                FillDropdownDeptName();
                FillDropdownRole();
                FillDropdownIsActive();
                FillDropdownUserGroup();
                FillDropdownComapnyAccess();
                FillDropdownUserLocation();
                FillDropdownAccessThrough();
            }
        }

        private void FillDropdownAccessThrough()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByAccessThrough();
            dropdownaccessthrough.DataSource = dt;
            dropdownaccessthrough.DataTextField = "AccessThrough";
            dropdownaccessthrough.DataValueField = "AccessThrough";
            dropdownaccessthrough.DataBind();
            dropdownaccessthrough.Items.Insert(0, new ListItem("AccessThrough", "0"));
        }

        private void FillDropdownUserLocation()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByUserLocation();
            dropdownuserlocation.DataSource = dt;
            dropdownuserlocation.DataTextField = "UserLocation";
            dropdownuserlocation.DataValueField = "UserLocation";
            dropdownuserlocation.DataBind();
            dropdownuserlocation.Items.Insert(0, new ListItem("User Location", "0"));
        }

        private void FillDropdownComapnyAccess()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByCompanyAccess();
            dropdowncompanyaccess.DataSource = dt;
            dropdowncompanyaccess.DataTextField = "CompanyAccess";
            dropdowncompanyaccess.DataValueField = "CompanyAccess";
            dropdowncompanyaccess.DataBind();
            dropdowncompanyaccess.Items.Insert(0, new ListItem("Company Access", "0"));
        }

        private void FillDropdownUserGroup()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByUserGroup();
            dropdownusergroup.DataSource = dt;
            dropdownusergroup.DataTextField = "UserGroup";
            dropdownusergroup.DataValueField = "UserGroup";
            dropdownusergroup.DataBind();
            dropdownusergroup.Items.Insert(0, new ListItem("User Group", "0"));
        }

        private void FillDropdownRole()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByRole();
            dropdownrole.DataSource = dt;
            dropdownrole.DataTextField = "Role";
            dropdownrole.DataValueField = "Role";
            dropdownrole.DataBind();
            dropdownrole.Items.Insert(0, new ListItem("Role", "0"));
        }

        private void FillDropdownIsActive()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByIsActive();
            dropdownisactive.DataSource = dt;
            dropdownisactive.DataTextField = "IsActive";
            dropdownisactive.DataValueField = "IsActive";
            dropdownisactive.DataBind();
            dropdownisactive.Items.Insert(0, new ListItem("IsActive", "0"));
        }

        private void FillDropdownDeptName()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoBydeptname();
            dropdowndeptname.DataSource = dt;
            dropdowndeptname.DataTextField = "deptname";
            dropdowndeptname.DataValueField = "deptname";
            dropdowndeptname.DataBind();
            dropdowndeptname.Items.Insert(0, new ListItem("Department Name", "0"));
        }

        private void FillDropdownComapnyName()
        {
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByCompanyName();
            dropdowncompanyname.DataSource = dt;
            dropdowncompanyname.DataTextField = "CompanyName";
            dropdowncompanyname.DataValueField = "CompanyName";
            dropdowncompanyname.DataBind();
            dropdowncompanyname.Items.Insert(0, new ListItem("Company Name", "0"));
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            PR_UserInformationDAO objpR_UserInformation = new PR_UserInformationDAO();
            int result = 0;

            objpR_UserInformation.companyname = dropdowncompanyname.Text;
            objpR_UserInformation.username = txtusername.Text;
            objpR_UserInformation.password = txtpassword.Text;
            objpR_UserInformation.name = txtname.Text;
            objpR_UserInformation.email = txtmail.Text;
            objpR_UserInformation.deptname = dropdowndeptname.Text;
            objpR_UserInformation.role = dropdownrole.Text;
            objpR_UserInformation.isactive = dropdownisactive.Text;
            objpR_UserInformation.shortcode = txtshortcode.Text;
            objpR_UserInformation.profileid = txtprofileid.Text;
            objpR_UserInformation.usergroup = dropdownusergroup.Text;
            objpR_UserInformation.companyaccess = dropdowncompanyaccess.Text;
            objpR_UserInformation.userlocation = dropdownuserlocation.Text;
            objpR_UserInformation.businesstype = txtbusinesstype.Text;
            objpR_UserInformation.foldername = txtfoldername.Text;
            objpR_UserInformation.profileimagename = txtprofileimagename.Text;
            objpR_UserInformation.accessthrough = dropdownaccessthrough.Text;

            string username = txtusername.Text;
            DataTable dt = PR_UserInformationManager.GetAllPR_UserInformationInfoByUsername(username);
            if (dt.Rows.Count == 0)
            {
                result = PR_UserInformationManager.InsertPR_UserInformationInfo(objpR_UserInformation);
                MessageBox.Show("Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Username Already Exist");
            }           
        }
    }
}