using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.EntityConfiguration;

public class BrandMethodConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasData(
            new Brand { Id = Guid.NewGuid(), Name = "Dell", Description = "Innovative technology and computing solutions." },
            new Brand { Id = Guid.NewGuid(), Name = "Apple", Description = "Leading brand in consumer electronics and software." },
            new Brand { Id = Guid.NewGuid(), Name = "Samsung", Description = "Pioneering electronics, home appliances, and mobile technology." },
            new Brand { Id = Guid.NewGuid(), Name = "Sony", Description = "Entertainment and electronics innovations." },
        
            new Brand { Id = Guid.NewGuid(), Name = "Nike", Description = "Global leader in athletic wear and footwear." },
            new Brand { Id = Guid.NewGuid(), Name = "Adidas", Description = "Innovative sports apparel and accessories." },
            new Brand { Id = Guid.NewGuid(), Name = "Levi's", Description = "Iconic denim and casual wear." },
            new Brand { Id = Guid.NewGuid(), Name = "Gucci", Description = "Luxury fashion brand known for stylish goods." },

            new Brand { Id = Guid.NewGuid(), Name = "Toyota", Description = "Reliable and affordable vehicles." },
            new Brand { Id = Guid.NewGuid(), Name = "BMW", Description = "Luxury German automotive brand." },
            new Brand { Id = Guid.NewGuid(), Name = "Tesla", Description = "Electric cars and sustainable energy." },
            new Brand { Id = Guid.NewGuid(), Name = "Ford", Description = "Versatile American automotive brand." },

            new Brand { Id = Guid.NewGuid(), Name = "Coca-Cola", Description = "World-renowned soft drinks and beverages." },
            new Brand { Id = Guid.NewGuid(), Name = "Pepsi", Description = "Global beverage and snack brand." },
            new Brand { Id = Guid.NewGuid(), Name = "Nestlé", Description = "Trusted food and beverage conglomerate." },
            new Brand { Id = Guid.NewGuid(), Name = "Starbucks", Description = "Popular coffeehouse chain." },

            new Brand { Id = Guid.NewGuid(), Name = "Under Armour", Description = "High-quality athletic apparel and footwear." },
            new Brand { Id = Guid.NewGuid(), Name = "Columbia", Description = "Outdoor and sportswear brand." },
            new Brand { Id = Guid.NewGuid(), Name = "The North Face", Description = "Premium outdoor clothing and gear." },
            new Brand { Id = Guid.NewGuid(), Name = "Patagonia", Description = "Environmentally conscious outdoor wear." },

            new Brand { Id = Guid.NewGuid(), Name = "IKEA", Description = "Affordable furniture and home goods." },
            new Brand { Id = Guid.NewGuid(), Name = "Home Depot", Description = "Home improvement and hardware." },
            new Brand { Id = Guid.NewGuid(), Name = "Philips", Description = "Innovative consumer electronics and lighting." },
            new Brand { Id = Guid.NewGuid(), Name = "Smeg", Description = "Italian brand known for stylish kitchen appliances." },

            new Brand { Id = Guid.NewGuid(), Name = "L'Oréal", Description = "Leading cosmetics and skincare brand." },
            new Brand { Id = Guid.NewGuid(), Name = "Dove", Description = "Personal care and skincare products." },
            new Brand { Id = Guid.NewGuid(), Name = "Nivea", Description = "Trusted skincare and beauty products." },
            new Brand { Id = Guid.NewGuid(), Name = "MAC Cosmetics", Description = "Popular brand for professional makeup." }
        );
    }
}