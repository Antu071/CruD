using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Crud_V2.DAO;
namespace Crud_V2.Gateway
{
	public class PR_UserInformationGateway:DBConnector
	{

		internal DataTable GetAllPR_UserInformationInfo()
		{
			string query = "Select* From PR_UserInformation";
	 	 	return ExecuteQuery(query);
	 	}
		


		internal DataTable GetAllPR_UserInformationInfoByUsername(string username)
		{
			string query = "select* from PR_UserInformation where username='"+ username +"'";
			return ExecuteQuery(query);
		}
		internal DataTable GetAllPR_UserInformationInfoByAccessThrough()
		{
			string query = "Select DISTINCT AccessThrough From PR_UserInformation Where AccessThrough IS NOT NULL ORDER BY AccessThrough ";
			return ExecuteQuery(query);
		}
		internal DataTable GetAllPR_UserInformationInfoByUserLocation()
		{
			string query = "Select DISTINCT UserLocation From PR_UserInformation  Where UserLocation IS NOT NULL ORDER BY UserLocation";
			return ExecuteQuery(query);
		}
		internal DataTable GetAllPR_UserInformationInfoByCompanyAccess()
		{
			string query = "Select DISTINCT CompanyAccess From PR_UserInformation  Where CompanyAccess IS NOT NULL ORDER BY CompanyAccess";
			return ExecuteQuery(query);
		}

		internal DataTable GetAllPR_UserInformationInfoByUserGroup()
		{
			string query = "Select DISTINCT UserGroup From PR_UserInformation  Where UserGroup IS NOT NULL ORDER BY UserGroup";
			return ExecuteQuery(query);
		}

		internal DataTable GetAllPR_UserInformationInfoByIsActive()
		{
			string query = "Select DISTINCT IsActive From PR_UserInformation  Where IsActive IS NOT NULL ORDER BY IsActive";
			return ExecuteQuery(query);
		}
		internal DataTable GetAllPR_UserInformationInfoByRole()
		{
			string query = "Select DISTINCT role From PR_UserInformation  Where role IS NOT NULL ORDER BY role";
			return ExecuteQuery(query);
		}

		internal DataTable GetAllPR_UserInformationInfoBydeptname()
		{
			string query = "Select DISTINCT deptname From PR_UserInformation  Where deptname IS NOT NULL ORDER BY deptname";
			return ExecuteQuery(query);
		}
		internal DataTable GetAllPR_UserInformationInfoByCompanyName()
		{
			string query = "Select DISTINCT CompanyName From PR_UserInformation  Where CompanyName IS NOT NULL ORDER BY CompanyName";
			return ExecuteQuery(query);
		}
		internal int InsertPR_UserInformationInfo(PR_UserInformationDAO objPR_UserInformationDAO)
		{
			string query = "Insert Into PR_UserInformation Values('" + objPR_UserInformationDAO.companyname +"','"+ objPR_UserInformationDAO.username +"','"+ objPR_UserInformationDAO.password +"','"+ objPR_UserInformationDAO.name +"','"+ objPR_UserInformationDAO.email +"','"+ objPR_UserInformationDAO.deptname +"','"+ objPR_UserInformationDAO.role +"','"+ objPR_UserInformationDAO.isactive +"','"+ objPR_UserInformationDAO.shortcode +"','"+ objPR_UserInformationDAO.profileid +"','"+ objPR_UserInformationDAO.usergroup +"','"+ objPR_UserInformationDAO.companyaccess +"','"+ objPR_UserInformationDAO.userlocation +"','"+ objPR_UserInformationDAO.businesstype +"','"+ objPR_UserInformationDAO.foldername +"','"+ objPR_UserInformationDAO.profileimagename +"','"+ objPR_UserInformationDAO.accessthrough+"')";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int UpdatePR_UserInformationInfo(PR_UserInformationDAO objPR_UserInformationDAO)
		{ 
			string query = "Update PR_UserInformation Set ColumnName = '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int DeletePR_UserInformationInfo(PR_UserInformationDAO objPR_UserInformationDAO)
		{ 
			string query = "DELETE from PR_UserInformation '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}
	}
}
