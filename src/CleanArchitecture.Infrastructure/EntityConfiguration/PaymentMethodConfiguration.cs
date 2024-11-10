using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.EntityConfiguration;

    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasData(
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Credit Card", Description = "Pay using Visa, MasterCard, or American Express credit cards." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Debit Card", Description = "Pay using Visa, MasterCard, or other bank debit cards." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "PayPal", Description = "Secure payment via PayPal account." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Bank Transfer", Description = "Direct bank transfer for larger transactions." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Cash on Delivery", Description = "Pay with cash upon delivery of goods." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Apple Pay", Description = "Fast and secure payments with Apple Pay." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Google Pay", Description = "Convenient payments through Google Pay." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Gift Card", Description = "Redeemable gift card for online purchases." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Amazon Pay", Description = "Checkout securely using your Amazon account." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Cryptocurrency", Description = "Pay with Bitcoin, Ethereum, and other cryptocurrencies." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Afterpay", Description = "Buy now, pay later with Afterpay installments." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Klarna", Description = "Flexible payment options with Klarna." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Alipay", Description = "Payment through Alipay, popular in China." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "WeChat Pay", Description = "Convenient payment through WeChat Pay." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Samsung Pay", Description = "Secure payments through Samsung Pay." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Shop Pay", Description = "Fast and secure checkout through Shopify's Shop Pay." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Venmo", Description = "Pay through Venmo, convenient for US customers." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "UnionPay", Description = "Secure payments through UnionPay." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "Discover", Description = "Payment via Discover credit card." },
            new PaymentMethod { Id = Guid.NewGuid(), Name = "JCB", Description = "Payment through Japan Credit Bureau (JCB) card." }
        );
    }
    }
    