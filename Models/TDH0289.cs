using System.ComponentModel.DataAnnotations;

namespace TranDucHung289.Models;
public class TDH0289
{
    [Key]
    [StringLength(20)]

    public string TDHid { get; set; }

    [Required(ErrorMessage = "not null")]
    [StringLength(50)]
    public string TDHName { get; set; }

    [Required(ErrorMessage = "not null")]

    public Boolean TDHGender { get; set; }

}