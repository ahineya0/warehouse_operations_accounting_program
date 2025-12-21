using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class JsonStateStorage : IStateStorage
    {
        private const string FileName = "data.json";
        private readonly JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNameCaseInsensitive = true,
            IncludeFields = true
        };

        public void Save(WarehouseSystemState state)
        {
            var json = JsonSerializer.Serialize(state, options);
            File.WriteAllText(FileName, json);
        }

        public WarehouseSystemState Load()
        {
            if (!File.Exists(FileName)) return new WarehouseSystemState();
            return JsonSerializer.Deserialize<WarehouseSystemState>(File.ReadAllText(FileName), options)
            ?? new WarehouseSystemState();
        }
    }
}
