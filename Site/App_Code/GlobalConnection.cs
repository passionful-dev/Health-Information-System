using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

/// <summary>
/// Summary description for GlobalConnection
/// </summary>
public class GlobalConnection
{
    public SqlConnection cn;
	public GlobalConnection() 
    {
		    String strCon = System.Configuration.ConfigurationManager.AppSettings.Get("MyConnection").ToString();
            cn = new SqlConnection(strCon);
            cn.Open();
	}
}

