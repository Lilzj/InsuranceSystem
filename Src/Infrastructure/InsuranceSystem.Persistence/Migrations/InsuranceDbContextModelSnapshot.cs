﻿// <auto-generated />
using System;
using InsuranceSystem.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceSystem.Persistence.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    partial class InsuranceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceSystem.Domain.Claim", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClaimsStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonModified")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("InsuranceSystem.Domain.Expense", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ClaimId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpenseType")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonModified")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("InsuranceSystem.Domain.Policy", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolicyNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonModified")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("InsuranceSystem.Domain.Expense", b =>
                {
                    b.HasOne("InsuranceSystem.Domain.Claim", null)
                        .WithMany("Expenses")
                        .HasForeignKey("ClaimId");
                });

            modelBuilder.Entity("InsuranceSystem.Domain.Claim", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}