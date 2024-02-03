﻿// <auto-generated />
using System;
using BlogWebSite.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogWebSiteDataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240203205558_update_BannerModel")]
    partial class update_BannerModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogWebSite_Entity.AboutModel", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutID"), 1L, 1);

                    b.Property<string>("AboutPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutShortText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserStatusTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("BlogWebSite_Entity.BannerModel", b =>
                {
                    b.Property<int>("BannerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BannerID"), 1L, 1);

                    b.Property<string>("BackGroundPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerShortAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerShortAbout1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortHelloText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BannerID");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("BlogWebSite_Entity.BlogModel", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogID"), 1L, 1);

                    b.Property<DateTime?>("BlogDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("BlogID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogWebSite_Entity.CategoryModel", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("BlogWebSite_Entity.CommentModel", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"), 1L, 1);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CommentID");

                    b.HasIndex("BlogID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("BlogWebSite_Entity.CommunicationModel", b =>
                {
                    b.Property<int>("ComID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComID"), 1L, 1);

                    b.Property<string>("ComDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComID");

                    b.ToTable("Communication");
                });

            modelBuilder.Entity("BlogWebSite_Entity.FeatureCounterModel", b =>
                {
                    b.Property<int>("FeatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureID"), 1L, 1);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdditionalLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadArticlePage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadBook")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureID");

                    b.ToTable("FeatureCounters");
                });

            modelBuilder.Entity("BlogWebSite_Entity.FooterModel", b =>
                {
                    b.Property<int>("FooterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooterID"), 1L, 1);

                    b.Property<string>("FooterImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FooterID");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("BlogWebSite_Entity.MailModel", b =>
                {
                    b.Property<int>("MailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MailID"), 1L, 1);

                    b.Property<int?>("Port")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMTP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderMailPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MailID");

                    b.ToTable("Mails");
                });

            modelBuilder.Entity("BlogWebSite_Entity.QuotesModel", b =>
                {
                    b.Property<int>("QuotesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuotesID"), 1L, 1);

                    b.Property<string>("QuotesDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuotesTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuotesWriterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("QuotesID");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("BlogWebSite_Entity.SocialMediaModel", b =>
                {
                    b.Property<int>("SocialMediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaID"), 1L, 1);

                    b.Property<string>("InstagramLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaID");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("BlogWebSite_Entity.UserModel", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlogWebSite_Entity.BlogModel", b =>
                {
                    b.HasOne("BlogWebSite_Entity.CategoryModel", "Category")
                        .WithMany("Blog")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogWebSite_Entity.CommentModel", b =>
                {
                    b.HasOne("BlogWebSite_Entity.BlogModel", "Blog")
                        .WithMany("Comment")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("BlogWebSite_Entity.BlogModel", b =>
                {
                    b.Navigation("Comment");
                });

            modelBuilder.Entity("BlogWebSite_Entity.CategoryModel", b =>
                {
                    b.Navigation("Blog");
                });
#pragma warning restore 612, 618
        }
    }
}
