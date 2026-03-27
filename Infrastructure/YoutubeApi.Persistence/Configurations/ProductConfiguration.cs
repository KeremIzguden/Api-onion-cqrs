using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Randomizer.Seed = new Random(123);
            Faker faker = new ("tr");
            Product product1 = new ()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Price = faker.Finance.Amount(10,100),
                Discount = faker.Random.Decimal(0, 10),
                CreatedDate = new DateTime(2024, 1, 1),
                IsDeleted = false,
            };
            Product product2 = new ()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 3,
                Price = faker.Finance.Amount(10,100),
                Discount = faker.Random.Decimal(0, 10),
                CreatedDate = new DateTime(2024, 1, 1),
                IsDeleted = false,
            };

            builder.Property(p => p.Price).HasPrecision(18, 2);
            builder.Property(p => p.Discount).HasPrecision(18, 2);
            builder.HasData(product1, product2);

        }
    }
}
