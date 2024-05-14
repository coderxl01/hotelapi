using HotelApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi.Service.Abstruct
{
    public interface IHotelService
    {
        List<Hotel> GetAll();
        Hotel GetById(int id);
        Hotel InsertHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        Hotel DeleteHotel(int id);
    }
}
