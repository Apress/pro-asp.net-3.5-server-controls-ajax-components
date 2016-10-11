using System.Data;
using System.Data.SqlClient;

namespace ControlsBook2Mobile.Ch10
{
   public class CustDB
   {
      public static DataSet GetCustomersByName(string Name, string TopAmount)
      {
         SqlConnection conn =
            new SqlConnection(@"Server=.\SQLEXPRESS;Database=Northwind;Integrated Security=true;");
         conn.Open();

         SqlDataAdapter da =
            new SqlDataAdapter("SELECT TOP " + TopAmount + " CustomerID, ContactName, ContactTitle, CompanyName FROM Customers WHERE ContactName LIKE '%" + Name + "%'",
            conn);
         DataSet ds = new DataSet();
         da.Fill(ds,"Customers");

         return ds;
      }
   }
}
