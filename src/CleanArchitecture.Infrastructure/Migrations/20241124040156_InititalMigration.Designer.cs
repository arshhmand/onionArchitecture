﻿// <auto-generated />
using System;
using CleanArchitecture.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241124040156_InititalMigration")]
    partial class InititalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a20dae24-c0a8-4dca-8a10-eec98659cb36"),
                            Description = "Innovative technology and computing solutions.",
                            Name = "Dell"
                        },
                        new
                        {
                            Id = new Guid("688a0ad7-de03-4feb-b2da-a4fcd83212a2"),
                            Description = "Leading brand in consumer electronics and software.",
                            Name = "Apple"
                        },
                        new
                        {
                            Id = new Guid("abff7d2a-3d9d-444c-9f89-b2afa5523e1b"),
                            Description = "Pioneering electronics, home appliances, and mobile technology.",
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = new Guid("79753b01-1e5a-48f7-ba6a-e1051d0c1468"),
                            Description = "Entertainment and electronics innovations.",
                            Name = "Sony"
                        },
                        new
                        {
                            Id = new Guid("3a411f34-bea1-4e96-be45-6b9f61dd591e"),
                            Description = "Global leader in athletic wear and footwear.",
                            Name = "Nike"
                        },
                        new
                        {
                            Id = new Guid("a3398694-0f67-486f-9569-657af3c203b2"),
                            Description = "Innovative sports apparel and accessories.",
                            Name = "Adidas"
                        },
                        new
                        {
                            Id = new Guid("47ba665b-0ee4-4b0a-adb7-729901451927"),
                            Description = "Iconic denim and casual wear.",
                            Name = "Levi's"
                        },
                        new
                        {
                            Id = new Guid("6f26a436-5117-4c1c-ad23-bed4b0f113ab"),
                            Description = "Luxury fashion brand known for stylish goods.",
                            Name = "Gucci"
                        },
                        new
                        {
                            Id = new Guid("5e7f7cf6-7f91-4aa8-ab88-b0343ec211c6"),
                            Description = "Reliable and affordable vehicles.",
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = new Guid("0334934e-989c-4a85-aa6a-8c3f9febf863"),
                            Description = "Luxury German automotive brand.",
                            Name = "BMW"
                        },
                        new
                        {
                            Id = new Guid("a0ba4c52-c283-4d40-86e0-1468a3c2bd8f"),
                            Description = "Electric cars and sustainable energy.",
                            Name = "Tesla"
                        },
                        new
                        {
                            Id = new Guid("df92aa1b-88bf-41c9-ac11-3db74c5ecb85"),
                            Description = "Versatile American automotive brand.",
                            Name = "Ford"
                        },
                        new
                        {
                            Id = new Guid("1e692736-b9df-4bfd-b361-9cba47c0d0fb"),
                            Description = "World-renowned soft drinks and beverages.",
                            Name = "Coca-Cola"
                        },
                        new
                        {
                            Id = new Guid("c296cdc6-72be-49cf-ba21-890df63c1846"),
                            Description = "Global beverage and snack brand.",
                            Name = "Pepsi"
                        },
                        new
                        {
                            Id = new Guid("2c6863ed-d72a-429f-b1fa-89d8dcd831ef"),
                            Description = "Trusted food and beverage conglomerate.",
                            Name = "Nestlé"
                        },
                        new
                        {
                            Id = new Guid("b5093fc6-7431-4bb9-8a89-31a20a24e080"),
                            Description = "Popular coffeehouse chain.",
                            Name = "Starbucks"
                        },
                        new
                        {
                            Id = new Guid("ad0d5ccd-f446-475d-886d-05972e0ee666"),
                            Description = "High-quality athletic apparel and footwear.",
                            Name = "Under Armour"
                        },
                        new
                        {
                            Id = new Guid("fe72646c-d593-4e49-ab77-743512b1db14"),
                            Description = "Outdoor and sportswear brand.",
                            Name = "Columbia"
                        },
                        new
                        {
                            Id = new Guid("fc20f7ad-22ce-45f7-a92c-c6e908cc0675"),
                            Description = "Premium outdoor clothing and gear.",
                            Name = "The North Face"
                        },
                        new
                        {
                            Id = new Guid("22b8c0ee-7221-4b90-85b8-bc11f36e6b32"),
                            Description = "Environmentally conscious outdoor wear.",
                            Name = "Patagonia"
                        },
                        new
                        {
                            Id = new Guid("b0242ce8-f189-4a51-972f-fbce5d088212"),
                            Description = "Affordable furniture and home goods.",
                            Name = "IKEA"
                        },
                        new
                        {
                            Id = new Guid("64a715b4-96ef-4dec-9096-198209190f36"),
                            Description = "Home improvement and hardware.",
                            Name = "Home Depot"
                        },
                        new
                        {
                            Id = new Guid("b5679ef0-0bdd-4c8d-a3cb-2108b3f4a5ab"),
                            Description = "Innovative consumer electronics and lighting.",
                            Name = "Philips"
                        },
                        new
                        {
                            Id = new Guid("fc55625f-dc45-4604-8ce8-511b700a657d"),
                            Description = "Italian brand known for stylish kitchen appliances.",
                            Name = "Smeg"
                        },
                        new
                        {
                            Id = new Guid("12d29e13-14b9-45e6-ba80-4803c8fe405e"),
                            Description = "Leading cosmetics and skincare brand.",
                            Name = "L'Oréal"
                        },
                        new
                        {
                            Id = new Guid("5d0acf11-679a-454a-abcb-d806212b4e6c"),
                            Description = "Personal care and skincare products.",
                            Name = "Dove"
                        },
                        new
                        {
                            Id = new Guid("c53bfff6-2bd4-481d-b019-c0c2835710b6"),
                            Description = "Trusted skincare and beauty products.",
                            Name = "Nivea"
                        },
                        new
                        {
                            Id = new Guid("f02e9206-e806-4f48-9386-6fcf8ee87186"),
                            Description = "Popular brand for professional makeup.",
                            Name = "MAC Cosmetics"
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b879802-3891-4d5a-be09-5bf068130461"),
                            Description = "Latest gadgets, mobile devices, and home electronics.",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("8145e74b-9ea0-42cb-bdb0-c4bd58080216"),
                            Description = "A wide variety of genres and titles for all readers.",
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("4633c324-9666-4226-8a8f-9291bd924cce"),
                            Description = "Clothing, footwear, and accessories for men, women, and kids.",
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = new Guid("18130b4f-9808-4863-91a6-f3e9d27d1e60"),
                            Description = "Furniture, decor, kitchen appliances, and tools for every home.",
                            Name = "Home & Kitchen"
                        },
                        new
                        {
                            Id = new Guid("b1fb2c57-8fd1-4e8f-a0be-798075f09157"),
                            Description = "Skincare, makeup, grooming, and personal hygiene products.",
                            Name = "Beauty & Personal Care"
                        },
                        new
                        {
                            Id = new Guid("95107e82-30f2-46e3-adb3-bc2e8927d1a2"),
                            Description = "Vitamins, supplements, health monitoring devices, and wellness products.",
                            Name = "Health & Wellness"
                        },
                        new
                        {
                            Id = new Guid("94ea707a-f6ec-45dc-b78c-2c903afdf5de"),
                            Description = "Fun and educational toys, board games, and puzzles for kids and adults.",
                            Name = "Toys & Games"
                        },
                        new
                        {
                            Id = new Guid("a62eee60-4eff-4152-8d07-0e8bcade88c6"),
                            Description = "Sports equipment, fitness gear, and outdoor adventure essentials.",
                            Name = "Sports & Outdoors"
                        },
                        new
                        {
                            Id = new Guid("d1e38390-087b-4490-b89e-14e32722db56"),
                            Description = "Car accessories, tools, and parts for vehicle maintenance.",
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = new Guid("9b183a74-1c91-4db9-b44f-3c897fad8550"),
                            Description = "Laptops, desktops, peripherals, and computer accessories.",
                            Name = "Computers & Accessories"
                        },
                        new
                        {
                            Id = new Guid("0b3f1c9a-0b30-44d4-83f5-ec923aa830d1"),
                            Description = "Food, toys, and accessories for pets of all kinds.",
                            Name = "Pet Supplies"
                        },
                        new
                        {
                            Id = new Guid("ba74d5dd-5474-42f9-990c-016057b8ad8a"),
                            Description = "Stationery, furniture, and tech for office use.",
                            Name = "Office Supplies"
                        },
                        new
                        {
                            Id = new Guid("d8f83bd8-20d3-46ee-9ce5-57ac8a4c3ea8"),
                            Description = "Essentials for babies, including toys, diapers, and feeding supplies.",
                            Name = "Baby Products"
                        },
                        new
                        {
                            Id = new Guid("9305136d-e265-4460-a036-99efab91a840"),
                            Description = "Everyday food items, gourmet foods, and specialty ingredients.",
                            Name = "Grocery & Gourmet Food"
                        },
                        new
                        {
                            Id = new Guid("9b0f9f55-9619-49e4-bf53-d6ca4552878f"),
                            Description = "Gardening tools, outdoor furniture, and lawn care essentials.",
                            Name = "Garden & Outdoor"
                        },
                        new
                        {
                            Id = new Guid("328c04f8-23cc-4161-a628-b30d884052fb"),
                            Description = "Crafting supplies and handmade items from artisans.",
                            Name = "Handmade & Craft Supplies"
                        },
                        new
                        {
                            Id = new Guid("cc7e133c-9181-4997-94e2-e8055b386752"),
                            Description = "Instruments, accessories, and sound equipment for musicians.",
                            Name = "Musical Instruments"
                        },
                        new
                        {
                            Id = new Guid("e4c5f396-b35a-4b8b-8a3c-584545cb889f"),
                            Description = "Gaming consoles, video games, and accessories for gamers.",
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = new Guid("2ba0d19b-38c4-42be-a6f1-2fb0b88f86a1"),
                            Description = "Equipment and tools for industrial and scientific use.",
                            Name = "Industrial & Scientific"
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PreferredPaymentMethodId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("PreferredPaymentMethodId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ShippingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("StatusId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.PaymentMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");

                    b.HasData(
                        new
                        {
                            Id = new Guid("032b987f-b214-4e00-8c22-12d315df189b"),
                            Description = "Pay using Visa, MasterCard, or American Express credit cards.",
                            Name = "Credit Card"
                        },
                        new
                        {
                            Id = new Guid("893657a5-cfe0-4c26-bc07-899489541d34"),
                            Description = "Pay using Visa, MasterCard, or other bank debit cards.",
                            Name = "Debit Card"
                        },
                        new
                        {
                            Id = new Guid("f53e7c41-520f-49f2-b7f0-db57a0197b6f"),
                            Description = "Secure payment via PayPal account.",
                            Name = "PayPal"
                        },
                        new
                        {
                            Id = new Guid("62ff3459-bd4b-485e-829e-7f6d15ded8b1"),
                            Description = "Direct bank transfer for larger transactions.",
                            Name = "Bank Transfer"
                        },
                        new
                        {
                            Id = new Guid("163d1cc9-1e52-4ecb-a8c5-055422356f65"),
                            Description = "Pay with cash upon delivery of goods.",
                            Name = "Cash on Delivery"
                        },
                        new
                        {
                            Id = new Guid("0d54415d-fe6a-477f-9a67-624b75890fd9"),
                            Description = "Fast and secure payments with Apple Pay.",
                            Name = "Apple Pay"
                        },
                        new
                        {
                            Id = new Guid("bb8b4999-c393-498a-881c-ab4303b7862e"),
                            Description = "Convenient payments through Google Pay.",
                            Name = "Google Pay"
                        },
                        new
                        {
                            Id = new Guid("2a59655a-4374-495a-b3d3-ff712aa0fcd8"),
                            Description = "Redeemable gift card for online purchases.",
                            Name = "Gift Card"
                        },
                        new
                        {
                            Id = new Guid("82ca2182-434a-417c-83b1-a0e88c1a95fe"),
                            Description = "Checkout securely using your Amazon account.",
                            Name = "Amazon Pay"
                        },
                        new
                        {
                            Id = new Guid("06b42fac-7d25-4637-83a7-f6230e841f0c"),
                            Description = "Pay with Bitcoin, Ethereum, and other cryptocurrencies.",
                            Name = "Cryptocurrency"
                        },
                        new
                        {
                            Id = new Guid("959a510a-4c27-4e17-9776-14b15987a473"),
                            Description = "Buy now, pay later with Afterpay installments.",
                            Name = "Afterpay"
                        },
                        new
                        {
                            Id = new Guid("6ab8da21-bac5-4653-b6f9-8fba103efdce"),
                            Description = "Flexible payment options with Klarna.",
                            Name = "Klarna"
                        },
                        new
                        {
                            Id = new Guid("4a6b10a7-4280-48ba-acd0-49893772b317"),
                            Description = "Payment through Alipay, popular in China.",
                            Name = "Alipay"
                        },
                        new
                        {
                            Id = new Guid("9ae2a268-ba74-4285-8735-07f31d73fdb6"),
                            Description = "Convenient payment through WeChat Pay.",
                            Name = "WeChat Pay"
                        },
                        new
                        {
                            Id = new Guid("2c70ab8c-0807-4c07-a7e7-dacab4c6908a"),
                            Description = "Secure payments through Samsung Pay.",
                            Name = "Samsung Pay"
                        },
                        new
                        {
                            Id = new Guid("92d520b8-fcfc-4cea-a7ad-654f2f3b89db"),
                            Description = "Fast and secure checkout through Shopify's Shop Pay.",
                            Name = "Shop Pay"
                        },
                        new
                        {
                            Id = new Guid("a59729d3-a59f-49cf-90ed-0dd1c8bdd09d"),
                            Description = "Pay through Venmo, convenient for US customers.",
                            Name = "Venmo"
                        },
                        new
                        {
                            Id = new Guid("9513eeb2-9b05-42fa-ae35-10536ca3fef1"),
                            Description = "Secure payments through UnionPay.",
                            Name = "UnionPay"
                        },
                        new
                        {
                            Id = new Guid("84b5562b-8bc4-4375-b0ec-8056f6fa918f"),
                            Description = "Payment via Discover credit card.",
                            Name = "Discover"
                        },
                        new
                        {
                            Id = new Guid("cc5dd77b-11c2-467b-aa18-f9b31bf0f89f"),
                            Description = "Payment through Japan Credit Bureau (JCB) card.",
                            Name = "JCB"
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("WishListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WishListId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.WishList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Customer", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.PaymentMethod", "PreferredPaymentMethod")
                        .WithMany()
                        .HasForeignKey("PreferredPaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("PreferredPaymentMethod");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Order", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.Address", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ShippingAddress");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Product", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.WishList", null)
                        .WithMany("Products")
                        .HasForeignKey("WishListId");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Review", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.WishList", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.WishList", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}