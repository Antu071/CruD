using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Crud_V2.DAO;
using Crud_V2.Gateway;
namespace Crud_V2.Manager
{
	public class FIN_VoucherTypeManager
	{
		 internal static DataTable GetAllFIN_VoucherTypeInfo()
		 { 
			 return new FIN_VoucherTypeGateway().GetAllFIN_VoucherTypeInfo();
 	 	 }
		 internal static int InsertFIN_VoucherTypeInfo(FIN_VoucherTypeDAO objFIN_VoucherTypeDAO)
		 { 
			 return new FIN_VoucherTypeGateway().InsertFIN_VoucherTypeInfo(objFIN_VoucherTypeDAO);
 	 	 }
		 internal static int UpdateFIN_VoucherTypeInfo(FIN_VoucherTypeDAO objFIN_VoucherTypeDAO)
		 { 
			 return new FIN_VoucherTypeGateway().UpdateFIN_VoucherTypeInfo(objFIN_VoucherTypeDAO);
 	 	 }
		 internal static int DeleteFIN_VoucherTypeInfo(FIN_VoucherTypeDAO objFIN_VoucherTypeDAO)
		 { 
			 return new FIN_VoucherTypeGateway().DeleteFIN_VoucherTypeInfo(objFIN_VoucherTypeDAO);
 	 	 }

		internal static int DeleteFIN_VoucherTypeByID(int id)
		{
			return new FIN_VoucherTypeGateway().DeleteFIN_VoucherTypeByID(id);
		}

		internal static DataTable GetT_FIN_VoucherTypeInfoByID(int voucherid)
		{
			return new FIN_VoucherTypeGateway().GetT_FIN_VoucherTypeInfoByID(voucherid);
		}
	}
 }
