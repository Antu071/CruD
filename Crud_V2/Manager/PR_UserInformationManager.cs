using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Crud_V2.DAO;
using Crud_V2.Gateway;
namespace Crud_V2.Manager
{
	public class PR_UserInformationManager
	{
		 internal static DataTable GetAllPR_UserInformationInfo()
		 { 
			 return new PR_UserInformationGateway().GetAllPR_UserInformationInfo();
 	 	 }

		internal static DataTable GetAllPR_UserInformationInfoByUsername(string username)
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByUsername(username);
		}

		internal static DataTable GetAllPR_UserInformationInfoByAccessThrough()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByAccessThrough();
		}

		internal static DataTable GetAllPR_UserInformationInfoByUserLocation()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByUserLocation();
		}

		internal static DataTable GetAllPR_UserInformationInfoByCompanyAccess()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByCompanyAccess();
		}
		internal static DataTable GetAllPR_UserInformationInfoByUserGroup()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByUserGroup();
		}
		internal static DataTable GetAllPR_UserInformationInfoByIsActive()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByIsActive();
		}

		internal static DataTable GetAllPR_UserInformationInfoByRole()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByRole();
		}

		internal static DataTable GetAllPR_UserInformationInfoBydeptname()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoBydeptname();
		}

		internal static DataTable GetAllPR_UserInformationInfoByCompanyName()
		{
			return new PR_UserInformationGateway().GetAllPR_UserInformationInfoByCompanyName();
		}

		internal static int InsertPR_UserInformationInfo(PR_UserInformationDAO objPR_UserInformationDAO)
		 { 
			 return new PR_UserInformationGateway().InsertPR_UserInformationInfo(objPR_UserInformationDAO);
 	 	 }
		 internal static int UpdatePR_UserInformationInfo(PR_UserInformationDAO objPR_UserInformationDAO)
		 { 
			 return new PR_UserInformationGateway().UpdatePR_UserInformationInfo(objPR_UserInformationDAO);
 	 	 }
		 internal static int DeletePR_UserInformationInfo(PR_UserInformationDAO objPR_UserInformationDAO)
		 { 
			 return new PR_UserInformationGateway().DeletePR_UserInformationInfo(objPR_UserInformationDAO);
 	 	 }
 	}
 }
