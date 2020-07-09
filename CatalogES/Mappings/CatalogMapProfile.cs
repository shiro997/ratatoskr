using AutoMapper;
using CatalogES.DTO;
using CatalogES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Mappings
{
    public class CatalogMapProfile:Profile
    {
        public CatalogMapProfile()
        {
            //salida de datos
            CreateMap<City, CityDTO>()
                .ForMember(city => city.Country, options => options.Ignore())
                .ForMember(city => city.Id, options => options.Ignore());
            CreateMap<Country, CountryDTO>()
                .ForMember(country => country.Id, options => options.Ignore());
            CreateMap<Language, LanguageDTO>()
                .ForMember(language => language.Id, options => options.Ignore());
            CreateMap<EquipmentType, EquipmentTypeDTO>()
                .ForMember(equipment => equipment.Id, options => options.Ignore());
        }
    }
}
