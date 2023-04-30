using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class ClinicUserEntityTypeConfiguration : IEntityTypeConfiguration<ClinicUser>
    {
        public void Configure(EntityTypeBuilder<ClinicUser> builder)
        {
            builder.ToTable("ClinicUser");
            builder.HasKey(t => t.Id);
            builder.Property(t=>t.UserName).IsRequired();
            builder.Property(t => t.Password).IsRequired();

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();

            builder.HasData(
                new {Id=1l, UserName="Wafaa", DisplayName="Dr. Wafaa", Password="Wafaa" },
                new { Id = 2l, UserName = "User", DisplayName = "User", Password = "User" });
        }
    }
}
