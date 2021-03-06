using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vividly_app.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public short NumberInStock { get; set; }

        public short NumberAvailable { get; set; }
    }
}