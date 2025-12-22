using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class JsonStateStorage : IStateStorage
    {
        private const string FileName = "data.json";

        private readonly JsonSerializerSettings settings = new()
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Auto,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public void Save(WarehouseSystemState state)
        {
            var json = JsonConvert.SerializeObject(state, settings);
            File.WriteAllText(FileName, json);
        }

        public WarehouseSystemState Load()
        {
            if (!File.Exists(FileName)) return new WarehouseSystemState();

            try
            {
                var json = File.ReadAllText(FileName);
                return JsonConvert.DeserializeObject<WarehouseSystemState>(json, settings)
                       ?? new WarehouseSystemState();
            }
            catch
            {
                return new WarehouseSystemState();
            }
        }
    }
}
