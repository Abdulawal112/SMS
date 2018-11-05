using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.DAL;
using StockManagementSystem.Module;

namespace StockManagementSystem.BLL
{
    class StocInkManager
    {
        StockInRepository stockInRepository=new StockInRepository();

        public bool Save(Stock stock, Item item)
        {
            bool save = stockInRepository.Save(stock,item);
            return save;
        }



        public List<Company> GetDataComboBoxCompany()
        {
            List<Company> companylist = new List<Company>();
            companylist = stockInRepository.GetDataComboBoxCompany();
            return companylist;
        }
        public List<Category> GetDataComboBoxCategories(Company company)
        {
            List<Category> categorieList = new List<Category>();
            categorieList = stockInRepository.GetDataComboBoxCategories(company);
            return categorieList;
        }

        public List<Item> GetDataComboBoxItems(Category category)
        {
            List<Item> itemList = new List<Item>();
            itemList = stockInRepository.GetDataComboBoxItems(category);
            return itemList;
        }

        public int reorderData(int reorder)
        {
            int id = stockInRepository.reorderData(reorder);
            return id;
        }

        ////Reorder Alert////
        public string ReorderAlert(int reorder, int quentity)
        {
            if (reorder > quentity)
            {
                return "Alert Quentity Must Be Gatter then Reorder.";
            }
            else
            {
                return "";
            }
        }
    }
}
