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

namespace Crud_V2.UI
{
    public partial class PR_RoleAuthorization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FilldropdownRoleName();
                FilldropdownCompanyName();
            }
        }
        
        private void FilldropdownRoleName()
        {
            DataTable dt = PR_RoleAuthorizationManager.GetAllPR_RoleAuthorizationInfoBYRoleName();
            dropdownrolename.DataSource = dt;
            dropdownrolename.DataTextField = "RoleName";
            dropdownrolename.DataValueField = "RoleName";
            dropdownrolename.DataBind();
            dropdownrolename.Items.Insert(0, new ListItem("Role Name", "0"));
        }

        private void FilldropdownCompanyName()
        {
            DataTable dt = PR_RoleAuthorizationManager.GetAllPR_RoleAuthorizationInfoBYCompanyName();
            dropdowncompanyname.DataSource = dt;
            dropdowncompanyname.DataTextField = "CompanyName";
            dropdowncompanyname.DataValueField = "CompanyName";
            dropdowncompanyname.DataBind();
            dropdowncompanyname.Items.Insert(0, new ListItem("Company", "0"));
        }

        

        protected void btnInsert_Click(object sender, EventArgs e)
        {           
            PR_RoleAuthorizationDAO objroleAuthorizationDAO = new PR_RoleAuthorizationDAO();
            int result = 0;
            objroleAuthorizationDAO.rolename = dropdownrolename.Text;
            objroleAuthorizationDAO.pageurl = txtpageurl.Text;
            objroleAuthorizationDAO.companyname = dropdowncompanyname.Text;
            objroleAuthorizationDAO.menuname = txtmenuname.Text;

            result = PR_RoleAuthorizationManager.InsertPR_RoleAuthorizationInfo(objroleAuthorizationDAO);
            MessageBox.Show("Successfully Inserted");
        }
    }
}