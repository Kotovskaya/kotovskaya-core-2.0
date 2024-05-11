﻿namespace Kotovskaya.Categories.Domain.DTO;

public class ProductEntityDto
{
    public string Id { get; init; }
    public string Name { get; init; }
    public string? Description { get; init; }
    public int Quantity { get; init; }
}