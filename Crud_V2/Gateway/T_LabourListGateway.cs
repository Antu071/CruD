using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Crud_V2.DAO;
using Crud_V2.Manager;

namespace Crud_V2.Gateway
{
	public class T_LabourListGateway : DBConnector
	{

		internal DataTable GetAllT_LabourListInfo()
		{
			string query = "Select* From T_LabourList";
	 	 	return ExecuteQuery(query);
	 	}
		 internal int InsertT_LabourListInfo(T_LabourListDAO objT_LabourListDAO)
		{
			string query = "Insert Into T_LabourList Values('" + objT_LabourListDAO.employeeid +"','"+ objT_LabourListDAO.employeename +"','"+ objT_LabourListDAO.email +"','"+ objT_LabourListDAO.department +"','"+ objT_LabourListDAO.designation +"','"+ objT_LabourListDAO.joining_date +"','"+ objT_LabourListDAO.salary+"')";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int UpdateT_LabourListInfo(T_LabourListDAO objT_LabourListDAO)
		{ 
			string query = "Update T_LabourList Set Employeename='" + objT_LabourListDAO.employeename + "',Email='" + objT_LabourListDAO.email + "',Department='" + objT_LabourListDAO.department + "',Designation='" + objT_LabourListDAO.designation + "',Joining_Date='" + objT_LabourListDAO.joining_date + "',Salary='" + objT_LabourListDAO.salary + "' where EmployeeID='" + objT_LabourListDAO.employeeid + "' ";
			return ExecuteNonQuery(query);
	 	}

        internal DataTable GetT_LabourListInfo(string employeeid)
        {
			string query = "Select * From T_LabourList Where EmployeeID='" + employeeid + "'";
			return ExecuteQuery(query);
		}

		internal void DeleteT_LabourListInfo(string employeeid)
		{
			string query = "Delete From T_LabourList Where EmployeeID='" + employeeid + "'";
			ExecuteQuery(query);
		}
	}
}
