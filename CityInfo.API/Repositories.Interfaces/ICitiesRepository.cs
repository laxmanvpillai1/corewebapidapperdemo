using System;
using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API.Repositories.Interfaces
{
    public interface ICitiesRepository
    {
		List<City> GetCities();
        void AddCity(City city);
        City GetCityById(int id);
    }
}
