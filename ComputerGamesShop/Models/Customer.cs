using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerGamesShop.Models
{
    public enum Gender
    {
        male,
        female
    };

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        //public virtual ICollection<Order> Orders { get; set; }
    }
}