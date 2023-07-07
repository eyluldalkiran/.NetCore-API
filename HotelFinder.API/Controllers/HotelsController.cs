using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController()
        {
            _hotelService = new HotelManager();
        }


        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }

        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelService.GetHotelsById(id);
        }

        [HttpPost]
        public Hotel Post([FromBody]HotelFinder hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut]
        public HotelFinder Put([FromBody]HotelFinder hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            return _hotelService.DeleteHotel(id);
        }
    }
}
