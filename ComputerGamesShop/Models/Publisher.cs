using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerGamesShop.Models
{
    public class Publisher
    {
        #region Properties

        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Upload)]
        public string Image { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Founded Date")]
        public DateTime FoundedDate { get; set; }

        [Required]
        [EnumDataType(typeof(Genre))]
        public Genre Specialty { get; set; }

        #endregion

        #region Navigate Properties

        public ICollection<Game> Games { get; set; }

        #endregion
    }
}