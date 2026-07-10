using Core.Entities;

namespace Core.Specifications;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(string? brand, string? type) : base(product => 
    (string.IsNullOrWhiteSpace(brand) || product.Brand == brand) &&
    (string.IsNullOrWhiteSpace(type) || product.Type == type))
    {        
    }
    
}