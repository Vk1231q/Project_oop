﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_oop.Models;

#nullable disable

namespace Project_oop.Migrations
{
    [DbContext(typeof(ContextModel))]
    [Migration("20230610030451_a")]
    partial class a
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_oop.Models.CityViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CityViewModels");
                });

            modelBuilder.Entity("Project_oop.Models.ClientViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParcelId")
                        .HasColumnType("int");

                    b.Property<int?>("ParcelViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParcelViewModelId");

                    b.ToTable("ClientViewModels");
                });

            modelBuilder.Entity("Project_oop.Models.ParcelViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Delievery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dispatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceivingPostOfficeId")
                        .HasColumnType("int");

                    b.Property<int>("SendingPostOfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ReceivingPostOfficeId");

                    b.HasIndex("SendingPostOfficeId");

                    b.ToTable("ParcelViewModels");
                });

            modelBuilder.Entity("Project_oop.Models.PersonnelViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostOfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostOfficeId");

                    b.ToTable("PersonnelViewModels");
                });

            modelBuilder.Entity("Project_oop.Models.PostOfficeViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PostOfficeViewModels");
                });

            modelBuilder.Entity("Project_oop.Models.ClientViewModel", b =>
                {
                    b.HasOne("Project_oop.Models.ParcelViewModel", null)
                        .WithMany("Clients")
                        .HasForeignKey("ParcelViewModelId");
                });

            modelBuilder.Entity("Project_oop.Models.ParcelViewModel", b =>
                {
                    b.HasOne("Project_oop.Models.ClientViewModel", "Client")
                        .WithMany("Parcels")
                        .HasForeignKey("ClientId");

                    b.HasOne("Project_oop.Models.PostOfficeViewModel", "ReceivingPostOffice")
                        .WithMany("ReceivedParcels")
                        .HasForeignKey("ReceivingPostOfficeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Project_oop.Models.PostOfficeViewModel", "SendingPostOffice")
                        .WithMany("SentParcels")
                        .HasForeignKey("SendingPostOfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("ReceivingPostOffice");

                    b.Navigation("SendingPostOffice");
                });

            modelBuilder.Entity("Project_oop.Models.PersonnelViewModel", b =>
                {
                    b.HasOne("Project_oop.Models.PostOfficeViewModel", "PostOffice")
                        .WithMany("Personnels")
                        .HasForeignKey("PostOfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostOffice");
                });

            modelBuilder.Entity("Project_oop.Models.PostOfficeViewModel", b =>
                {
                    b.HasOne("Project_oop.Models.CityViewModel", "City")
                        .WithMany("PostOffices")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Project_oop.Models.CityViewModel", b =>
                {
                    b.Navigation("PostOffices");
                });

            modelBuilder.Entity("Project_oop.Models.ClientViewModel", b =>
                {
                    b.Navigation("Parcels");
                });

            modelBuilder.Entity("Project_oop.Models.ParcelViewModel", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("Project_oop.Models.PostOfficeViewModel", b =>
                {
                    b.Navigation("Personnels");

                    b.Navigation("ReceivedParcels");

                    b.Navigation("SentParcels");
                });
#pragma warning restore 612, 618
        }
    }
}
