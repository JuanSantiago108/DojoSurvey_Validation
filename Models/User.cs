#pragma warning disable CS8618 
namespace DJV_Done.Models;
using System.ComponentModel.DataAnnotations;

public class User
{

    [Required(ErrorMessage ="is Required")]
    [MinLength(2, ErrorMessage ="must be at least 2 characters long")]
    [Display(Name ="User Name")]
    public string Name {get; set; }
    [Required]
    [Display(Name ="Dojo Location")]
    public string DojoLocation {get; set; }
    [Required]
    [Display(Name ="Favorite Language")]

    public string FavoriteLanguage {get; set; }
    [Required]
    [Display(Name ="Comment")]
    [MinLength(20, ErrorMessage ="must be at least 20 characters long")]
    public string Comment {get; set; }

}