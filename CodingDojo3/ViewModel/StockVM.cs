using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModel
{
    public class StockVM
    {
        private Stock stock;

        public List<StockEntry> OnStock
        {
            get { return stock.OnStock; }
            set { stock.OnStock = value; }
        }

        public StockVM()
        {
            stock = new Stock();
        }
    }
}
