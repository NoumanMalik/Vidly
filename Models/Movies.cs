using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}")]
        [Display(Name = "Released Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}")]
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name ="Genre")]
        public byte GenreId { get; set; }
    }
}