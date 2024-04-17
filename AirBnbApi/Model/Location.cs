using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnbApi.Model
{
    public class Location
    {
        [Flags]
        public enum FeaturesType
        {
            Smoking = 1,
            PetsAllowed = 2,
            Wifi = 4,
            TV = 8,
            Bath = 16,
            Breakfast = 32
        }
        public enum LocationType
        {
            Appartment,
            Cottage,
            Chalet,
            Room,
            Hotel,
            House
        }
        public int Id { get; set; }
        public ICollection<Image> Images { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public string Title { get; set; }
        public Landlord Landlord { get; set; }
        [ForeignKey("Landlord.Id")]
        public int LandlordId { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        [Required]
        public string SubTitle { get; set; }
        [Required]
        public float PricePerDay { get; set; }
        [Required]
        public FeaturesType Features { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public LocationType Type { get; set; }
        [Required]
        public int NumberOfGuests { get; set; }
    }
}
