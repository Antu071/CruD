using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Crud_V2.DAO;
using Crud_V2.Gateway;
namespace Crud_V2.Manager
{
	public class T_LabourListManager
	{
		 internal static DataTable GetAllT_LabourListInfo()
		 { 
			 return new T_LabourListGateway().GetAllT_LabourListInfo();
 	 	 }
		 internal static int InsertT_LabourListInfo(T_LabourListDAO objT_LabourListDAO)
		 { 
			 return new T_LabourListGateway().InsertT_LabourListInfo(objT_LabourListDAO);
 	 	 }
		 internal static int UpdateT_LabourListInfo(T_LabourListDAO objT_LabourListDAO)
		 { 
			 return new T_LabourListGateway().UpdateT_LabourListInfo(objT_LabourListDAO);
 	 	 }
		 internal static void DeleteT_LabourListInfo(string employeeid)
		 { 
			  new T_LabourListGateway().DeleteT_LabourListInfo(employeeid);
 	 	 }
		 internal static DataTable GetT_LabourListInfo(string employeeid)
		 {
			return new T_LabourListGateway().GetT_LabourListInfo(employeeid);
		 }
		 
		

	}
 }
