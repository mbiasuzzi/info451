using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group8MasterPage
{
    public class CartItem
    {
        public string TitleOfBook { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }

        public CartItem(string TitleOfBook1, string ISBN1, string Price1)
        {
            TitleOfBook = TitleOfBook1;
            ISBN = ISBN1;
            Price = Price1;
        }
        public CartItem()
        {
        }
    }
    
}