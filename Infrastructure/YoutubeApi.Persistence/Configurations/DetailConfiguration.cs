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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Randomizer.Seed = new Random(123);
            Faker faker = new ("tr");
            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                CreatedDate = new DateTime(2024, 1, 1),
                IsDeleted = false,
            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(2),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                CreatedDate = new DateTime(2024, 1, 1),
                IsDeleted = true,
            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 4,
                CreatedDate = new DateTime(2024, 1, 1),
                IsDeleted = false,
            };
            
            

        }
    }
}
