using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyFakeDatabaseProject.Models.EntityConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

public class CategoryMethodConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id = Guid.NewGuid(), Name = "Electronics", Description = "Latest gadgets, mobile devices, and home electronics." },
            new Category { Id = Guid.NewGuid(), Name = "Books", Description = "A wide variety of genres and titles for all readers." },
            new Category { Id = Guid.NewGuid(), Name = "Fashion", Description = "Clothing, footwear, and accessories for men, women, and kids." },
            new Category { Id = Guid.NewGuid(), Name = "Home & Kitchen", Description = "Furniture, decor, kitchen appliances, and tools for every home." },
            new Category { Id = Guid.NewGuid(), Name = "Beauty & Personal Care", Description = "Skincare, makeup, grooming, and personal hygiene products." },
            new Category { Id = Guid.NewGuid(), Name = "Health & Wellness", Description = "Vitamins, supplements, health monitoring devices, and wellness products." },
            new Category { Id = Guid.NewGuid(), Name = "Toys & Games", Description = "Fun and educational toys, board games, and puzzles for kids and adults." },
            new Category { Id = Guid.NewGuid(), Name = "Sports & Outdoors", Description = "Sports equipment, fitness gear, and outdoor adventure essentials." },
            new Category { Id = Guid.NewGuid(), Name = "Automotive", Description = "Car accessories, tools, and parts for vehicle maintenance." },
            new Category { Id = Guid.NewGuid(), Name = "Computers & Accessories", Description = "Laptops, desktops, peripherals, and computer accessories." },
            new Category { Id = Guid.NewGuid(), Name = "Pet Supplies", Description = "Food, toys, and accessories for pets of all kinds." },
            new Category { Id = Guid.NewGuid(), Name = "Office Supplies", Description = "Stationery, furniture, and tech for office use." },
            new Category { Id = Guid.NewGuid(), Name = "Baby Products", Description = "Essentials for babies, including toys, diapers, and feeding supplies." },
            new Category { Id = Guid.NewGuid(), Name = "Grocery & Gourmet Food", Description = "Everyday food items, gourmet foods, and specialty ingredients." },
            new Category { Id = Guid.NewGuid(), Name = "Garden & Outdoor", Description = "Gardening tools, outdoor furniture, and lawn care essentials." },
            new Category { Id = Guid.NewGuid(), Name = "Handmade & Craft Supplies", Description = "Crafting supplies and handmade items from artisans." },
            new Category { Id = Guid.NewGuid(), Name = "Musical Instruments", Description = "Instruments, accessories, and sound equipment for musicians." },
            new Category { Id = Guid.NewGuid(), Name = "Video Games", Description = "Gaming consoles, video games, and accessories for gamers." },
            new Category { Id = Guid.NewGuid(), Name = "Industrial & Scientific", Description = "Equipment and tools for industrial and scientific use." }
        );
    }
}