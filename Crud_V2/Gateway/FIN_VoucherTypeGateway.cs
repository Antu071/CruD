using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Crud_V2.DAO;
namespace Crud_V2.Gateway
{
	public class FIN_VoucherTypeGateway:DBConnector
	{

		internal DataTable GetAllFIN_VoucherTypeInfo()
		{
			string query = "Select*,CASE WHEN ID%2 <>0 THEN 'ODD NUMBER' ELSE 'EVEN NUMBER' END As Odd_Or_Even From FIN_VoucherType";
	 	 	return ExecuteQuery(query);
	 	}
		 internal int InsertFIN_VoucherTypeInfo(FIN_VoucherTypeDAO objFIN_VoucherTypeDAO)
		{
			string query = "Insert Into FIN_VoucherType Values('" + objFIN_VoucherTypeDAO.vouchername +"','"+ objFIN_VoucherTypeDAO.namebehind +"','"+ objFIN_VoucherTypeDAO.companyname+"')";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int UpdateFIN_VoucherTypeInfo(FIN_VoucherTypeDAO objFIN_VoucherTypeDAO)
		{ 
			string query = "Update FIN_VoucherType Set ColumnName = '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}
		 internal int DeleteFIN_VoucherTypeInfo(FIN_VoucherTypeDAO objFIN_VoucherTypeDAO)
		{ 
			string query = "DELETE from FIN_VoucherType '' WHERE employeeid= ''";
	 	 	return ExecuteNonQuery(query);
	 	}

		internal int DeleteFIN_VoucherTypeByID(int id)
		{
			string query = "DELETE from FIN_VoucherType Where ID='" + id + "'";
			return ExecuteNonQuery(query);
		}

		internal DataTable GetT_FIN_VoucherTypeInfoByID(int voucherid)
		{
			string query = "Select * From FIN_VoucherType Where ID='" + voucherid + "'";
			return ExecuteQuery(query);
		}
	}
}
