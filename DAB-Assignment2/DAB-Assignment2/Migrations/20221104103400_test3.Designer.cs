﻿// <auto-generated />
using System;
using DAB_Assignment2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    [DbContext(typeof(FacilitysContext))]
    [Migration("20221104103400_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("DAB_Assignment2.AvailableItems", b =>
                {
                    b.Property<int>("AvItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brænde")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CityHallPersonelEmpId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacilitysPK_FcName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FcName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Grill")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("LastMaintanice")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("NextMaintanice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Projector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Stole")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AvItemId");

                    b.HasIndex("CityHallPersonelEmpId");

                    b.HasIndex("FacilitysPK_FcName");

                    b.ToTable("AvailableItems");
                });

            modelBuilder.Entity("DAB_Assignment2.Bookings", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BookedFcName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("BookedFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("BookedTo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CityHallPersonelEmpId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookingId");

                    b.HasIndex("CityHallPersonelEmpId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DAB_Assignment2.CityHallPersonel", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpId");

                    b.ToTable("cityHallPersonels");
                });

            modelBuilder.Entity("DAB_Assignment2.Facilitys", b =>
                {
                    b.Property<string>("PK_FcName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BookingsBookingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CanBeBookedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClosetAdress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacilityDecrtiption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FcType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PK_FcName");

                    b.HasIndex("BookingsBookingId");

                    b.ToTable("Facilitys");
                });

            modelBuilder.Entity("DAB_Assignment2.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BookingsBookingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CVR")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserName");

                    b.HasIndex("BookingsBookingId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAB_Assignment2.AvailableItems", b =>
                {
                    b.HasOne("DAB_Assignment2.CityHallPersonel", "CityHallPersonel")
                        .WithMany()
                        .HasForeignKey("CityHallPersonelEmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_Assignment2.Facilitys", "Facilitys")
                        .WithMany()
                        .HasForeignKey("FacilitysPK_FcName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CityHallPersonel");

                    b.Navigation("Facilitys");
                });

            modelBuilder.Entity("DAB_Assignment2.Bookings", b =>
                {
                    b.HasOne("DAB_Assignment2.CityHallPersonel", null)
                        .WithMany("bookings")
                        .HasForeignKey("CityHallPersonelEmpId");
                });

            modelBuilder.Entity("DAB_Assignment2.Facilitys", b =>
                {
                    b.HasOne("DAB_Assignment2.Bookings", null)
                        .WithMany("Facilitys")
                        .HasForeignKey("BookingsBookingId");
                });

            modelBuilder.Entity("DAB_Assignment2.User", b =>
                {
                    b.HasOne("DAB_Assignment2.Bookings", null)
                        .WithMany("User")
                        .HasForeignKey("BookingsBookingId");
                });

            modelBuilder.Entity("DAB_Assignment2.Bookings", b =>
                {
                    b.Navigation("Facilitys");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAB_Assignment2.CityHallPersonel", b =>
                {
                    b.Navigation("bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
