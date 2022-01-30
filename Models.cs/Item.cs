using System;
using System.ComponentModel.DataAnnotations;


namespace Deliverycart.Models
{
    public class Item
    {
        public int ItemID {get;set;}
        public int OrderID {get;set;}
        public int invitemID {get;set;} 

        public int itemQty {get;set;}
        public string itemName {get;set;}
        public Order Order {get;set;}
        
    }
}