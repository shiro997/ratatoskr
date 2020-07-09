using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.DBConfig
{
    public class DBSettings: IDBSettings
    {
        public string DataBaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
