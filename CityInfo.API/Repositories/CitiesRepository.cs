using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Data.CommandType;
using System.Linq;
using CityInfo.API.Models;
using CityInfo.API.Repositories.Interfaces;
using Dapper;

namespace CityInfo.API.Repositories
{
	public class CitiesRepository : BaseRepository, ICitiesRepository
    {
        public CitiesRepository()
        {
			
        }

		public List<City> GetCities()
        {
            List<City> CityList = SqlMapper.Query<City>(connection, "spGetAllCities", CommandType.StoredProcedure).ToList();
            return CityList;
        }

        public void AddCity(City city)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CityName", city.CityName);
            SqlMapper.Execute(connection, "spAddCity", parameters, null, null, CommandType.StoredProcedure);
        }
    }
}
