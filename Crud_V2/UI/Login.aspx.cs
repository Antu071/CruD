using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Crud_V2.DAO;
using Crud_V2.Manager;
using Crud_V2.Gateway;
using System.Windows.Forms;

namespace Crud_V2.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            LoginListDAO objloginListDAO = new LoginListDAO();

            objloginListDAO.username = txtbox_username.Text;
            objloginListDAO.password = txtbox_password.Text;
            DataTable dt = LoginListManager.GetLoginListInfo(objloginListDAO);

            
            if(dt.Rows.Count==1)
            {
                MessageBox.Show("Login Successful");
                Response.Redirect("T_LabourList.aspx");                
            }

            else
            {
                lbl_checkvalidation.Visible = true;
            }            
        }
    }
}