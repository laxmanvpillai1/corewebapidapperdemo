using System;
using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API.Business.Interfaces
{
    public interface ICitiesManager
    {
		 List<City> GetAllCities();
        void AddCity(City city);
    }
}
