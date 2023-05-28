using Bigbang.Models;

namespace Bigbang.Repository.Rooms
{
    public interface IRooms_Services
    {
        Task<IEnumerable<Room>> GetRooms();
        Task<Room>? GetRoom(int id);
        Task<Room> PutRoom(int id, Room room);
        Task<List<Room>> PostRoom(Room room);
        Task<Room>? DeleteRoom(int id);
    }
}
