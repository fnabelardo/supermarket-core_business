using System.ComponentModel.DataAnnotations;

namespace CoreBusiness;

public class Category
{
    public Category()
    {
    }

    public Category(int categoryId, string name, string description)
    {
        CategoryId = categoryId;
        Name = name;
        Description = description;
    }

    public int CategoryId { get; set; }
    [Required] public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    
    //## Navigation property for ef core
    public List<Product>? Products { get; set; }
}