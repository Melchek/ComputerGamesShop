using System.Collections.Generic;

namespace ComputerGamesShop.Models
{
    public class Manager : User
    {
        #region Navigate Properties

        public virtual ICollection<Store> Stores { get; set; }

        #endregion
    }
}
