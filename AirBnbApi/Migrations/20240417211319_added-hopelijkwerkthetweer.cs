using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirBnbApi.Migrations
{
    public partial class addedhopelijkwerkthetweer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCover = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Landlord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AvatarId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landlord_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerDay = table.Column<float>(type: "real", nullable: false),
                    Features = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Landlord_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Soufianallali@live.nl", "Soufian", "Allali" },
                    { 2, "arjenrobben@hotmail.com", "Arjen", "Robben" },
                    { 3, "PeterGriffin@mail.com", "Peter", "Griffin" },
                    { 4, "lil-mike@yahoo.pl", "Mike", "Chrysler" },
                    { 5, "Romano@icloud.com", "Romano", "Dekker" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 1, false, null, "https://dudewipes.com/cdn/shop/articles/gigachad.jpg?v=1667928905&width=2048" },
                    { 2, false, null, "https://img.a.transfermarkt.technology/portrait/big/4380-1707301752.jpg?lm=1" },
                    { 5, false, null, "https://images.mubicdn.net/images/cast_member/516454/cache-873696-1682862099/image-w856.jpg?size=800x" },
                    { 6, false, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBcLE7OvpUSniu2afNLivD0QIj1iF937vrBck6gNhxzg&s" }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 35, 1, "Soufian", "Allali" },
                    { 2, 32, 2, "Robin", "van Persie" },
                    { 3, 28, 5, "Zlatan Ibrahimovic", "Parker" },
                    { 4, 45, 6, "Lionel", "Messi" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Riad Tifawin for you who dream of Orientation and simple pleasures. Beyond the ramparts of the 'Bab Doukkala' gate", 36, 1, 4, 119f, 2, "Serenity Sanctuary", "Marrakech Cottage", 1 },
                    { 2, "Experience a contemporary and chic apartment nestled in the vibrant pulse of the city center, conveniently situated near all prominent attractions.", 12, 2, 6, 169f, 3, "Cutting-edge Elegance", "Urban Loft Amsterdam city", 0 },
                    { 3, "On a horsefarm near the sea, a newly renovated appartment of 60sm with two bedrooms and a loft. ", 28, 3, 8, 212f, 4, "Nordic Haven Retreat", "Charming chalet-style flat in Arild", 2 },
                    { 4, "Boasting garden views, Colorful Private Room Oasis features accommodation with a terrace and a balcony, around 2.1 km from Catherine Hall Beach.", 36, 4, 2, 56f, 1, "Authentic & Colorful", "Colorful Private Room", 3 },
                    { 5, "Named after the crystal-clear waters of Mediterranean Sea, Crystal Luxury Sunset Resort & Spa has a seafront location and a private 250 metres long sandy beach. ", 60, 1, 100, 269f, 50, "Ultimate All Inclusive", "Crystal Sunset Luxury Resort", 4 },
                    { 6, "The villa with a terrace and pool views features 6 bedrooms, 2 living rooms, a flat-screen TV, an equipped kitchen with a microwave and a fridge, and 6 bathrooms with a bidet. The property has an outdoor dining area.", 30, 2, 6, 304f, 5, "Cozy Retreat Abroad", "Family Villa", 5 },
                    { 7, "Naiya Beach Bungalow is natural and tropical in design, secluded in relaxing atmosphere of a big garden, far away from all the hustle.", 44, 3, 6, 189f, 3, "Sun, Sand & Apes", "Naiya Beach Bungalow", 1 },
                    { 8, "Experience luxury living in this stunning penthouse apartment with breathtaking panoramic city views.", 28, 4, 8, 354f, 4, "Luxury & Stunning Views", "Beach House", 0 },
                    { 9, "Unwind in this serene woodland chalet, offering a perfect retreat for nature lovers seeking peace and tranquility.", 22, 1, 6, 216f, 3, "Surrounded by nature", "Chalet in the forest", 2 },
                    { 10, "Damme Golf & Country Club is located 44 km away from the bed & breakfast, while Minnewater is situated 45 km further. The nearest airport, Antwerp International Airport, is 64 km from Artist's Loft & Garden.", 13, 2, 4, 120f, 2, "creatieve setting", "Loft for artists", 0 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 3, true, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/db/70/main-courtyard.jpg?w=1200&h=-1&s=1" },
                    { 4, true, 2, "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-018.jpg" },
                    { 7, false, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/db/65/main-courtyard.jpg?w=1200&h=-1&s=1" },
                    { 8, false, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/4e/tv-lounge.jpg?w=1200&h=-1&s=1" },
                    { 9, false, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/29/tv-lounge.jpg?w=1200&h=-1&s=1" },
                    { 10, false, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/29/47/da/19/breakfast.jpg?w=1200&h=-1&s=1" },
                    { 11, false, 2, "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2013-042.jpg" },
                    { 12, false, 2, "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-030.jpg" },
                    { 13, false, 2, "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-027.jpg" },
                    { 14, false, 2, "https://www.urbanresidences.com/images/rooms/rotterdam/largepenthouse/Urban-Rdam-2012-023.jpg" },
                    { 15, true, 3, "https://a0.muscache.com/im/pictures/fd4517b6-5a66-477d-a8b7-1e4df1faca20.jpg?im_w=960" },
                    { 16, false, 3, "https://a0.muscache.com/im/pictures/c1217bc8-11f8-442f-b54d-a59bdf614d94.jpg?im_w=720" },
                    { 17, false, 3, "https://a0.muscache.com/im/pictures/hosting/Hosting-1071775108870039186/original/86142eff-8836-4c06-827e-9469507034c7.jpeg?im_w=720" },
                    { 18, false, 3, "https://a0.muscache.com/im/pictures/hosting/Hosting-1071775108870039186/original/2d941e7e-9547-4306-a36c-e7407adfb38b.jpeg?im_w=720" },
                    { 19, true, 4, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076262.jpg?k=075189c4641d0837d17027d698e8774307be2495aa3b4401861c869f81d80d5a&o=&hp=1" },
                    { 20, false, 4, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076867.jpg?k=3866c0c872b39701bca6312fd1cd8c6275a059d60db7e2a477f457edfcc0bd44&o=&hp=1" },
                    { 21, false, 4, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/450076610.jpg?k=0301c08bcd9f7948fa5eab92641e70a98b770e4a34e00904758a334edb3bbf14&o=&hp=1" },
                    { 22, true, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480587.jpg?k=199f2fdf3a84e8ae5d42d07f28b7723b528cbe56599b24390d9adfd58ae3e310&o=&hp=1" },
                    { 23, false, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480533.jpg?k=aa1a08a273f22759d26535a734b49ee64cf5c8bb09e8b7e9e34355acdd3f54fa&o=&hp=1" },
                    { 24, false, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480541.jpg?k=4e1eecf085e4c998a9e12a85e73f99efcabb2bf2b4c4e686f619d7841fa75cf9&o=&hp=1" },
                    { 25, false, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/386480570.jpg?k=e1f152ff5c77f61eb346a58a80d28bab4200998e9e08692e6c15a8abfb5d4225&o=&hp=1" },
                    { 26, true, 6, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/453585868.jpg?k=20bb8fa2ae2d2fcf6017ae55640527926c5b13cc07c2abf422fa7cfb2f9de94f&o=&hp=1" },
                    { 27, false, 6, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/453585870.jpg?k=892bad7a75f60d012122f9ebf94470ebbe83568f266b3967ed236fdf96dd2193&o=&hp=1" },
                    { 28, true, 7, "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233389.jpg?ca=6&ce=1&s=1024x768" },
                    { 29, false, 7, "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17121115240060335944.jpg?ca=6&ce=1&s=1024x768" },
                    { 30, false, 7, "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233383.jpg?ca=6&ce=1&s=1024x768" },
                    { 31, false, 7, "https://pix8.agoda.net/hotelImages/362/3624525/3624525_17120611070060233400.jpg?ca=6&ce=1&s=1024x768" },
                    { 32, true, 8, "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/f4cc2abd-1643-47f3-9810-f5010aadb2a0.jpeg?im_w=960" },
                    { 33, false, 8, "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/8b886668-8d9a-46db-815f-8ca2e0db9734.jpeg?im_w=1200" },
                    { 34, false, 8, "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/1b2d877e-4aee-4cd4-894b-db9d05710daf.jpeg?im_w=1200" },
                    { 35, false, 8, "https://a0.muscache.com/im/pictures/miso/Hosting-866086181227542736/original/7764da9e-2ff7-42ba-9177-decf2de4754e.jpeg?im_w=1200" },
                    { 36, true, 9, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/166571658.jpg?k=f650daa2d249b002682dddd40bb83a47c1c534e03b7b48b579aa81d3c9735fec&o=&hp=1" },
                    { 37, false, 9, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/289436171.jpg?k=71118a495360716afc1c7b63bf5a4eb6ff5a791611d00d4291e44021c9447295&o=&hp=1" },
                    { 38, false, 9, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/410650472.jpg?k=e88fc20141f536b7c9f2a3684f3ce75d8f6d18f0f14ce8bfdfc678e29bdc7d7b&o=&hp=1" },
                    { 39, false, 9, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/415229786.jpg?k=e04c9234b60a70298fc7625db879aca07cf974ebc06a47c76dbef7976ed8ecc6&o=&hp=1" },
                    { 40, true, 10, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420276132.jpg?k=9199e10fd3fcf720884af957efc99e3bdcb7ffc7559d6aaf12d61ce27d268a06&o=&hp=1" },
                    { 41, false, 10, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420276963.jpg?k=f6aa942a008ea50b624ebe903088398bc9133592d41d1d21957ee2d08bcc58d9&o=&hp=1" },
                    { 42, false, 10, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/420305441.jpg?k=29cdb5b55def034025a0b03668cf340aa9d5cc22d1836ff529e8ab3a580118e7&o=&hp=1" },
                    { 43, false, 10, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/422013299.jpg?k=c151f5c872eb52a5d1568c84d16e6127fa8295e86160add201b75d38c7361e87&o=&hp=1" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CustomerId", "Discount", "EndTime", "LocationId", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 10f, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 5f, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 0f, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_LocationId",
                table: "Image",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_AvatarId",
                table: "Landlord",
                column: "AvatarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_LandlordId",
                table: "Location",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_LocationId",
                table: "Reservation",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Landlord");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
