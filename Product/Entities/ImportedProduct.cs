using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Product.Entities
{
    class ImportedProduct : Products
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " " + "$ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + ($"(Customs fee:{CustomsFee})"));

            return sb.ToString();
        }


    }
}
