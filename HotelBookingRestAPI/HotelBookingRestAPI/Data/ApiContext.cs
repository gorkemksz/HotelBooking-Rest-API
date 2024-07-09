using Microsoft.EntityFrameworkCore;
using HotelBookingRestAPI.Models;
using Microsoft.Extensions.Options;

namespace HotelBookingRestAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings{ get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
        :base(options)
        {

        }
    }
}
