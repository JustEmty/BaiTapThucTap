﻿// <auto-generated />
using System;
using BaiTapThucTap.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241017094908_ChangeDateTimeToDateOnlyInEntryStorageForm")]
    partial class ChangeDateTimeToDateOnlyInEntryStorageForm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BaiTapThucTap.Models.CalculationUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CalculationUnitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Ten_Don_Vi_Tinh");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ghi_Chu");

                    b.HasKey("Id");

                    b.HasIndex("CalculationUnitName")
                        .IsUnique();

                    b.ToTable("tbl_DM_Don_Vi_Tinh");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.EntryStorageForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("EntryStorageFormDate")
                        .HasColumnType("date")
                        .HasColumnName("Ngay_Nhap_Kho");

                    b.Property<string>("EntryStorageFormId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("So_Phieu_Nhap_Kho");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ghi_Chu");

                    b.Property<int>("StorageId")
                        .HasColumnType("int")
                        .HasColumnName("Kho_ID");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("NCC_ID");

                    b.HasKey("Id");

                    b.HasIndex("EntryStorageFormId")
                        .IsUnique();

                    b.HasIndex("StorageId");

                    b.HasIndex("SupplierId");

                    b.ToTable("tbl_DM_Nhap_Kho");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.EntryStorageFormRawData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EntryStorageFormId")
                        .HasColumnType("int")
                        .HasColumnName("Nhap_Kho_ID");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Don_Gia_Nhap");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("San_Pham_ID");

                    b.Property<int?>("Quantities")
                        .HasColumnType("int")
                        .HasColumnName("SL_Nhap");

                    b.HasKey("Id");

                    b.HasIndex("EntryStorageFormId");

                    b.HasIndex("ProductId");

                    b.ToTable("tbl_DM_Nhap_Kho_Raw_Data");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Ma_San_Pham");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalculationUnitId")
                        .HasColumnType("int")
                        .HasColumnName("Don_Vi_Tinh_ID");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ghi_Chu");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("Loai_San_Pham_ID");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ten_San_Pham");

                    b.HasKey("Id");

                    b.HasIndex("CalculationUnitId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("tbl_DM_San_Pham");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Ma_LSP");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ghi_Chu");

                    b.Property<string>("ProductCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Ten_LSP");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryName")
                        .IsUnique();

                    b.ToTable("tbl_DM_Loai_San_Pham");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ghi_Chu");

                    b.Property<string>("StorageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Ten_Kho");

                    b.HasKey("Id");

                    b.HasIndex("StorageName")
                        .IsUnique();

                    b.ToTable("tbl_DM_Kho");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.StorageUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LoginCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Ma_Dang_Nhap");

                    b.Property<int>("StorageId")
                        .HasColumnType("int")
                        .HasColumnName("Kho_ID");

                    b.HasKey("Id");

                    b.HasIndex("LoginCode")
                        .IsUnique();

                    b.HasIndex("StorageId")
                        .IsUnique();

                    b.ToTable("tbl_DM_Kho_User");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Ma_NCC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ghi_Chu");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Ten_NCC");

                    b.HasKey("Id");

                    b.HasIndex("SupplierName")
                        .IsUnique();

                    b.ToTable("tbl_DM_NCC");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.EntryStorageForm", b =>
                {
                    b.HasOne("BaiTapThucTap.Models.Storage", "Storage")
                        .WithMany()
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiTapThucTap.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Storage");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.EntryStorageFormRawData", b =>
                {
                    b.HasOne("BaiTapThucTap.Models.EntryStorageForm", "EntryStorageForm")
                        .WithMany()
                        .HasForeignKey("EntryStorageFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiTapThucTap.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntryStorageForm");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.Product", b =>
                {
                    b.HasOne("BaiTapThucTap.Models.CalculationUnit", "CalculationUnit")
                        .WithMany("Products")
                        .HasForeignKey("CalculationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiTapThucTap.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalculationUnit");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.StorageUser", b =>
                {
                    b.HasOne("BaiTapThucTap.Models.Storage", "Storage")
                        .WithMany()
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.CalculationUnit", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BaiTapThucTap.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}