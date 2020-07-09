using CatalogES.Model;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Repository
{
    public class CatalogRepository:ICatalogRepository
    {
        private CatalogContext _con;
        private ILogger _logger;
        public CatalogRepository(CatalogContext context)
        {
            _con = context;
            _logger = new LoggerFactory().CreateLogger<CatalogRepository>();
        }

        public async Task<List<City>> GetCitiesByCountry(ObjectId country)
        {
            try 
            {
                List<City> cities = await _con.Cities.Find(city => city.Country == country).ToListAsync();
                return cities;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }

        public async Task<List<Country>> GetCountries()
        {
            try 
            {
                List<Country> countries = await _con.Countries.Find(country => country.Id != null).ToListAsync();
                return countries;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }

        public async Task<List<EquipmentType>> GetEquipmentTypes()
        {
            try 
            {
                List<EquipmentType> equipments = await _con.EquipmentTypes.Find(equipment => equipment.Id != null).ToListAsync();
                return equipments;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }

        public async Task<List<Language>> GetLanguages()
        {
            try 
            {
                List<Language> languages = await _con.Languages.Find(language => language.Id != null).ToListAsync();
                return languages;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }
    }
}
