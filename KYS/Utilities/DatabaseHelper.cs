using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace KYS.Utilities
{
	public class DatabaseHelper
	{
	//	string connetionString;
		//SqlConnection cnn;
		public DatabaseHelper()
		{
			//connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb ;User ID=sa;Password=demol23";

			//cnn = new SqlConnection(connetionString);

		

			SqlConnection connection = new SqlConnection("Server=ISTN31836;Database=KYS; trusted_connection=true"); //Connection tanımlama
			connection.Open();

		}
		
	}
}