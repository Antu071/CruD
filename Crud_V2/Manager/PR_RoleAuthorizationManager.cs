using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Crud_V2.DAO;
using Crud_V2.Gateway;
namespace Crud_V2.Manager
{
	public class PR_RoleAuthorizationManager
	{
		 internal static DataTable GetAllPR_RoleAuthorizationInfo()
		 { 
			 return new PR_RoleAuthorizationGateway().GetAllPR_RoleAuthorizationInfo();
 	 	 }

		 internal static DataTable GetAllPR_RoleAuthorizationInfoBYRoleName()
         {
			 return new PR_RoleAuthorizationGateway().GetAllPR_RoleAuthorizationInfoBYRoleName();
		 }

		 internal static DataTable GetAllPR_RoleAuthorizationInfoBYCompanyName()
		 {
			 return new PR_RoleAuthorizationGateway().GetAllPR_RoleAuthorizationInfoBYCompanyName();
		 }
		internal static int InsertPR_RoleAuthorizationInfo(PR_RoleAuthorizationDAO objPR_RoleAuthorizationDAO)
		 { 
			 return new PR_RoleAuthorizationGateway().InsertPR_RoleAuthorizationInfo(objPR_RoleAuthorizationDAO);
 	 	 }
		 internal static int UpdatePR_RoleAuthorizationInfo(PR_RoleAuthorizationDAO objPR_RoleAuthorizationDAO)
		 { 
			 return new PR_RoleAuthorizationGateway().UpdatePR_RoleAuthorizationInfo(objPR_RoleAuthorizationDAO);
 	 	 }
		 internal static int DeletePR_RoleAuthorizationInfo(PR_RoleAuthorizationDAO objPR_RoleAuthorizationDAO)
		 { 
			 return new PR_RoleAuthorizationGateway().DeletePR_RoleAuthorizationInfo(objPR_RoleAuthorizationDAO);
 	 	 }
 	}
 }
