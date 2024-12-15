using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.EntityConfiguration;

    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasData(
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Credit Card" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Debit Card" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "PayPal" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Bank Transfer" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Cash on Delivery" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Apple Pay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Google Pay"  },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Gift Card"},
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Amazon Pay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Cryptocurrency" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Afterpay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Klarna" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Alipay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "WeChat Pay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Samsung Pay"},
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Shop Pay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Venmo" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "UnionPay" },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Discover"},
            new PaymentMethod { Id = Guid.NewGuid(), Name = "JCB" }
        );
    }
    }
