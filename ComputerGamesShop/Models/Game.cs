using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerGamesShop.Models
{
    public enum Genre
    {
        Action,
        Adventure,
        Racing,
        Fantasy,
        Choices,
        Platformer,
        Puzzle,
        Cards,
        Strategy,
        Sports
    }
    
    public class Game
    {
        private int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int PublisherID { get; set; }
        public bool IsMultiplayer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public Game()
        {
            this.Customers = new HashSet<Customer>();
        }
    }
}