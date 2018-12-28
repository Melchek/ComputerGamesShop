using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerGamesShop.Models
{
    public class Order
    {
        #region Properties

        public Order()
        {
            this.Games = new List<Game>();
        }
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Required field")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Required field")]
        public int BranchID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Total")]
        public int TotalPrice
        {
            get
            {
                var total = 0;
                foreach (var p in this.Games)
                {
                    total += (int)p.Price;
                }
                return total;
            }
        }

        #endregion

        #region Navigate Properties

        public virtual ICollection<Game> Games { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Store Store { get; set; }

        #endregion
    }

    public class OrderYearsViewModel
    {
        #region Properties
        [DisplayName("Year")]
        public int Year { get; set; }

        [DisplayName("Orders a year")]
        public int PostCount { get; set; }
        
        #endregion
    }
}