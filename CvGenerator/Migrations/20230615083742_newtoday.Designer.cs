﻿// <auto-generated />
using System;
using CvGenerator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CvGenerator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230615083742_newtoday")]
    partial class newtoday
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CvGenerator.Models.All", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("All");
                });

            modelBuilder.Entity("CvGenerator.Models.CertificationAndTrainings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("CertificationAndTrainings");
                });

            modelBuilder.Entity("CvGenerator.Models.Descriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<string>("Des")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("CvGenerator.Models.Educations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("CvGenerator.Models.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("CvGenerator.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("CvGenerator.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CvGenerator.Models.WorkExperiences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AllId")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("CvGenerator.Models.CertificationAndTrainings", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("CertificationAndTraining")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.Descriptions", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("Description")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.Educations", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("Education")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.Reference", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("References")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.Skill", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("Skills")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.User", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("User")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.WorkExperiences", b =>
                {
                    b.HasOne("CvGenerator.Models.All", null)
                        .WithMany("WorkExperience")
                        .HasForeignKey("AllId");
                });

            modelBuilder.Entity("CvGenerator.Models.All", b =>
                {
                    b.Navigation("CertificationAndTraining");

                    b.Navigation("Description");

                    b.Navigation("Education");

                    b.Navigation("References");

                    b.Navigation("Skills");

                    b.Navigation("User");

                    b.Navigation("WorkExperience");
                });
#pragma warning restore 612, 618
        }
    }
}
