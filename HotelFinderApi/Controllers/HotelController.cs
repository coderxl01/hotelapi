using HotelApi.Entities;
using HotelApi.Service.Concrete; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using HotelApi.Service.Abstruct;

namespace HotelFinderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class HotelController : Controller
    {
        IHotelService hotelService; 
       public HotelController() {
            this.hotelService = new HotelService();
        }

        [HttpGet]
        public List<Hotel> GetAll()
        {
            return hotelService.GetAll();
        }

        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return hotelService.GetById(id);
        }

        [HttpPost]
        public Hotel Post([FromBody] Hotel hotel)
        {
            return hotelService.UpdateHotel(hotel);
        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return hotelService.UpdateHotel(hotel);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            hotelService.DeleteHotel(id);
        }

    }
}
