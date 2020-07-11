using AutoMapper;
using CatalogES.DTO;
using CatalogES.Mappings;
using CatalogES.Model;
using CatalogES.Repository;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Service
{
    public class CatalogService:ICatalogService
    {
        private ICatalogRepository _repo;
        private ILogger _logger;
        private IMapper _mapper;

        public CatalogService(CatalogContext context, IMapper mapper)
        {
            _logger = new LoggerFactory().CreateLogger<CatalogService>();
            _repo = new CatalogRepository(context);
            _mapper = mapper;
        }

        public async Task<List<CityDTO>> GetCitiesByCountry(string country) 
        {
            try 
            {
                List<City> models = await _repo.GetCitiesByCountry(ObjectId.Parse(country));
                List<CityDTO> cities = new List<CityDTO>();
                foreach (City model in models) 
                {
                    CityDTO city = CatalogMapper.FromModelToDTO(model, _mapper);
                    cities.Add(city);
                }
                return cities;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }

        public async Task<List<CountryDTO>> GetCountries() 
        {
            try 
            {
                List<Country> models = await _repo.GetCountries();
                List<CountryDTO> countries = new List<CountryDTO>();
                foreach (Country model in models) 
                {
                    countries.Add(CatalogMapper.FromModelToDTO(model, _mapper));
                }
                return countries;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }

        public async Task<List<LanguageDTO>> GetLanguages() 
        {
            try 
            {
                List<Language> models = await _repo.GetLanguages();
                List<LanguageDTO> languages = new List<LanguageDTO>();
                foreach (Language model in models) 
                {
                    languages.Add(CatalogMapper.FromModelToDTO(model, _mapper));
                }
                return languages;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }

        public async Task<List<EquipmentTypeDTO>> GetEquipmentTypes() 
        {
            try 
            {
                List<EquipmentType> models = await _repo.GetEquipmentTypes();
                List<EquipmentTypeDTO> types = new List<EquipmentTypeDTO>();
                foreach (EquipmentType model in models) 
                {
                    types.Add(CatalogMapper.FromModelToDTO(model, _mapper));
                }
                return types;
            } 
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message, DateTime.Now, ex);
                throw;
            }
        }
    }
}
