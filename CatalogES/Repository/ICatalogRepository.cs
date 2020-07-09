using CatalogES.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Repository
{
    public interface ICatalogRepository
    {
        Task<List<Language>> GetLanguages();
        Task<List<EquipmentType>> GetEquipmentTypes();
        Task<List<Country>> GetCountries();
        Task<List<City>> GetCitiesByCountry(ObjectId country);
    }
}
