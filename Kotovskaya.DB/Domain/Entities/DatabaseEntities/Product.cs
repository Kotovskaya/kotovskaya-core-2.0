﻿using System.ComponentModel.DataAnnotations;

namespace Kotovskaya.DB.Domain.Entities.DatabaseEntities;

public class ProductEntity
{
    [StringLength(150, MinimumLength = 5)] public string Id { get; init; } = Guid.NewGuid().ToString();

    [StringLength(150, MinimumLength = 5)] public string Name { get; set; } = "Без имени";

    [StringLength(2048, MinimumLength = 5)]
    public string? Description { get; set; } = "";

    public Guid? MsId { get; init; }

    [StringLength(64, MinimumLength = 10)] public string? Article { get; set; }

    public int Quantity { get; set; }

    [StringLength(150, MinimumLength = 5)] public string? CategoryId { get; init; }

    public Category Category { get; init; } = null!;

    [StringLength(512, MinimumLength = 0)] public string? ImageLink { get; set; }

    public SaleTypes? SaleTypes { get; set; }
    public DateTime? LastUpdatedAt { get; set; }
}
