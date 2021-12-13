using Crud_V2.Manager;
using Crud_V2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_V2.UI
{
    public partial class GridViewInterface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillVoucherGridView();
            }
           
        }

        protected void btnInsertGrid_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvVoucherType.Rows.Count; i++)
            {
               

                GridViewRow row = gvVoucherType.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("slckCheckBox");


                if (chkbox.Checked==true)
                {
                    string hello = "";
                }
            }
        }

        private void FillVoucherGridView()
        {
            DataTable dt = FIN_VoucherTypeManager.GetAllFIN_VoucherTypeInfo();
            gvVoucherType.DataSource = dt;
            gvVoucherType.DataBind();
        }

        protected void testradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            FillVoucherGridView();
        }
    }
}