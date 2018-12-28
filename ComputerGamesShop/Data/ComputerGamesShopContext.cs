using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComputerGamesShop.Models;

namespace ComputerGamesShop.Dal
{
    public class ComputerGamesShopContext : DbContext
    {
        public ComputerGamesShopContext (DbContextOptions<ComputerGamesShopContext> options)
            : base(options)
        {
        }

        public DbSet<ComputerGamesShop.Models.Game> Game { get; set; }
    }
}
