using HotelApi.DataAccess.Concrete;
using HotelApi.Entities;
using HotelApi.Service.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi.Service.Concrete
{
    public class HotelService : IHotelService
    {
        HotelRepository hotelRepository;

        public HotelService()
        {
            this.hotelRepository = new HotelRepository();
        }

        public Hotel DeleteHotel(int id)
        {
          return  hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAll()
        {
            return hotelRepository.GetAll();
        }

        public Hotel GetById(int id)
        {
            if (id > 0)
            {
                return hotelRepository.GetById(id);
            }
            throw new Exception("id 1 den küçük olamaz");
           
        }

        public Hotel InsertHotel(Hotel hotel)
        {
            return hotelRepository.InsertHotel(hotel);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
           return hotelRepository.UpdateHotel(hotel);
        }
    }
}
