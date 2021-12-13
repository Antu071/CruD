using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Crud_V2.DAO;
using Crud_V2.Manager;
using CheckBox = System.Web.UI.WebControls.CheckBox;
using Label = System.Web.UI.WebControls.Label;

namespace Crud_V2.UI
{
    public partial class GridWithRadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillGvRadio();
            }
        }

        private void FillGvRadio()
        {
            DataTable dt = FIN_VoucherTypeManager.GetAllFIN_VoucherTypeInfo();
            Gv_Radio.DataSource = dt;
            Gv_Radio.DataBind();

            for (int i = 0; i < Gv_Radio.Rows.Count; i++)
            {
                GridViewRow row = Gv_Radio.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("selectChkBox");
                int id = int.Parse(((Label)Gv_Radio.Rows[i].FindControl("lblid")).Text);
                
                if (id % 2 != 0 && rbtnEven.Checked == true)
                {
                    chkbox.Enabled = false;                   
                }
                else if (id % 2 == 0 && rbtnOdd.Checked == true)
                {
                    chkbox.Enabled = false;                   
                }
                else if (rbtnBoth.Checked == true)
                {
                    chkbox.Enabled = true;
                }
                if(id % 2 == 0)
                {
                    Gv_Radio.Rows[i].BackColor = Color.Gray;
                }
                else
                {
                    Gv_Radio.Rows[i].BackColor = Color.LightSkyBlue;
                }
            }
        }

        protected void rbtnOdd_CheckedChanged(object sender, EventArgs e)
        {
            FillGvRadio();
        }

        protected void rbtnEven_CheckedChanged(object sender, EventArgs e)
        {
            FillGvRadio();
        }

        protected void rbtnBoth_CheckedChanged(object sender, EventArgs e)
        {
            FillGvRadio();
        }

        protected void btnInsertGrid_Click(object sender, EventArgs e)
        {
            int result = 0;

            FIN_VoucherTypeDAO objfIN_VoucherTypeDAO = new FIN_VoucherTypeDAO();


            for (int i = 0; i < Gv_Radio.Rows.Count; i++)
            {
                GridViewRow row = Gv_Radio.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("selectChkBox");

                if (chkbox.Checked == true)
                {
                    objfIN_VoucherTypeDAO.vouchername = ((Label)Gv_Radio.Rows[i].FindControl("lblVoucherName")).Text;
                    objfIN_VoucherTypeDAO.namebehind = ((Label)Gv_Radio.Rows[i].FindControl("lblNameBehind")).Text;
                    objfIN_VoucherTypeDAO.companyname = ((Label)Gv_Radio.Rows[i].FindControl("lblCompanyName")).Text;

                    result = FIN_VoucherTypeManager.InsertFIN_VoucherTypeInfo(objfIN_VoucherTypeDAO);
                }

            }

            FillGvRadio();
        }

        protected void btnOddDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Gv_Radio.Rows.Count; i++)
            {
                GridViewRow row = Gv_Radio.Rows[i];
                CheckBox chkbox = (CheckBox)row.FindControl("selectChkBox");
                int result = 0;
                if (chkbox.Checked == true)
                {
                    int id = int.Parse(((Label)Gv_Radio.Rows[i].FindControl("lblid")).Text);

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

            FillGvRadio();
        }
    }
}