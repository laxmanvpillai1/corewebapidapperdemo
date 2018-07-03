using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CityInfo.API.Models;
using CityInfo.API.Business.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityInfo.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CitiesController : Controller
	{
		protected ICitiesManager citiesManager;

		public CitiesController(ICitiesManager citiesManager)
		{
			this.citiesManager = citiesManager;	
		}

		//List<City> CityList = new List<City>(){
		//		new City(1, "New York"),
		//	new City(2, "Mumbai")
		//};

		// GET: /<controller>/
		[HttpGet]
		public ActionResult<IEnumerable<City>> GetCities()
		{
			return citiesManager.GetAllCities();
		}

        //[HttpGet("{id}")]
        //public ActionResult<City> GetCity(int id){
        //	return CityList.Find((obj) => obj.CityId==id);
        //}

        [HttpPost]
        public void AddCity([FromBody] City city)
        {
            citiesManager.AddCity(city);
        }
    }
}
