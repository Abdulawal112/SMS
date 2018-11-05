using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Module;

namespace StockManagementSystem
{
    public partial class ItemSetup : Form
    {
        Item _inItemSetupClass =new Item();
        ItemSetupManager _itemSetupManager=new ItemSetupManager();
        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetupSaveButton_Click(object sender, EventArgs e)
        {
            _inItemSetupClass.Name = itemNameTextBox.Text;
            _inItemSetupClass.Reoder = Convert.ToInt32(ItemReorderLaveTextBox.Text);
            _inItemSetupClass.CompanyId = Convert.ToInt32(ItemCompanyNameComboBox.Text);
            _inItemSetupClass.CategoryId = Convert.ToInt32(ItemCategoryNameComboBox.Text);


        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            List<Item> company = _itemSetupManager.GetDataSourceCompany();
            companyClassBindingSource.DataSource = company;



        }
    }
}
