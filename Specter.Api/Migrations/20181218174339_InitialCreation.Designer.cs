﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Specter.Api.Data;

namespace Specter.Api.Migrations
{
    [DbContext(typeof(SpecterDb))]
    [Migration("20181218174339_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("Specter.Api.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Specter.Api.Data.Entities.Template", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("CreatedByUserId");

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<Guid?>("ForkId")
                        .HasDefaultValue(null);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<short>("Visibility");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("ForkId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("Specter.Api.Data.Entities.TemplateHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Reason");

                    b.Property<Guid>("TemplateId");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("TemplatesHistory");
                });

            modelBuilder.Entity("Specter.Api.Data.Entities.Timesheet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Time");

                    b.Property<Guid>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Timesheets");
                });

            modelBuilder.Entity("Specter.Api.Data.Entities.Template", b =>
                {
                    b.HasOne("Specter.Api.Data.Entities.ApplicationUser", "CreatedByUser")
                        .WithMany("Templates")
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("Specter.Api.Data.Entities.Template", "ForkTemplate")
                        .WithMany("Forks")
                        .HasForeignKey("ForkId");
                });

            modelBuilder.Entity("Specter.Api.Data.Entities.TemplateHistory", b =>
                {
                    b.HasOne("Specter.Api.Data.Entities.Template", "Template")
                        .WithMany("Edits")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Specter.Api.Data.Entities.Timesheet", b =>
                {
                    b.HasOne("Specter.Api.Data.Entities.ApplicationUser", "User")
                        .WithMany("Timesheets")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}