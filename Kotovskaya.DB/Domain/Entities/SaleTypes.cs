﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kotovskaya.DB.Domain.Entities;

public class SaleTypes
{
    [Key]
    public Guid Id { get; init; }
    
    [ForeignKey("ProductId")]
    public ProductEntity Product { get; init; }
    
    public int Price { get; init; }
    
    public int? SalePrice { get; init; }

}