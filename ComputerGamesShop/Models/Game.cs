using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerGamesShop.Models
{
    public class Game
    {
        #region Properties

        [Key]
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(45)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(400)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required field")]
        [EnumDataType(typeof(Genre))]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Price")]
        [Range(0, int.MaxValue)]
        public double Price { get; set; }

        [DataType(DataType.Upload)]
        public string Image { get; set; }

        [ForeignKey("Publisher")]
        [Display(Name = "Publisher")]
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        [Display(Name = "isMultiplayer")]
        [Required(ErrorMessage = "Required field")]
        public bool IsMultiplayer { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        #endregion
    }
}