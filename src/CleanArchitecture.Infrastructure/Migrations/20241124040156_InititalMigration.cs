using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InititalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreferredPaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_PaymentMethod_PreferredPaymentMethodId",
                        column: x => x.PreferredPaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Address_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Order_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishList_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WishListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_WishList_WishListId",
                        column: x => x.WishListId,
                        principalTable: "WishList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0334934e-989c-4a85-aa6a-8c3f9febf863"), "Luxury German automotive brand.", "BMW" },
                    { new Guid("12d29e13-14b9-45e6-ba80-4803c8fe405e"), "Leading cosmetics and skincare brand.", "L'Oréal" },
                    { new Guid("1e692736-b9df-4bfd-b361-9cba47c0d0fb"), "World-renowned soft drinks and beverages.", "Coca-Cola" },
                    { new Guid("22b8c0ee-7221-4b90-85b8-bc11f36e6b32"), "Environmentally conscious outdoor wear.", "Patagonia" },
                    { new Guid("2c6863ed-d72a-429f-b1fa-89d8dcd831ef"), "Trusted food and beverage conglomerate.", "Nestlé" },
                    { new Guid("3a411f34-bea1-4e96-be45-6b9f61dd591e"), "Global leader in athletic wear and footwear.", "Nike" },
                    { new Guid("47ba665b-0ee4-4b0a-adb7-729901451927"), "Iconic denim and casual wear.", "Levi's" },
                    { new Guid("5d0acf11-679a-454a-abcb-d806212b4e6c"), "Personal care and skincare products.", "Dove" },
                    { new Guid("5e7f7cf6-7f91-4aa8-ab88-b0343ec211c6"), "Reliable and affordable vehicles.", "Toyota" },
                    { new Guid("64a715b4-96ef-4dec-9096-198209190f36"), "Home improvement and hardware.", "Home Depot" },
                    { new Guid("688a0ad7-de03-4feb-b2da-a4fcd83212a2"), "Leading brand in consumer electronics and software.", "Apple" },
                    { new Guid("6f26a436-5117-4c1c-ad23-bed4b0f113ab"), "Luxury fashion brand known for stylish goods.", "Gucci" },
                    { new Guid("79753b01-1e5a-48f7-ba6a-e1051d0c1468"), "Entertainment and electronics innovations.", "Sony" },
                    { new Guid("a0ba4c52-c283-4d40-86e0-1468a3c2bd8f"), "Electric cars and sustainable energy.", "Tesla" },
                    { new Guid("a20dae24-c0a8-4dca-8a10-eec98659cb36"), "Innovative technology and computing solutions.", "Dell" },
                    { new Guid("a3398694-0f67-486f-9569-657af3c203b2"), "Innovative sports apparel and accessories.", "Adidas" },
                    { new Guid("abff7d2a-3d9d-444c-9f89-b2afa5523e1b"), "Pioneering electronics, home appliances, and mobile technology.", "Samsung" },
                    { new Guid("ad0d5ccd-f446-475d-886d-05972e0ee666"), "High-quality athletic apparel and footwear.", "Under Armour" },
                    { new Guid("b0242ce8-f189-4a51-972f-fbce5d088212"), "Affordable furniture and home goods.", "IKEA" },
                    { new Guid("b5093fc6-7431-4bb9-8a89-31a20a24e080"), "Popular coffeehouse chain.", "Starbucks" },
                    { new Guid("b5679ef0-0bdd-4c8d-a3cb-2108b3f4a5ab"), "Innovative consumer electronics and lighting.", "Philips" },
                    { new Guid("c296cdc6-72be-49cf-ba21-890df63c1846"), "Global beverage and snack brand.", "Pepsi" },
                    { new Guid("c53bfff6-2bd4-481d-b019-c0c2835710b6"), "Trusted skincare and beauty products.", "Nivea" },
                    { new Guid("df92aa1b-88bf-41c9-ac11-3db74c5ecb85"), "Versatile American automotive brand.", "Ford" },
                    { new Guid("f02e9206-e806-4f48-9386-6fcf8ee87186"), "Popular brand for professional makeup.", "MAC Cosmetics" },
                    { new Guid("fc20f7ad-22ce-45f7-a92c-c6e908cc0675"), "Premium outdoor clothing and gear.", "The North Face" },
                    { new Guid("fc55625f-dc45-4604-8ce8-511b700a657d"), "Italian brand known for stylish kitchen appliances.", "Smeg" },
                    { new Guid("fe72646c-d593-4e49-ab77-743512b1db14"), "Outdoor and sportswear brand.", "Columbia" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0b3f1c9a-0b30-44d4-83f5-ec923aa830d1"), "Food, toys, and accessories for pets of all kinds.", "Pet Supplies" },
                    { new Guid("18130b4f-9808-4863-91a6-f3e9d27d1e60"), "Furniture, decor, kitchen appliances, and tools for every home.", "Home & Kitchen" },
                    { new Guid("2b879802-3891-4d5a-be09-5bf068130461"), "Latest gadgets, mobile devices, and home electronics.", "Electronics" },
                    { new Guid("2ba0d19b-38c4-42be-a6f1-2fb0b88f86a1"), "Equipment and tools for industrial and scientific use.", "Industrial & Scientific" },
                    { new Guid("328c04f8-23cc-4161-a628-b30d884052fb"), "Crafting supplies and handmade items from artisans.", "Handmade & Craft Supplies" },
                    { new Guid("4633c324-9666-4226-8a8f-9291bd924cce"), "Clothing, footwear, and accessories for men, women, and kids.", "Fashion" },
                    { new Guid("8145e74b-9ea0-42cb-bdb0-c4bd58080216"), "A wide variety of genres and titles for all readers.", "Books" },
                    { new Guid("9305136d-e265-4460-a036-99efab91a840"), "Everyday food items, gourmet foods, and specialty ingredients.", "Grocery & Gourmet Food" },
                    { new Guid("94ea707a-f6ec-45dc-b78c-2c903afdf5de"), "Fun and educational toys, board games, and puzzles for kids and adults.", "Toys & Games" },
                    { new Guid("95107e82-30f2-46e3-adb3-bc2e8927d1a2"), "Vitamins, supplements, health monitoring devices, and wellness products.", "Health & Wellness" },
                    { new Guid("9b0f9f55-9619-49e4-bf53-d6ca4552878f"), "Gardening tools, outdoor furniture, and lawn care essentials.", "Garden & Outdoor" },
                    { new Guid("9b183a74-1c91-4db9-b44f-3c897fad8550"), "Laptops, desktops, peripherals, and computer accessories.", "Computers & Accessories" },
                    { new Guid("a62eee60-4eff-4152-8d07-0e8bcade88c6"), "Sports equipment, fitness gear, and outdoor adventure essentials.", "Sports & Outdoors" },
                    { new Guid("b1fb2c57-8fd1-4e8f-a0be-798075f09157"), "Skincare, makeup, grooming, and personal hygiene products.", "Beauty & Personal Care" },
                    { new Guid("ba74d5dd-5474-42f9-990c-016057b8ad8a"), "Stationery, furniture, and tech for office use.", "Office Supplies" },
                    { new Guid("cc7e133c-9181-4997-94e2-e8055b386752"), "Instruments, accessories, and sound equipment for musicians.", "Musical Instruments" },
                    { new Guid("d1e38390-087b-4490-b89e-14e32722db56"), "Car accessories, tools, and parts for vehicle maintenance.", "Automotive" },
                    { new Guid("d8f83bd8-20d3-46ee-9ce5-57ac8a4c3ea8"), "Essentials for babies, including toys, diapers, and feeding supplies.", "Baby Products" },
                    { new Guid("e4c5f396-b35a-4b8b-8a3c-584545cb889f"), "Gaming consoles, video games, and accessories for gamers.", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("032b987f-b214-4e00-8c22-12d315df189b"), "Pay using Visa, MasterCard, or American Express credit cards.", "Credit Card" },
                    { new Guid("06b42fac-7d25-4637-83a7-f6230e841f0c"), "Pay with Bitcoin, Ethereum, and other cryptocurrencies.", "Cryptocurrency" },
                    { new Guid("0d54415d-fe6a-477f-9a67-624b75890fd9"), "Fast and secure payments with Apple Pay.", "Apple Pay" },
                    { new Guid("163d1cc9-1e52-4ecb-a8c5-055422356f65"), "Pay with cash upon delivery of goods.", "Cash on Delivery" },
                    { new Guid("2a59655a-4374-495a-b3d3-ff712aa0fcd8"), "Redeemable gift card for online purchases.", "Gift Card" },
                    { new Guid("2c70ab8c-0807-4c07-a7e7-dacab4c6908a"), "Secure payments through Samsung Pay.", "Samsung Pay" },
                    { new Guid("4a6b10a7-4280-48ba-acd0-49893772b317"), "Payment through Alipay, popular in China.", "Alipay" },
                    { new Guid("62ff3459-bd4b-485e-829e-7f6d15ded8b1"), "Direct bank transfer for larger transactions.", "Bank Transfer" },
                    { new Guid("6ab8da21-bac5-4653-b6f9-8fba103efdce"), "Flexible payment options with Klarna.", "Klarna" },
                    { new Guid("82ca2182-434a-417c-83b1-a0e88c1a95fe"), "Checkout securely using your Amazon account.", "Amazon Pay" },
                    { new Guid("84b5562b-8bc4-4375-b0ec-8056f6fa918f"), "Payment via Discover credit card.", "Discover" },
                    { new Guid("893657a5-cfe0-4c26-bc07-899489541d34"), "Pay using Visa, MasterCard, or other bank debit cards.", "Debit Card" },
                    { new Guid("92d520b8-fcfc-4cea-a7ad-654f2f3b89db"), "Fast and secure checkout through Shopify's Shop Pay.", "Shop Pay" },
                    { new Guid("9513eeb2-9b05-42fa-ae35-10536ca3fef1"), "Secure payments through UnionPay.", "UnionPay" },
                    { new Guid("959a510a-4c27-4e17-9776-14b15987a473"), "Buy now, pay later with Afterpay installments.", "Afterpay" },
                    { new Guid("9ae2a268-ba74-4285-8735-07f31d73fdb6"), "Convenient payment through WeChat Pay.", "WeChat Pay" },
                    { new Guid("a59729d3-a59f-49cf-90ed-0dd1c8bdd09d"), "Pay through Venmo, convenient for US customers.", "Venmo" },
                    { new Guid("bb8b4999-c393-498a-881c-ab4303b7862e"), "Convenient payments through Google Pay.", "Google Pay" },
                    { new Guid("cc5dd77b-11c2-467b-aa18-f9b31bf0f89f"), "Payment through Japan Credit Bureau (JCB) card.", "JCB" },
                    { new Guid("f53e7c41-520f-49f2-b7f0-db57a0197b6f"), "Secure payment via PayPal account.", "PayPal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PreferredPaymentMethodId",
                table: "Customers",
                column: "PreferredPaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StatusId",
                table: "Order",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_WishListId",
                table: "Product",
                column: "WishListId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductId",
                table: "Review",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_CustomerId",
                table: "WishList",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "PaymentMethod");
        }
    }
}
