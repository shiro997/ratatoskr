﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Model
{
    public class Country
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
