using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTMS.Data.Mapping
{
    public class PartnerMap : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.Property(c => c.ShortName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.LongName)
                .HasMaxLength(11)
                .IsRequired();

            builder.HasKey(c => c.ID);
        }
    }
}
