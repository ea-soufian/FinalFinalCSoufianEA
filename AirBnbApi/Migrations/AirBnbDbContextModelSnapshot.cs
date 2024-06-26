﻿// <auto-generated />
using System;
using AirBnbApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AirBnbApi.Migrations
{
    [DbContext(typeof(AirBnbDbContext))]
    partial class AirBnbDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AirBnbApi.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Soufianallali@live.nl",
                            FirstName = "Soufian",
                            LastName = "Allali"
                        },
                        new
                        {
                            Id = 2,
                            Email = "arjenrobben@hotmail.com",
                            FirstName = "Arjen",
                            LastName = "Robben"
                        },
                        new
                        {
                            Id = 3,
                            Email = "PeterGriffin@mail.com",
                            FirstName = "Peter",
                            LastName = "Griffin"
                        },
                        new
                        {
                            Id = 4,
                            Email = "lil-mike@yahoo.pl",
                            FirstName = "Mike",
                            LastName = "Chrysler"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Romano@icloud.com",
                            FirstName = "Romano",
                            LastName = "Dekker"
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCover = false,
                            Url = "https://dudewipes.com/cdn/shop/articles/gigachad.jpg?v=1667928905&width=2048"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = false,
                            Url = "https://img.a.transfermarkt.technology/portrait/big/4380-1707301752.jpg?lm=1"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/db/70/main-courtyard.jpg?w=1200&h=-1&s=1"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-018.jpg"
                        },
                        new
                        {
                            Id = 5,
                            IsCover = false,
                            Url = "https://images.mubicdn.net/images/cast_member/516454/cache-873696-1682862099/image-w856.jpg?size=800x"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = false,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBcLE7OvpUSniu2afNLivD0QIj1iF937vrBck6gNhxzg&s"
                        },
                        new
                        {
                            Id = 7,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/db/65/main-courtyard.jpg?w=1200&h=-1&s=1"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/4e/tv-lounge.jpg?w=1200&h=-1&s=1"
                        },
                        new
                        {
                            Id = 9,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/29/tv-lounge.jpg?w=1200&h=-1&s=1"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/19/breakfast.jpg?w=1200&h=-1&s=1"
                        },
                        new
                        {
                            Id = 11,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2013-042.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-030.jpg"
                        },
                        new
                        {
                            Id = 13,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-027.jpg"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-023.jpg"
                        },
                        new
                        {
                            Id = 15,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://a0.muscache.com/im/pictures/fd4517b6-5a66-477d-a8b7-1e4df1faca20.jpg?im_w=960"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://a0.muscache.com/im/pictures/c1217bc8-11f8-442f-b54d-a59bdf614d94.jpg?im_w=720"
                        },
                        new
                        {
                            Id = 17,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://a0.muscache.com/im/pictures/hosting/Hosting-1071775108870039186/original/86142eff-8836-4c06-827e-9469507034c7.jpeg?im_w=720"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://a0.muscache.com/im/pictures/hosting/Hosting-1071775108870039186/original/2d941e7e-9547-4306-a36c-e7407adfb38b.jpeg?im_w=720"
                        },
                        new
                        {
                            Id = 19,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076262.jpg?k=075189c4641d0837d17027d698e8774307be2495aa3b4401861c869f81d80d5a&o=&hp=1"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076867.jpg?k=3866c0c872b39701bca6312fd1cd8c6275a059d60db7e2a477f457edfcc0bd44&o=&hp=1"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076610.jpg?k=0301c08bcd9f7948fa5eab92641e70a98b770e4a34e00904758a334edb3bbf14&o=&hp=1"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480587.jpg?k=199f2fdf3a84e8ae5d42d07f28b7723b528cbe56599b24390d9adfd58ae3e310&o=&hp=1"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480533.jpg?k=aa1a08a273f22759d26535a734b49ee64cf5c8bb09e8b7e9e34355acdd3f54fa&o=&hp=1"
                        },
                        new
                        {
                            Id = 24,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480541.jpg?k=4e1eecf085e4c998a9e12a85e73f99efcabb2bf2b4c4e686f619d7841fa75cf9&o=&hp=1"
                        },
                        new
                        {
                            Id = 25,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480570.jpg?k=e1f152ff5c77f61eb346a58a80d28bab4200998e9e08692e6c15a8abfb5d4225&o=&hp=1"
                        },
                        new
                        {
                            Id = 26,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/453585868.jpg?k=20bb8fa2ae2d2fcf6017ae55640527926c5b13cc07c2abf422fa7cfb2f9de94f&o=&hp=1"
                        },
                        new
                        {
                            Id = 27,
                            IsCover = false,
                            LocationId = 6,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/453585870.jpg?k=892bad7a75f60d012122f9ebf94470ebbe83568f266b3967ed236fdf96dd2193&o=&hp=1"
                        },
                        new
                        {
                            Id = 28,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233389.jpg?ca=6&ce=1&s=1024x768"
                        },
                        new
                        {
                            Id = 29,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17121115240060335944.jpg?ca=6&ce=1&s=1024x768"
                        },
                        new
                        {
                            Id = 30,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233383.jpg?ca=6&ce=1&s=1024x768"
                        },
                        new
                        {
                            Id = 31,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233400.jpg?ca=6&ce=1&s=1024x768"
                        },
                        new
                        {
                            Id = 32,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/f4cc2abd-1643-47f3-9810-f5010aadb2a0.jpeg?im_w=960"
                        },
                        new
                        {
                            Id = 33,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/8b886668-8d9a-46db-815f-8ca2e0db9734.jpeg?im_w=1200"
                        },
                        new
                        {
                            Id = 34,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/1b2d877e-4aee-4cd4-894b-db9d05710daf.jpeg?im_w=1200"
                        },
                        new
                        {
                            Id = 35,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/7764da9e-2ff7-42ba-9177-decf2de4754e.jpeg?im_w=1200"
                        },
                        new
                        {
                            Id = 36,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/166571658.jpg?k=f650daa2d249b002682dddd40bb83a47c1c534e03b7b48b579aa81d3c9735fec&o=&hp=1"
                        },
                        new
                        {
                            Id = 37,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/289436171.jpg?k=71118a495360716afc1c7b63bf5a4eb6ff5a791611d00d4291e44021c9447295&o=&hp=1"
                        },
                        new
                        {
                            Id = 38,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/410650472.jpg?k=e88fc20141f536b7c9f2a3684f3ce75d8f6d18f0f14ce8bfdfc678e29bdc7d7b&o=&hp=1"
                        },
                        new
                        {
                            Id = 39,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/415229786.jpg?k=e04c9234b60a70298fc7625db879aca07cf974ebc06a47c76dbef7976ed8ecc6&o=&hp=1"
                        },
                        new
                        {
                            Id = 40,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420276132.jpg?k=9199e10fd3fcf720884af957efc99e3bdcb7ffc7559d6aaf12d61ce27d268a06&o=&hp=1"
                        },
                        new
                        {
                            Id = 41,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420276963.jpg?k=f6aa942a008ea50b624ebe903088398bc9133592d41d1d21957ee2d08bcc58d9&o=&hp=1"
                        },
                        new
                        {
                            Id = 42,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420305441.jpg?k=29cdb5b55def034025a0b03668cf340aa9d5cc22d1836ff529e8ab3a580118e7&o=&hp=1"
                        },
                        new
                        {
                            Id = 43,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/422013299.jpg?k=c151f5c872eb52a5d1568c84d16e6127fa8295e86160add201b75d38c7361e87&o=&hp=1"
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId")
                        .IsUnique();

                    b.ToTable("Landlord");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            AvatarId = 1,
                            FirstName = "Soufian",
                            LastName = "Allali"
                        },
                        new
                        {
                            Id = 2,
                            Age = 32,
                            AvatarId = 2,
                            FirstName = "Robin",
                            LastName = "van Persie"
                        },
                        new
                        {
                            Id = 3,
                            Age = 28,
                            AvatarId = 5,
                            FirstName = "Zlatan Ibrahimovic",
                            LastName = "Parker"
                        },
                        new
                        {
                            Id = 4,
                            Age = 45,
                            AvatarId = 6,
                            FirstName = "Lionel",
                            LastName = "Messi"
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Riad Tifawin for you who dream of Orientation and simple pleasures. Beyond the ramparts of the 'Bab Doukkala' gate",
                            Features = 36,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 119f,
                            Rooms = 2,
                            SubTitle = "Serenity Sanctuary",
                            Title = "Marrakech Cottage",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Experience a contemporary and chic apartment nestled in the vibrant pulse of the city center, conveniently situated near all prominent attractions.",
                            Features = 12,
                            LandlordId = 2,
                            NumberOfGuests = 6,
                            PricePerDay = 169f,
                            Rooms = 3,
                            SubTitle = "Cutting-edge Elegance",
                            Title = "Urban Loft Amsterdam city",
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "On a horsefarm near the sea, a newly renovated appartment of 60sm with two bedrooms and a loft. ",
                            Features = 28,
                            LandlordId = 3,
                            NumberOfGuests = 8,
                            PricePerDay = 212f,
                            Rooms = 4,
                            SubTitle = "Nordic Haven Retreat",
                            Title = "Charming chalet-style flat in Arild",
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Boasting garden views, Colorful Private Room Oasis features accommodation with a terrace and a balcony, around 2.1 km from Catherine Hall Beach.",
                            Features = 36,
                            LandlordId = 4,
                            NumberOfGuests = 2,
                            PricePerDay = 56f,
                            Rooms = 1,
                            SubTitle = "Authentic & Colorful",
                            Title = "Colorful Private Room",
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            Description = "Named after the crystal-clear waters of Mediterranean Sea, Crystal Luxury Sunset Resort & Spa has a seafront location and a private 250 metres long sandy beach. ",
                            Features = 60,
                            LandlordId = 1,
                            NumberOfGuests = 100,
                            PricePerDay = 269f,
                            Rooms = 50,
                            SubTitle = "Ultimate All Inclusive",
                            Title = "Crystal Sunset Luxury Resort",
                            Type = 4
                        },
                        new
                        {
                            Id = 6,
                            Description = "The villa with a terrace and pool views features 6 bedrooms, 2 living rooms, a flat-screen TV, an equipped kitchen with a microwave and a fridge, and 6 bathrooms with a bidet. The property has an outdoor dining area.",
                            Features = 30,
                            LandlordId = 2,
                            NumberOfGuests = 6,
                            PricePerDay = 304f,
                            Rooms = 5,
                            SubTitle = "Cozy Retreat Abroad",
                            Title = "Family Villa",
                            Type = 5
                        },
                        new
                        {
                            Id = 7,
                            Description = "Naiya Beach Bungalow is natural and tropical in design, secluded in relaxing atmosphere of a big garden, far away from all the hustle.",
                            Features = 44,
                            LandlordId = 3,
                            NumberOfGuests = 6,
                            PricePerDay = 189f,
                            Rooms = 3,
                            SubTitle = "Sun, Sand & Apes",
                            Title = "Naiya Beach Bungalow",
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Experience luxury living in this stunning penthouse apartment with breathtaking panoramic city views.",
                            Features = 28,
                            LandlordId = 4,
                            NumberOfGuests = 8,
                            PricePerDay = 354f,
                            Rooms = 4,
                            SubTitle = "Luxury & Stunning Views",
                            Title = "Beach House",
                            Type = 0
                        },
                        new
                        {
                            Id = 9,
                            Description = "Unwind in this serene woodland chalet, offering a perfect retreat for nature lovers seeking peace and tranquility.",
                            Features = 22,
                            LandlordId = 1,
                            NumberOfGuests = 6,
                            PricePerDay = 216f,
                            Rooms = 3,
                            SubTitle = "Surrounded by nature",
                            Title = "Chalet in the forest",
                            Type = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "Damme Golf & Country Club is located 44 km away from the bed & breakfast, while Minnewater is situated 45 km further. The nearest airport, Antwerp International Airport, is 64 km from Artist's Loft & Garden.",
                            Features = 13,
                            LandlordId = 2,
                            NumberOfGuests = 4,
                            PricePerDay = 120f,
                            Rooms = 2,
                            SubTitle = "creatieve setting",
                            Title = "Loft for artists",
                            Type = 0
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Discount = 10f,
                            EndTime = new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartTime = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Discount = 5f,
                            EndTime = new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 3,
                            StartTime = new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            Discount = 0f,
                            EndTime = new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 7,
                            StartTime = new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Image", b =>
                {
                    b.HasOne("AirBnbApi.Model.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AirBnbApi.Model.Landlord", b =>
                {
                    b.HasOne("AirBnbApi.Model.Image", "Avatar")
                        .WithOne("Landlord")
                        .HasForeignKey("AirBnbApi.Model.Landlord", "AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("AirBnbApi.Model.Location", b =>
                {
                    b.HasOne("AirBnbApi.Model.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("AirBnbApi.Model.Reservation", b =>
                {
                    b.HasOne("AirBnbApi.Model.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirBnbApi.Model.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AirBnbApi.Model.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AirBnbApi.Model.Image", b =>
                {
                    b.Navigation("Landlord")
                        .IsRequired();
                });

            modelBuilder.Entity("AirBnbApi.Model.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("AirBnbApi.Model.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
