﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using hotelcourseworkV2.Data;

#nullable disable

namespace hotelcourseworkV2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "37bde467-0fcf-48da-a019-c1376a68260a",
                            ConcurrencyStamp = "fe566a35-a285-4d6c-9633-36379b3aacc3",
                            Name = "Владелец сети",
                            NormalizedName = "ВЛАДЕЛЕЦ СЕТИ"
                        },
                        new
                        {
                            Id = "dbc5b035-7273-4e88-b1ca-8b12ae1adb86",
                            ConcurrencyStamp = "f0ca12d9-d52e-4023-a7aa-2bbbeee4ccde",
                            Name = "Директор",
                            NormalizedName = "ДИРЕКТОР"
                        },
                        new
                        {
                            Id = "b10a721c-e7a3-44e4-83fc-13189a9fe680",
                            ConcurrencyStamp = "dbe87e47-8118-4bed-bb9b-ca0cdc8a3c6b",
                            Name = "Горничные",
                            NormalizedName = "ГОРНИЧНЫЕ"
                        },
                        new
                        {
                            Id = "c26e91a0-0d7c-42b0-8c4b-e3c175a642a5",
                            ConcurrencyStamp = "f09ccdd6-08bb-44f1-9baa-b1a34bfb190f",
                            Name = "Повар в отеле",
                            NormalizedName = "ПОВАР В ОТЕЛЕ"
                        },
                        new
                        {
                            Id = "0bc0078f-52f6-418a-b26e-2013446d911b",
                            ConcurrencyStamp = "ce2cf883-6caa-4204-a0d5-8c4c2efe916a",
                            Name = "Сотрудник рецепции",
                            NormalizedName = "СОТРУДНИК РЕЦЕПЦИИ"
                        },
                        new
                        {
                            Id = "92fdc870-4085-4d0e-aadd-1382544346ab",
                            ConcurrencyStamp = "6332b101-3539-4349-99ed-6ef6462595ff",
                            Name = "Зарегистрированный клиент",
                            NormalizedName = "ЗАРЕГИСТРИРОВАННЫЙ КЛИЕНТ"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("user", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("user_role", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Composition", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("integer")
                        .HasColumnName("id_dish")
                        .HasColumnOrder(0);

                    b.Property<int>("IngredientId")
                        .HasColumnType("integer")
                        .HasColumnName("id_ingredient")
                        .HasColumnOrder(1);

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.HasKey("DishId");

                    b.HasIndex("IngredientId");

                    b.ToTable("composition");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_dish");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("recipe");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("title");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("unit");

                    b.Property<int>("Weight")
                        .HasColumnType("integer")
                        .HasColumnName("weight");

                    b.HasKey("Id");

                    b.ToTable("dish");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_guest");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("full_name");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)")
                        .HasColumnName("passport_number");

                    b.Property<string>("PassportSeries")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("passport_series");

                    b.HasKey("Id");

                    b.ToTable("quest");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_hotel");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("city");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_path");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name_hotel");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("owner_id");

                    b.Property<int>("Stars")
                        .HasColumnType("integer")
                        .HasColumnName("stars");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("street");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("hotel");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.HotelRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_h_t_r");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountPlace")
                        .HasColumnType("integer")
                        .HasColumnName("amount_place");

                    b.Property<int>("AmountRoom")
                        .HasColumnType("integer")
                        .HasColumnName("amount_room");

                    b.Property<int>("FloorRoom")
                        .HasColumnType("integer")
                        .HasColumnName("floor_room");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer")
                        .HasColumnName("id_hotel");

                    b.Property<int>("NumberRoom")
                        .HasColumnType("integer")
                        .HasColumnName("number_room");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<int>("TypeRoomId")
                        .HasColumnType("integer")
                        .HasColumnName("id_type_room");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("TypeRoomId");

                    b.ToTable("hotel_type_room");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_ingredient");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("title");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("unit");

                    b.HasKey("Id");

                    b.ToTable("ingredient");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_menu");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DishId")
                        .HasColumnType("integer")
                        .HasColumnName("id_dish");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer")
                        .HasColumnName("id_hotel");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("HotelId");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.ReserveRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_booking");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("arrival_date");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("booking_date");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("departure_date");

                    b.Property<int>("HotelTypeRoomId")
                        .HasColumnType("integer")
                        .HasColumnName("id_h_t_r");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<string>("QuestId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("id_quest");

                    b.HasKey("Id");

                    b.HasIndex("HotelTypeRoomId");

                    b.HasIndex("QuestId");

                    b.ToTable("booking");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_service");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name_service");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("type_service");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Басейн",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Спа",
                            Price = 250m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Сніданок",
                            Price = 300m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ескурсія",
                            Price = 700m
                        });
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.ServicesReserve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_b_s");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer")
                        .HasColumnName("amount_service");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<int>("TypeServiceId")
                        .HasColumnType("integer")
                        .HasColumnName("id_service");

                    b.HasKey("Id");

                    b.HasIndex("TypeServiceId");

                    b.ToTable("booking_service");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.TypeRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_type_room");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name_type_room");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price_room");

                    b.HasKey("Id");

                    b.ToTable("type_room");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Звичаний",
                            Price = 400m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Покращеный",
                            Price = 800m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Люкс",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Презеденський люкс",
                            Price = 2500m
                        });
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Account", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int?>("GuestId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("middlename");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasIndex("GuestId");

                    b.HasDiscriminator().HasValue("Account");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Composition", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelcourseworkV2.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Hotel", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.Account", "Owner")
                        .WithMany("Hotels")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.HotelRoom", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.Hotel", "hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelcourseworkV2.Models.TypeRoom", "typeRoom")
                        .WithMany()
                        .HasForeignKey("TypeRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hotel");

                    b.Navigation("typeRoom");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Menu", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelcourseworkV2.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.ReserveRoom", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.HotelRoom", "HotelTypeRoom")
                        .WithMany()
                        .HasForeignKey("HotelTypeRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelcourseworkV2.Models.Account", "Quest")
                        .WithMany()
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelTypeRoom");

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.ServicesReserve", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.Services", "TypeService")
                        .WithMany()
                        .HasForeignKey("TypeServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeService");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Account", b =>
                {
                    b.HasOne("hotelcourseworkV2.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("hotelcourseworkV2.Models.Account", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
