using System.ComponentModel.DataAnnotations;

namespace CoreBusiness;

public class Product
{
    public int ProductId { get; set; }

    [Required]
    [Display(Name = "CategoryId")]
    public int? CategoryId { get; set; }

    [Required] public string Name { get; set; } = string.Empty;

    [Required] public int? Quantity { get; set; }

    [Required] [Range(0, int.MaxValue)] public double? Price { get; set; }

    //## Navigation for ef core
    public Category? Category { get; set; }
}