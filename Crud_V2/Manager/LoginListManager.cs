using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Crud_V2.DAO;
using Crud_V2.Gateway;
namespace Crud_V2.Manager
{
	public class LoginListManager
	{
		 internal static DataTable GetAllLoginListInfo()
		 {
			return new LoginListGateway().GetAllLoginListInfo();
 	 	 }
		 internal static int InsertLoginListInfo(LoginListDAO objLoginListDAO)
		 { 
			 return new LoginListGateway().InsertLoginListInfo(objLoginListDAO);
 	 	 }
		 internal static int UpdateLoginListInfo(LoginListDAO objLoginListDAO)
		 { 
			 return new LoginListGateway().UpdateLoginListInfo(objLoginListDAO);
 	 	 }
		 internal static int DeleteLoginListInfo(LoginListDAO objLoginListDAO)
		 { 
			 return new LoginListGateway().DeleteLoginListInfo(objLoginListDAO);
 	 	 }

		internal static DataTable GetLoginListInfo(LoginListDAO objLoginListDAO)
		{
			return new LoginListGateway().GetLoginListInfo(objLoginListDAO);

		}
	}
 }
