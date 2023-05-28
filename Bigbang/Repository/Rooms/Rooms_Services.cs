using Bigbang.Models;
using Microsoft.EntityFrameworkCore;

namespace Bigbang.Repository.Rooms
{
    public class Rooms_Services:IRooms_Services
    {
        public BigbangDbContext _bigbangDbcontext;
        public Rooms_Services(BigbangDbContext bigbangDbContext)
        {
            _bigbangDbcontext = bigbangDbContext;
        }
        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _bigbangDbcontext.Rooms.ToListAsync();
        }
        public async Task<Room>? GetRoom(int id)
        {
            var hot = await _bigbangDbcontext.Rooms.FindAsync(id);
            return hot;
        }
        public async Task<Room> PutRoom(int id, Room room)
        {
            var item = await _bigbangDbcontext.Rooms.FindAsync(id);

            item.RoomNumber = room.RoomNumber;
            item.RoomType = room.RoomType;
            item.Price = room.Price;
            item.Availability = room.Availability;
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
       
            return room;

        }
        public async Task<List<Room>> PostRoom(Room room)
        {
            await _bigbangDbcontext.Rooms.AddAsync(room);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return await _bigbangDbcontext.Rooms.ToListAsync();


        }
        public async Task<Room>? DeleteRoom(int id)
        {
            var roo = await _bigbangDbcontext.Rooms.FindAsync(id);
            _bigbangDbcontext.Rooms.Remove(roo);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return roo;

        }
    }
}
