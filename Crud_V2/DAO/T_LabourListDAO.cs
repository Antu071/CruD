using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Crud_V2.DAO
{
	public class T_LabourListDAO
	{	 	
	 	 public int id { get; set; }
	 	 public string employeeid { get; set; }
	 	 public string employeename { get; set; }
	 	 public string email { get; set; }
	 	 public string department { get; set; }
	 	 public string designation { get; set; }
	 	 public DateTime joining_date { get; set; }
	 	 public decimal salary { get; set; }
	}
}
