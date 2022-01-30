using System;
using System.ComponentModel.DataAnnotations;


namespace Deliverycart.Models
{
    public class Billing
    {
         public int BillingID {get;set;}
        public int CustomerID {get;set;}
        public int ShopperID {get;set;}
        public int VendorID {get;set;}        
        public int bankRoutingNum {get;set;}
        public int bankAccountNum {get;set;}
        
    }
}