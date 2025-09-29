using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int ID { get; set; }

    [Required]
    [StringLength(150)] 
    [Display(Name = "Movie Name")]
    public string? Name { get; set; } 

    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; } 
    
    [Required]
    [StringLength(60)]
    [Display(Name = "Rating")]
    public string? Rating { get; set; }
}