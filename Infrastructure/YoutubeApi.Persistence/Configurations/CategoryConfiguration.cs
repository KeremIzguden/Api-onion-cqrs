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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new ()
            {
                Id = 1,
                Name = "Elektrik",
                ParentId = 0,
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = new DateTime(2024, 1, 1),
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                ParentId = 0,
                Priorty = 2,
                IsDeleted = false,
                CreatedDate = new DateTime(2024, 1, 1),
            };
            Category parent1 = new ()
            {
                Id = 3,
                Name = "Bilgisayar",
                ParentId = 1,
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = new DateTime(2024, 1, 1),
            };
            Category parent2 = new ()
            {
                Id = 4,
                Name = "Kadın",
                ParentId = 2,
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = new DateTime(2024, 1, 1),
            };

            builder.HasData(category1, category2, parent1, parent2);

        }
    }
}
