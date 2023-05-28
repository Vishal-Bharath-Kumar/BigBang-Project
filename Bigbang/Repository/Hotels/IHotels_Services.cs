using Bigbang.Models;

namespace Bigbang.Repository.Hotels
{
    public interface IHotels_Services
    {
        Task<IEnumerable<Hotel>> GetHotels();
        Task<Hotel>? GetHotel(int id);
        Task<Hotel> PutHotel(int id, Hotel hotel);
        Task<List<Hotel>> PostHotel(Hotel hotel);
        Task<Hotel>? DeleteHotel(int id);
        Task<int> GetAvailableRoomCount(int hotelId);
        Task<List<Hotel>> FilterHotels(string location);
    }
}
