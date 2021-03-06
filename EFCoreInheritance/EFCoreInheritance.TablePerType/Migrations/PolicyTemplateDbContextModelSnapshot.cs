﻿// <auto-generated />
using System;
using EFCoreInheritance.TablePerType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreInheritance.TablePerType.Migrations
{
    [DbContext(typeof(PolicyTemplateDbContext))]
    partial class PolicyTemplateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EFCoreInheritance.Domain.Entities.OrganizationPolicyTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PolicyTemplateHierarchy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrganizationPolicyTemplate");
                });

            modelBuilder.Entity("EFCoreInheritance.Domain.Entities.RegionPolicyTemplate", b =>
                {
                    b.HasBaseType("EFCoreInheritance.Domain.Entities.OrganizationPolicyTemplate");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.ToTable("RegionPolicyTemplate");
                });

            modelBuilder.Entity("EFCoreInheritance.Domain.Entities.CountryPolicyTemplate", b =>
                {
                    b.HasBaseType("EFCoreInheritance.Domain.Entities.RegionPolicyTemplate");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.ToTable("CountryPolicyTemplate");
                });

            modelBuilder.Entity("EFCoreInheritance.Domain.Entities.RegionPolicyTemplate", b =>
                {
                    b.HasOne("EFCoreInheritance.Domain.Entities.OrganizationPolicyTemplate", null)
                        .WithOne()
                        .HasForeignKey("EFCoreInheritance.Domain.Entities.RegionPolicyTemplate", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreInheritance.Domain.Entities.CountryPolicyTemplate", b =>
                {
                    b.HasOne("EFCoreInheritance.Domain.Entities.RegionPolicyTemplate", null)
                        .WithOne()
                        .HasForeignKey("EFCoreInheritance.Domain.Entities.CountryPolicyTemplate", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
