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
    class StockInRepository
    {
        string Constring = @"Server=.; Database=StockManagement;Integrated Security=true;";
        public List<Company> GetDataComboBoxCompany()
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"SELECT * FROM Companies";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            List<Company> companylist = new List<Company>();
            foreach (DataRow a in dt.Rows)
            {
                Company company = new Company();
                company.Id = Convert.ToInt32(a["Id"]);
                company.Name = a["Name"].ToString();
                companylist.Add(company);

            }
            return companylist;
        }

        public List<Category> GetDataComboBoxCategories(Company company)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"SELECT * FROM Categories where CompanyId="+company.Id;
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            List<Category> categoryList = new List<Category>();
            foreach (DataRow a in dt.Rows)
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(a["Id"]);
                category.Name = a["Name"].ToString();
                categoryList.Add(category);

            }
            return categoryList;
        }
        public List<Item> GetDataComboBoxItems(Category category)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"SELECT * FROM Items where CategorieId=" + category.Id;
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            List<Item> itemList = new List<Item>();
            foreach (DataRow a in dt.Rows)
            {
                Item item = new Item();
                item.Id = Convert.ToInt32(a["Id"]);
                item.Name = a["Name"].ToString();
                //item.Reoder = Convert.ToInt32(a["Reorder"]);
                itemList.Add(item);

            }
            return itemList;
        }

        public bool Save(Stock stock,Item item)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"Insert into Stocks (Quentity,ItemId,Date) Values(" + stock.Quentity + "," + item.Id + ",'" + stock.Date + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public int reorderData(int reorder)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Constring);
            string query = @"Select Reorder from Items Where Id=" + reorder;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                id = Convert.ToInt32(dr["Reorder"]);

            }
            con.Close();
            return id;
        }
    }
}
