using orderApp.View_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace orderApp.Models
{
   public class CartModel: BaseViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public int _purchasedQty { get; set; }

        public int purchasedQty
        {
            get
            {
                return _purchasedQty;
            }
            set
            {
                if (value > 0)
                    _purchasedQty = value;
                else
                    _purchasedQty = 1;
                base.OnPropertyChanged();
            }
        }
    }
}
