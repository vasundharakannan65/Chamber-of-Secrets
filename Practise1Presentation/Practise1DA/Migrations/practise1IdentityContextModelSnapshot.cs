﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practise1DA.data;

namespace Practise1DA.Migrations
{
    [DbContext(typeof(practise1IdentityContext))]
    partial class practise1IdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Practise1DA.models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDraft")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("modifiedAt");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Practise1DA.models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDraft")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("modifiedAt");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Designation");
                });

            modelBuilder.Entity("Practise1DA.models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Practise1DA.models.EmployeeAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Employee_Address");
                });

            modelBuilder.Entity("Practise1DA.models.ProvidentFund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Pfamount")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("PFAmount");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Provident_Fund");
                });

            modelBuilder.Entity("Practise1DA.models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Allowance")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("Basic")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrossSalary")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("NetSalary")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("ProvidentFundId")
                        .HasColumnType("int")
                        .HasColumnName("Provident_FundId");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProvidentFundId");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("Practise1DA.models.Employee", b =>
                {
                    b.HasOne("Practise1DA.models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Practise1DA.models.Designation", "Designation")
                        .WithMany("Employees")
                        .HasForeignKey("DesignationId");

                    b.Navigation("Department");

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("Practise1DA.models.EmployeeAddress", b =>
                {
                    b.HasOne("Practise1DA.models.Employee", "Employee")
                        .WithMany("EmployeeAddresses")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Practise1DA.models.ProvidentFund", b =>
                {
                    b.HasOne("Practise1DA.models.Employee", "Employee")
                        .WithMany("ProvidentFunds")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Practise1DA.models.Salary", b =>
                {
                    b.HasOne("Practise1DA.models.Employee", "Employee")
                        .WithMany("Salaries")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Practise1DA.models.ProvidentFund", "ProvidentFund")
                        .WithMany("Salaries")
                        .HasForeignKey("ProvidentFundId");

                    b.Navigation("Employee");

                    b.Navigation("ProvidentFund");
                });

            modelBuilder.Entity("Practise1DA.models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Practise1DA.models.Designation", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Practise1DA.models.Employee", b =>
                {
                    b.Navigation("EmployeeAddresses");

                    b.Navigation("ProvidentFunds");

                    b.Navigation("Salaries");
                });

            modelBuilder.Entity("Practise1DA.models.ProvidentFund", b =>
                {
                    b.Navigation("Salaries");
                });
#pragma warning restore 612, 618
        }
    }
}
