using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsPayable
{
    class Invoice:IPayable
    {
        private string partNumber;
        private string partDescription;
        private int quantity;
        private decimal pricePerItem;

        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        public string PartDescription
        {
            get { return PartDescription; }
            set { PartDescription = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set 
            {
                if (value > 0)
                    quantity = value;
                else
                    throw new ArgumentOutOfRangeException("Quantity", value, "Quantity must be >=0");
            }
        }

        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set
            {
                if (value > 0)
                    pricePerItem = value;
                else
                    throw new ArgumentOutOfRangeException("PricePerItem", value, "PricePerItem must be >=0");
            }
        }

        public Invoice(string number, string description, int quantity, decimal price)
        {
            PartNumber = number;
            PartDescription = description;
            Quantity = quantity;
            PricePerItem = price;
        }

        public override decimal GetPaymentAmount()
        {
            return Quantity * PricePerItem;
        }

        public override string ToString()
        {
            return string.Format("Invoice {0}");
        }
    }
}
