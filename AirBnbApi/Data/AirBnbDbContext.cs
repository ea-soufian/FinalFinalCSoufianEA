using Microsoft.EntityFrameworkCore;
using AirBnbApi.Model;

namespace AirBnbApi.Data
{
    public class AirBnbDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Image> Image { get; set; } = default!;
        public DbSet<Landlord> Landlord { get; set; } = default!;
        public DbSet<Location> Location { get; set; } = default!;
        public DbSet<Reservation> Reservation { get; set; } = default!;
        public AirBnbDbContext(DbContextOptions<AirBnbDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    Id = 1,
                    Url = "https://dudewipes.com/cdn/shop/articles/gigachad.jpg?v=1667928905&width=2048"
                },
                new Image
                {
                    Id = 2,
                    Url = "https://img.a.transfermarkt.technology/portrait/big/4380-1707301752.jpg?lm=1"
                },
                new Image
                {
                    Id = 3,
                    Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/db/70/main-courtyard.jpg?w=1200&h=-1&s=1",
                    IsCover = true,
                    LocationId = 1
                },
                new Image
                {
                    Id = 4,
                    Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-018.jpg",
                    IsCover = true,
                    LocationId = 2
                },
                new Image
                {
                    Id = 5,
                    Url = "https://images.mubicdn.net/images/cast_member/516454/cache-873696-1682862099/image-w856.jpg?size=800x"
                },
                new Image
                {
                    Id = 6,
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBcLE7OvpUSniu2afNLivD0QIj1iF937vrBck6gNhxzg&s"
                },
                new Image
                {
                    Id = 7,
                    Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/db/65/main-courtyard.jpg?w=1200&h=-1&s=1",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 8,
                    Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/4e/tv-lounge.jpg?w=1200&h=-1&s=1",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 9,
                    Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/29/tv-lounge.jpg?w=1200&h=-1&s=1",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 10,
                    Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/19/breakfast.jpg?w=1200&h=-1&s=1",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 11,
                    Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2013-042.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 12,
                    Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-030.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 13,
                    Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-027.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 14,
                    Url = "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-023.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 15,
                    Url = "https://a0.muscache.com/im/pictures/fd4517b6-5a66-477d-a8b7-1e4df1faca20.jpg?im_w=960",
                    IsCover = true,
                    LocationId = 3
                },
                new Image
                {
                    Id = 16,
                    Url = "https://a0.muscache.com/im/pictures/c1217bc8-11f8-442f-b54d-a59bdf614d94.jpg?im_w=720",
                    IsCover = false,
                    LocationId = 3
                },
                new Image
                {
                    Id = 17,
                    Url = "https://a0.muscache.com/im/pictures/hosting/Hosting-1071775108870039186/original/86142eff-8836-4c06-827e-9469507034c7.jpeg?im_w=720",
                    IsCover = false,
                    LocationId = 3
                },
                new Image
                {
                    Id = 18,
                    Url = "https://a0.muscache.com/im/pictures/hosting/Hosting-1071775108870039186/original/2d941e7e-9547-4306-a36c-e7407adfb38b.jpeg?im_w=720",
                    IsCover = false,
                    LocationId = 3
                },
                new Image
                {
                    Id = 19,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076262.jpg?k=075189c4641d0837d17027d698e8774307be2495aa3b4401861c869f81d80d5a&o=&hp=1",
                    IsCover = true,
                    LocationId = 4
                },
                new Image
                {
                    Id = 20,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076867.jpg?k=3866c0c872b39701bca6312fd1cd8c6275a059d60db7e2a477f457edfcc0bd44&o=&hp=1",
                    IsCover = false,
                    LocationId = 4
                },
                new Image
                {
                    Id = 21,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076610.jpg?k=0301c08bcd9f7948fa5eab92641e70a98b770e4a34e00904758a334edb3bbf14&o=&hp=1",
                    IsCover = false,
                    LocationId = 4
                },
                new Image
                {
                    Id = 22,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480587.jpg?k=199f2fdf3a84e8ae5d42d07f28b7723b528cbe56599b24390d9adfd58ae3e310&o=&hp=1",
                    IsCover = true,
                    LocationId = 5
                },
                new Image
                {
                    Id = 23,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480533.jpg?k=aa1a08a273f22759d26535a734b49ee64cf5c8bb09e8b7e9e34355acdd3f54fa&o=&hp=1",
                    IsCover = false,
                    LocationId = 5
                },
                new Image
                {
                    Id = 24,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480541.jpg?k=4e1eecf085e4c998a9e12a85e73f99efcabb2bf2b4c4e686f619d7841fa75cf9&o=&hp=1",
                    IsCover = false,
                    LocationId = 5
                },
                new Image
                {
                    Id = 25,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480570.jpg?k=e1f152ff5c77f61eb346a58a80d28bab4200998e9e08692e6c15a8abfb5d4225&o=&hp=1",
                    IsCover = false,
                    LocationId = 5
                },
                new Image
                {
                    Id = 26,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/453585868.jpg?k=20bb8fa2ae2d2fcf6017ae55640527926c5b13cc07c2abf422fa7cfb2f9de94f&o=&hp=1",
                    IsCover = true,
                    LocationId = 6
                },
                new Image
                {
                    Id = 27,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/453585870.jpg?k=892bad7a75f60d012122f9ebf94470ebbe83568f266b3967ed236fdf96dd2193&o=&hp=1",
                    IsCover = false,
                    LocationId = 6
                },
                new Image
                {
                    Id = 28,
                    Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233389.jpg?ca=6&ce=1&s=1024x768",
                    IsCover = true,
                    LocationId = 7
                },
                new Image
                {
                    Id = 29,
                    Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17121115240060335944.jpg?ca=6&ce=1&s=1024x768",
                    IsCover = false,
                    LocationId = 7
                },
                new Image
                {
                    Id = 30,
                    Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233383.jpg?ca=6&ce=1&s=1024x768",
                    IsCover = false,
                    LocationId = 7
                },
                new Image
                {
                    Id = 31,
                    Url = "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233400.jpg?ca=6&ce=1&s=1024x768",
                    IsCover = false,
                    LocationId = 7
                },
                new Image
                {
                    Id = 32,
                    Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/f4cc2abd-1643-47f3-9810-f5010aadb2a0.jpeg?im_w=960",
                    IsCover = true,
                    LocationId = 8
                },
                new Image
                {
                    Id = 33,
                    Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/8b886668-8d9a-46db-815f-8ca2e0db9734.jpeg?im_w=1200",
                    IsCover = false,
                    LocationId = 8
                },
                new Image
                {
                    Id = 34,
                    Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/1b2d877e-4aee-4cd4-894b-db9d05710daf.jpeg?im_w=1200",
                    IsCover = false,
                    LocationId = 8
                },
                new Image
                {
                    Id = 35,
                    Url = "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/7764da9e-2ff7-42ba-9177-decf2de4754e.jpeg?im_w=1200",
                    IsCover = false,
                    LocationId = 8
                },
                new Image
                {
                    Id = 36,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/166571658.jpg?k=f650daa2d249b002682dddd40bb83a47c1c534e03b7b48b579aa81d3c9735fec&o=&hp=1",
                    IsCover = true,
                    LocationId = 9
                },
                new Image
                {
                    Id = 37,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/289436171.jpg?k=71118a495360716afc1c7b63bf5a4eb6ff5a791611d00d4291e44021c9447295&o=&hp=1",
                    IsCover = false,
                    LocationId = 9
                },
                new Image
                {
                    Id = 38,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/410650472.jpg?k=e88fc20141f536b7c9f2a3684f3ce75d8f6d18f0f14ce8bfdfc678e29bdc7d7b&o=&hp=1",
                    IsCover = false,
                    LocationId = 9
                },
                new Image
                {
                    Id = 39,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/415229786.jpg?k=e04c9234b60a70298fc7625db879aca07cf974ebc06a47c76dbef7976ed8ecc6&o=&hp=1",
                    IsCover = false,
                    LocationId = 9
                },
                new Image
                {
                    Id = 40,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420276132.jpg?k=9199e10fd3fcf720884af957efc99e3bdcb7ffc7559d6aaf12d61ce27d268a06&o=&hp=1",
                    IsCover = true,
                    LocationId = 10
                },
                new Image
                {
                    Id = 41,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420276963.jpg?k=f6aa942a008ea50b624ebe903088398bc9133592d41d1d21957ee2d08bcc58d9&o=&hp=1",
                    IsCover = false,
                    LocationId = 10
                },
                new Image
                {
                    Id = 42,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420305441.jpg?k=29cdb5b55def034025a0b03668cf340aa9d5cc22d1836ff529e8ab3a580118e7&o=&hp=1",
                    IsCover = false,
                    LocationId = 10
                },
                new Image
                {
                    Id = 43,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/422013299.jpg?k=c151f5c872eb52a5d1568c84d16e6127fa8295e86160add201b75d38c7361e87&o=&hp=1",
                    IsCover = false,
                    LocationId = 10
                }

            );

            modelBuilder.Entity<Landlord>().HasData(
                new Landlord
                {
                    Id = 1,
                    FirstName = "Soufian",
                    LastName = "Allali",
                    Age = 35,
                    AvatarId = 1
                },
                new Landlord
                {
                    Id = 2,
                    FirstName = "Robin",
                    LastName = "van Persie",
                    Age = 32,
                    AvatarId = 2
                },
                new Landlord
                {
                    Id = 3,
                    FirstName = "Zlatan Ibrahimovic",
                    LastName = "Parker",
                    Age = 28,
                    AvatarId = 5
                },
                new Landlord
                {
                    Id = 4,
                    FirstName = "Lionel",
                    LastName = "Messi",
                    Age = 45,
                    AvatarId = 6
                }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    Title = "Marrakech Cottage",
                    SubTitle = "Serenity Sanctuary",
                    Description = "Riad Tifawin for you who dream of Orientation and simple pleasures. Beyond the ramparts of the 'Bab Doukkala' gate",
                    LandlordId = 1,
                    Rooms = 2,
                    PricePerDay = 119,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.Breakfast,
                    Type = AirBnbApi.Model.Location.LocationType.Cottage,
                    NumberOfGuests = 4
                },
                new Location
                {
                    Id = 2,
                    Title = "Urban Loft Amsterdam city",
                    SubTitle = "Cutting-edge Elegance",
                    Description = "Experience a contemporary and chic apartment nestled in the vibrant pulse of the city center, conveniently situated near all prominent attractions.",
                    LandlordId = 2,
                    Rooms = 3,
                    PricePerDay = 169,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV,
                    Type = AirBnbApi.Model.Location.LocationType.Appartment,
                    NumberOfGuests = 6
                },
                new Location
                {
                    Id = 3,
                    Title = "Charming chalet-style flat in Arild",
                    SubTitle = "Nordic Haven Retreat",
                    Description = "On a horsefarm near the sea, a newly renovated appartment of 60sm with two bedrooms and a loft. ",
                    LandlordId = 3,
                    Rooms = 4,
                    PricePerDay = 212,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV | AirBnbApi.Model.Location.FeaturesType.Bath,
                    Type = AirBnbApi.Model.Location.LocationType.Chalet,
                    NumberOfGuests = 8
                },
                new Location
                {
                    Id = 4,
                    Title = "Colorful Private Room",
                    SubTitle = "Authentic & Colorful",
                    Description = "Boasting garden views, Colorful Private Room Oasis features accommodation with a terrace and a balcony, around 2.1 km from Catherine Hall Beach.",
                    LandlordId = 4,
                    Rooms = 1,
                    PricePerDay = 56,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.Breakfast,
                    Type = AirBnbApi.Model.Location.LocationType.Room,
                    NumberOfGuests = 2
                },
                new Location
                {
                    Id = 5,
                    Title = "Crystal Sunset Luxury Resort",
                    SubTitle = "Ultimate All Inclusive",
                    Description = "Named after the crystal-clear waters of Mediterranean Sea, Crystal Luxury Sunset Resort & Spa has a seafront location and a private 250 metres long sandy beach. ",
                    LandlordId = 1,
                    Rooms = 50,
                    PricePerDay = 269,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV | AirBnbApi.Model.Location.FeaturesType.Bath | AirBnbApi.Model.Location.FeaturesType.Breakfast,
                    Type = AirBnbApi.Model.Location.LocationType.Hotel,
                    NumberOfGuests = 100
                },
                new Location
                {
                    Id = 6,
                    Title = "Family Villa",
                    SubTitle = "Cozy Retreat Abroad",
                    Description = "The villa with a terrace and pool views features 6 bedrooms, 2 living rooms, a flat-screen TV, an equipped kitchen with a microwave and a fridge, and 6 bathrooms with a bidet. The property has an outdoor dining area.",
                    LandlordId = 2,
                    Rooms = 5,
                    PricePerDay = 304,
                    Features = AirBnbApi.Model.Location.FeaturesType.Bath | AirBnbApi.Model.Location.FeaturesType.PetsAllowed | AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV,
                    Type = AirBnbApi.Model.Location.LocationType.House,
                    NumberOfGuests = 6
                },
                new Location
                {
                    Id = 7,
                    Title = "Naiya Beach Bungalow",
                    SubTitle = "Sun, Sand & Apes",
                    Description = "Naiya Beach Bungalow is natural and tropical in design, secluded in relaxing atmosphere of a big garden, far away from all the hustle.",
                    LandlordId = 3,
                    Rooms = 3,
                    PricePerDay = 189,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV | AirBnbApi.Model.Location.FeaturesType.Breakfast,
                    Type = AirBnbApi.Model.Location.LocationType.Cottage,
                    NumberOfGuests = 6
                },
                new Location
                {
                    Id = 8,
                    Title = "Beach House",
                    SubTitle = "Luxury & Stunning Views",
                    Description = "Experience luxury living in this stunning penthouse apartment with breathtaking panoramic city views.",
                    LandlordId = 4,
                    Rooms = 4,
                    PricePerDay = 354,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV | AirBnbApi.Model.Location.FeaturesType.Bath,
                    Type = AirBnbApi.Model.Location.LocationType.Appartment,
                    NumberOfGuests = 8
                },
                new Location
                {
                    Id = 9,
                    Title = "Chalet in the forest",
                    SubTitle = "Surrounded by nature",
                    Description = "Unwind in this serene woodland chalet, offering a perfect retreat for nature lovers seeking peace and tranquility.",
                    LandlordId = 1,
                    Rooms = 3,
                    PricePerDay = 216,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.PetsAllowed | AirBnbApi.Model.Location.FeaturesType.Bath,
                    Type = AirBnbApi.Model.Location.LocationType.Chalet,
                    NumberOfGuests = 6
                },
                new Location
                {
                    Id = 10,
                    Title = "Loft for artists",
                    SubTitle = "creatieve setting",
                    Description = "Damme Golf & Country Club is located 44 km away from the bed & breakfast, while Minnewater is situated 45 km further. The nearest airport, Antwerp International Airport, is 64 km from Artist's Loft & Garden.",
                    LandlordId = 2,
                    Rooms = 2,
                    PricePerDay = 120,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.Smoking | AirBnbApi.Model.Location.FeaturesType.TV,
                    Type = AirBnbApi.Model.Location.LocationType.Appartment,
                    NumberOfGuests = 4
                }
 
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Email = "Soufianallali@live.nl",
                    FirstName = "Soufian",
                    LastName = "Allali"
                },
                new Customer
                {
                    Id = 2,
                    Email = "arjenrobben@hotmail.com",
                    FirstName = "Arjen",
                    LastName = "Robben"
                },
                new Customer
                {
                    Id = 3,
                    Email = "PeterGriffin@mail.com",
                    FirstName = "Peter",
                    LastName = "Griffin"
                },
                new Customer
                {
                    Id = 4,
                    Email = "lil-mike@yahoo.pl",
                    FirstName = "Mike",
                    LastName = "Chrysler"
                },
                new Customer
                {
                    Id = 5,
                    Email = "Romano@icloud.com",
                    FirstName = "Romano",
                    LastName = "Dekker"
                }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    LocationId = 1,
                    Discount = 10,
                    CustomerId = 1,
                    StartTime = new DateTime(2023, 4, 1),
                    EndTime = new DateTime(2023, 4, 7)
                },
                new Reservation
                {
                    Id = 2,
                    LocationId = 3,
                    Discount = 5,
                    CustomerId = 2,
                    StartTime = new DateTime(2023, 4, 10),
                    EndTime = new DateTime(2023, 4, 15)
                },
                new Reservation
                {
                    Id = 3,
                    LocationId = 7,
                    Discount = 0,
                    CustomerId = 3,
                    StartTime = new DateTime(2023, 4, 18),
                    EndTime = new DateTime(2023, 4, 24)
                }
            );
        }
    }
}
