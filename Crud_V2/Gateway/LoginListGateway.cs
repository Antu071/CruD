using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Crud_V2.DAO;
using Crud_V2.Manager;
using Crud_V2.Gateway;

namespace Crud_V2.Gateway
{
	public class LoginListGateway:DBConnector
	{

		internal DataTable GetAllLoginListInfo()
		{
			string query = "Select* From LoginList";
	 	 	return ExecuteQuery(query);
	 	}
		 internal int InsertLoginListInfo(LoginListDAO objLoginListDAO)
		{
			string query = "Insert Into LoginList Values('" + objLoginListDAO.username +"','"+ objLoginListDAO.password+"')";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int UpdateLoginListInfo(LoginListDAO objLoginListDAO)
		{ 
			string query = "Update LoginList Set ColumnName = '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int DeleteLoginListInfo(LoginListDAO objLoginListDAO)
		{ 
			string query = "DELETE from LoginList '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}

		internal DataTable GetLoginListInfo(LoginListDAO objloginListDAO)
		{
			string query = "Select * From LoginList Where username = '"+ objloginListDAO.username + "' and password = '"+objloginListDAO.password+"'";
			return ExecuteQuery(query);
		}
	}
}
