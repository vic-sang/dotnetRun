using System.ComponentModel.DataAnnotations;
using System;



namespace Deliverycart.Models
{
    public class User
    {
        public int UserID {get;set;}

        public string FirstName {get;set;}

        public string LastName {get;set;}        
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public int zipCode {get;set;}
        public List <Customer> Customer {get;set;}
        public List <Vendor> Vendor {get;set;}
        public List <Shopper> Shopper {get;set;}

    }
}