using AutoMapper;
using CatalogES.DTO;
using CatalogES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Mappings
{
    public class CatalogMapper
    {
        public static CountryDTO FromModelToDTO(Country model, IMapper mapper) 
        {
            try 
            {
                CountryDTO country = new CountryDTO();
                mapper.Map(model, country);
                country.Id = model.Id.ToString();
                return country;
            } 
            catch (Exception) 
            {
                throw;
            }
        }

        public static CityDTO FromModelToDTO(City model, IMapper mapper) 
        {
            try 
            {
                CityDTO city = new CityDTO();
                mapper.Map(model, city);
                city.Id = model.Id.ToString();
                city.Country = model.Country.ToString();
                return city;
            } 
            catch (Exception) 
            {
                throw;
            }
        }

        public static LanguageDTO FromModelToDTO(Language model, IMapper mapper)
        {
            try 
            {
                LanguageDTO language = new LanguageDTO();
                mapper.Map(model, language);
                language.Id = model.Id.ToString();
                return language;
            } 
            catch (Exception) 
            {
                throw;
            }
        }

        public static EquipmentTypeDTO FromModelToDTO(EquipmentType model, IMapper mapper) 
        {
            try 
            {
                EquipmentTypeDTO equipment = new EquipmentTypeDTO();
                mapper.Map(model, equipment);
                equipment.Id = model.Id.ToString();
                return equipment;
            } 
            catch (Exception)
            {
                throw;
            }
        }
    }
}
