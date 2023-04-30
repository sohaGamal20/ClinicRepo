using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class DiscountsEntityTypeConfiguration : IEntityTypeConfiguration<DiscountLookup>
    {
        public void Configure(EntityTypeBuilder<DiscountLookup> builder)
        {
            builder.ToTable("Discounts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Agency).IsRequired();
            builder.Property(x => x.DiscountPercentage).IsRequired();

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();

            builder.HasData(
               new
               {
                   Id= 1L,
                   Agency = "nkabt mohndsen",
                   DiscountPercentage = 25.0
               },
                new
                {
                    Id = 2L,
                    Agency = "nkabt atba2",
                    DiscountPercentage = 20.0
                },
                 new
                 {
                     Id = 3L,
                     Agency = "nkabt siadla",
                     DiscountPercentage = 20.0
                 }
               );
        }
       
    }
}
