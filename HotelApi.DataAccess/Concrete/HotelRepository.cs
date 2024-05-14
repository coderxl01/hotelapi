using HotelApi.DataAccess.Abstruct;
using HotelApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel DeleteHotel(int id)
        {
           
            using (var hotelDbContext= new HotelDbContext())
            {
                Hotel hotel = GetById(id);
                hotelDbContext.Hotels.Remove(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
            
        }

        public List<Hotel> GetAll()
        {
           using(var hotelDbContext= new HotelDbContext())
            {
             return hotelDbContext.Hotels.ToList();
            }
        }

        public Hotel GetById(int id)
        {

            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.Find(id);
            }
        }

        public Hotel InsertHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Add(hotel);
                hotelDbContext.SaveChanges ();
                return hotel;
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Update(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }
    }
}
