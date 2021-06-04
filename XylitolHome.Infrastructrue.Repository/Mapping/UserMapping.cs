using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using XylitolHome.Common;
using XylitolHome.Domain.Entities;

namespace XylitolHome.Infrastructrue.Repository.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("UserInfo");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.IsDeleted)
                .HasColumnName("IsDeleted")
                .HasColumnType(ColumnType.BIT)
                .IsRequired(true)
                .HasDefaultValue(true)
                .HasMaxLength(1);

            builder.Property(a => a.LastEditTime)
                .HasColumnName("LastEditTime")
                .HasColumnType(ColumnType.DATETIME);

            builder.Property(a => a.Mobile)
                .HasColumnName("Mobile")
                .HasColumnType(ColumnType.CHAR)
                .HasMaxLength(11);

            builder.Property(a => a.NickName)
                .HasColumnName("NickName")
                .HasColumnType(ColumnType.VARCHAR)
                .HasMaxLength(50);

            builder.Property(a => a.Password)
                .HasColumnName("Password")
                .HasColumnType(ColumnType.CHAR)
                .HasMaxLength(32);

            builder.Property(a => a.CreateDate)
                .HasColumnName("CreateDate")
                .HasColumnType(ColumnType.DATETIME)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
