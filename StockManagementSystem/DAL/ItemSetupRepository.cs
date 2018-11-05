using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Module;

namespace StockManagementSystem.DAL
{
  public  class ItemSetupRepository
  {
      private string ConString = @"Server=DESKTOP-SDC4J0E; Database=StockManagement;Integrated Security=true;";
        public List<Item> GetDataSourceCompanyName()
        {
            SqlConnection con=new SqlConnection(ConString);
            string query = @"Select * From CompanyTable";
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);
            con.Close();

            List<Item> companyList = new List<Item>();
            foreach (DataRow a in dt.Rows)
            {
                Item companyName = new Item();
                companyName.CompanyId = Convert.ToInt32(a["Id"]);
                companyName.Name = a["Name"].ToString();
                companyList.Add(companyName);
            }

            return companyList;
        }

    }
}
