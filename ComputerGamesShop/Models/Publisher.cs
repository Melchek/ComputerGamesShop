using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerGamesShop.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime FoundedDate { get; set; }
        public Genre Specialty { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}