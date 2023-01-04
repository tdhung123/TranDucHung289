using System.ComponentModel.DataAnnotations;

namespace TranDucHung289.Models;
public class CompanyTDH289
{
    [Key]
    [StringLength(20)]
    public string CompanyId { get; set; }

    [StringLength(50)]

    public string CompanyName { get; set; }
}