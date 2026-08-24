using ERP_EntityFramework_Entities.Entities;
using ERP_EntityFramework_Entities.Enums;

public class Product : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }

    public ProductType ProductType { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int UnitId { get; set; }
    public Unit Unit { get; set; }

    public string Barcode { get; set; }

    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }

    public string Description { get; set; }
}