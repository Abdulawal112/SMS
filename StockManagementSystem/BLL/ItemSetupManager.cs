using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Module;

namespace StockManagementSystem.BLL
{
   public class ItemSetupManager
    {
        ItemSetupRepository _itemSetupRepository=new ItemSetupRepository();
        public List<Item> GetDataSourceCompany()
        {
            List<Item> companyName = _itemSetupRepository.GetDataSourceCompanyName();
            return companyName;
        }

    }
}
