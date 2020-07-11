using CatalogES.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Service
{
    public interface ICatalogService
    {
        Task<List<CityDTO>> GetCitiesByCountry(string country);
        Task<List<CountryDTO>> GetCountries();
        Task<List<LanguageDTO>> GetLanguages();
        Task<List<EquipmentTypeDTO>> GetEquipmentTypes();
    }
}
