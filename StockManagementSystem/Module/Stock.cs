
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Module
{
    class Stock
    {
        public int Id { get; set; }
        public int Quentity { get; set; }
        public int ItemId { get; set; }
        public DateTime Date { get; set; }
        public bool Sell { get; set; }
        public bool Damage { get; set; }
        public bool Lost { get; set; }
    }
}
