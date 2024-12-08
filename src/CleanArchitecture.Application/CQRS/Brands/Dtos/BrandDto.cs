using AutoMapper;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.CQRS.Brands.Dtos;

[AutoMap(typeof(Brand))]
public class BrandDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}