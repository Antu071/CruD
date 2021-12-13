using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Crud_V2.DAO;
using Crud_V2.Gateway;

namespace Crud_V2.Gateway
{
	public class PR_RoleAuthorizationGateway:DBConnector
	{

		internal DataTable GetAllPR_RoleAuthorizationInfo()
		{
			string query = "Select * From PR_RoleAuthorization";
	 	 	return ExecuteQuery(query);
	 	}

		internal DataTable GetAllPR_RoleAuthorizationInfoBYRoleName()
        {
			string query = "Select DISTINCT RoleName From PR_RoleAuthorization Where RoleName IS NOT NULL ORDER BY RoleName ";
			return ExecuteQuery(query);
		}
		internal DataTable GetAllPR_RoleAuthorizationInfoBYCompanyName()
		{
			string query = "Select DISTINCT CompanyName From PR_RoleAuthorization Where CompanyName IS NOT NULL ORDER BY CompanyName";
			return ExecuteQuery(query);
		}
		
		internal int InsertPR_RoleAuthorizationInfo(PR_RoleAuthorizationDAO objPR_RoleAuthorizationDAO)
		{
			string query = "Insert Into PR_RoleAuthorization Values('" + objPR_RoleAuthorizationDAO.rolename +"','"+ objPR_RoleAuthorizationDAO.pageurl +"','"+ objPR_RoleAuthorizationDAO.companyname +"','"+ objPR_RoleAuthorizationDAO.menuname+"')";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int UpdatePR_RoleAuthorizationInfo(PR_RoleAuthorizationDAO objPR_RoleAuthorizationDAO)
		{ 
			string query = "Update PR_RoleAuthorization Set ColumnName = '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int DeletePR_RoleAuthorizationInfo(PR_RoleAuthorizationDAO objPR_RoleAuthorizationDAO)
		{ 
			string query = "DELETE from PR_RoleAuthorization '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}
	}
}
