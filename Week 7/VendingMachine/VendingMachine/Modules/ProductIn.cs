using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Modules
{
    public class ProductIn
    {
        private VendingItem _model;

        private const int _masQuantity = 12;

        private int _quantity;

        public int Id
        {
            get
            {
                return _model.Id;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            private set => _quantity = value;
        }

        public string InventoryDisp
        {
            get
            {
                return _model.Name + ": " + _quantity;
            }
        }

        public VendingItem Information
        {
            get
            {
                return _model;
            }
        }
        public ProductIn(int id, string name, double price)
        {
            _model = new VendingItem(id, name, price);
            Quantity = 0;
        }

        public int Refill()
        {
            var amount = _masQuantity - Quantity;
            Quantity = amount;
            return amount;
        }

        public int Empty()
        {
            var amount = Quantity;
            Quantity = 0;
            return amount;
        }

        public bool Dispence()
        {
            if(Quantity > 0)
            {
                Quantity--;
                return true;
            }
            return false;
        }
    }
}
