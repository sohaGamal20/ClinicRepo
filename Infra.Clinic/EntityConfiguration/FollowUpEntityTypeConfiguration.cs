﻿using Infra.Clinic.Entity;
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
    public class FollowUpEntityTypeConfiguration : IEntityTypeConfiguration<FollowUp>
    {
        public void Configure(EntityTypeBuilder<FollowUp> builder)
        {
            builder.ToTable("FollowUp");

            builder.HasKey(x => x.Id);
           
            builder.Property(x => x.PatientID).IsRequired();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Date).IsRequired();

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();
        }

    }
}
