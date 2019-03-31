using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "标题")]
        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "上映时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "类型")]
        [DataType(DataType.Text)]
        //[RegularExpression(@"^[A-Z]*$")]//正侧限制
        [Required]
        public string Genre { get; set; }

        [Display(Name = "价格")]
        [DataType(DataType.Currency)]
        [Required]//这个是必填
        [Range(1, 100)]//数值限制1-100
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}