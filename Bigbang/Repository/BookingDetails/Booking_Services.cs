using Bigbang.Models;
using Microsoft.EntityFrameworkCore;

namespace Bigbang.Repository.BookingDetails
{
    public class Booking_Services : IBooking_Services
    {
        public BigbangDbContext _bigbangDbcontext;
        public Booking_Services(BigbangDbContext bigbangDbcontext)
        {
            _bigbangDbcontext = bigbangDbcontext;
        }
        public async Task<IEnumerable<Booking_Details>> GetBookingDetails()
        {
            return await _bigbangDbcontext.Booking_Details.ToListAsync();
        }
        public async Task<Booking_Details>? GetBookingDetail(int id)
        {
            var book = await _bigbangDbcontext.Booking_Details.FindAsync(id);
            return book;
        }
        public async Task<Booking_Details> PutBookingDetail(int id, Booking_Details booking_Details)
        {
            var item = await _bigbangDbcontext.Booking_Details.FindAsync(id);

            item.UserName = booking_Details.UserName;
            item.CheckIn = booking_Details.CheckIn;
            item.Checkout = booking_Details.Checkout;
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                   Console.WriteLine(ex);
            }
          
            return booking_Details;

        }
        public async Task<List<Booking_Details>> PostBookingDetail(Booking_Details booking_Details)
        {
            await _bigbangDbcontext.Booking_Details.AddAsync(booking_Details);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }          
            return await _bigbangDbcontext.Booking_Details.ToListAsync();


        }
        public async Task<Booking_Details>? DeleteBookingDetail(int id)
        {
            var book = await _bigbangDbcontext.Booking_Details.FindAsync(id);
            _bigbangDbcontext.Booking_Details.Remove(book);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return book;

        }
    }
}
