using System;
using System.ComponentModel.DataAnnotations;



namespace Deliverycart.Models
{
    public class Shopper : User
    {
        public int ShopperID {get;set;}
        public int CustomerID {get;set;}
        public int BillingID {get;set;}
        public int ManagerID {get; set;}
        public Manager Manager {get; set;}
        public int SSN {get;set;}
        public int deliveryInfo {get;set;}
        public List <Order> Orders {get;set;}
    }
}