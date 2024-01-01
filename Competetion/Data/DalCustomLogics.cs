﻿using Newtonsoft.Json;
using System.Data;

namespace Competetion.Data
{
    public class DalCustomLogics
    {
        public static string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Newtonsoft.Json.Formatting.Indented
            };
            JSONString = JsonConvert.SerializeObject(table, settings);
            return JSONString;
        }
    }
}
