using CatalogES.DBSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Model
{
    public class CatalogContext
    {
        public IMongoCollection<City> Cities { get; }
        public IMongoCollection<Country> Countries { get; }
        public IMongoCollection<EquipmentType> EquipmentTypes { get; }
        public IMongoCollection<Language> Languages { get; }

        public CatalogContext(IDBSettings settings)
        {
            IMongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DataBaseName);
            Languages = database.GetCollection<Language>("Language");
            Countries = database.GetCollection<Country>("Country");
            EquipmentTypes = database.GetCollection<EquipmentType>("EquipmentType");
            Cities = database.GetCollection<City>("City");
        }
    }
}
