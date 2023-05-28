using Bigbang.Models;
using Microsoft.EntityFrameworkCore;

namespace Bigbang.Repository.Hotels
{
    public class Hotels_Services : IHotels_Services
    {
        public BigbangDbContext _bigbangDbcontext;
        public Hotels_Services(BigbangDbContext bigbangDbContext)
        {
            _bigbangDbcontext = bigbangDbContext;
        }
        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return await _bigbangDbcontext.Hotels.ToListAsync();
        }
        public async Task<Hotel>? GetHotel(int id)
        {
            var hot = await _bigbangDbcontext.Hotels.FindAsync(id);
            return hot;
        }
        public async Task<Hotel> PutHotel(int id, Hotel hotel)
        {
            var item = await _bigbangDbcontext.Hotels.FindAsync(id);

            item.Hotel_Name = hotel.Hotel_Name;
            item.Hotel_Location = hotel.Hotel_Location;
            item.rating = hotel.rating;
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return hotel;

        }
        public async Task<List<Hotel>> PostHotel(Hotel hotel)
        {
            await _bigbangDbcontext.Hotels.AddAsync(hotel);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return await _bigbangDbcontext.Hotels.ToListAsync();


        }
        public async Task<Hotel>? DeleteHotel(int id)
        {
            var hot = await _bigbangDbcontext.Hotels.FindAsync(id);
            _bigbangDbcontext.Hotels.Remove(hot);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                   Console.WriteLine(ex.ToString());
            }
            return hot;

        }
        public async Task<int> GetAvailableRoomCount(int hotelId)
        {
            var hotel = await _bigbangDbcontext.Hotels
                .Include(h => h.Rooms)
                .FirstOrDefaultAsync(h => h.HotelId == hotelId);

            if (hotel == null)
                return 0;

            var availableRoomCount = hotel.Rooms.Count(r => r.Availability);
            return availableRoomCount;
        }
        public async Task<List<Hotel>> FilterHotels(string location)
        {
            var query = _bigbangDbcontext.Hotels.AsQueryable();

            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(h => h.Hotel_Location.Contains(location));
            }
            var filteredHotels = await query.ToListAsync();

        return filteredHotels;

        }
    }
}
