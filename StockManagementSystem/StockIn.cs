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
    public partial class StockIn : Form
    {
        public StockIn()
        {
            InitializeComponent();
        }
        Company _company=new Company();
        Category _category=new Category();
        StocInkManager _stocInkManager=new StocInkManager();
        Stock _stock=new Stock();
        Item _item=new Item();
        private void StockInSaveButton_Click(object sender, EventArgs e)
        {
            //_company.Id = Convert.ToInt32(StockInCompanyComboBox.SelectedValue);
            _item.Id = Convert.ToInt32(StockInItemComboBox.SelectedValue);
            StockInAvaiableQtyTextBox.Text =_stock.Quentity.ToString();
            _stock.Quentity = Convert.ToInt32(StockIntextBox.Text);
            _stock.Date =Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            int reorder = Convert.ToInt32(StockInReordertextBox.Text);

            string reorderMassage = _stocInkManager.ReorderAlert(reorder, _stock.Quentity);
            if (reorderMassage=="")
            {
                bool save = _stocInkManager.Save(_stock, _item);
                if (save)
                {
                    MessageBox.Show("Save Successfully.");
                }
                else
                {
                    MessageBox.Show("Save Failed.");
                }
                
            }
            else
            {
                reorderLabelAlert.Text = reorderMassage;
            }
           

        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            List<Company> company = _stocInkManager.GetDataComboBoxCompany();
            companyBindingSource.DataSource = company;
        }

        private void StockInCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _company.Id = Convert.ToInt32(StockInCompanyComboBox.SelectedValue);
            List<Category> categoryList = _stocInkManager.GetDataComboBoxCategories(_company);
           categoryBindingSource.DataSource = categoryList;
        }

        private void StockInCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _category.Id = Convert.ToInt32(StockInCategoryComboBox.SelectedValue);
            List<Item> itemList = _stocInkManager.GetDataComboBoxItems(_category);
            itemBindingSource.DataSource = itemList;
        }

        private void StockInItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reorder = Convert.ToInt32(StockInItemComboBox.SelectedValue);
            StockInReordertextBox.Text = _stocInkManager.reorderData(reorder).ToString();
        }
    }
}
