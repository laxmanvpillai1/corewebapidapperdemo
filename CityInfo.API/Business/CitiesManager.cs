using System;
using CityInfo.API.Repositories;
using CityInfo.API.Models;
using CityInfo.API.Business.Interfaces;
using CityInfo.API.Repositories.Interfaces;
using System.Collections.Generic;

namespace CityInfo.API.Business
{
	public class CitiesManager : ICitiesManager
    {
		ICitiesRepository citiesRepository;
		
		public CitiesManager(ICitiesRepository citiesRepository)
        {
			this.citiesRepository = citiesRepository;
        }

		public List<City> GetAllCities()
		{
			return citiesRepository.GetCities();
		}

        public void AddCity(City city)
        {
            citiesRepository.AddCity(city);
        }
    }
}
