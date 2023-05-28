using Bigbang.Models;

namespace Bigbang.Repository.BookingDetails
{
    public interface IBooking_Services
    {
        Task<IEnumerable<Booking_Details>> GetBookingDetails();
        Task<Booking_Details>? GetBookingDetail(int id);
        Task<Booking_Details> PutBookingDetail(int id, Booking_Details booking_Details);
        Task<List<Booking_Details>> PostBookingDetail(Booking_Details booking_Details);
        Task<Booking_Details>? DeleteBookingDetail(int id);
    }
}
