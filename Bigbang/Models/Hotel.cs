using System.ComponentModel.DataAnnotations;

namespace Bigbang.Models
{
    public class Hotel
    {

        [Key]
        public int HotelId { get; set; }

        public string? Hotel_Name { get; set; }


        public string? Hotel_Location { get; set; }

        public int rating { get; set; }

        // navigation property - single hotel will have many rooms
        public ICollection<Room>? Rooms { get; set; }
    }
}

