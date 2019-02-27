using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Modules
{
    public class MachineView
    {
        public ObservableCollection<ProductIn> Items
        {
            get;
            set;
        }

        public MachineView()
        {
            Items = new ObservableCollection<ProductIn>()
            {
                new ProductIn(5, "PayDay", 1.00),
                new ProductIn(5, "Snickers", 1.00),
                new ProductIn(5, "Milky Way", 1.00),
                new ProductIn(5, "Twix", 1.00),
            };
        }

        public void Purchase(object item)
        {
            var requestedItem = item as ProductIn;
            requestedItem.Dispence();
        }

        internal string Items()
        {
            throw new NotImplementedException();
        }

        public void Refill()
        {
            foreach(var i in Items)
            {
                i.Refill();
            }
        }

        public void Empty()
        {
            foreach (var i in Items)
            {
                i.Empty();
            }
        }
    }
}
