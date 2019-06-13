using System.Collections.Generic;

using AdapterPattern.Entities;

using Newtonsoft.Json;

namespace AdapterPattern
{
  public class JsonConverter
  {
    private IEnumerable<Manufacturer> _manufacturers;

    public JsonConverter(IEnumerable<Manufacturer> manufacturers) => _manufacturers = manufacturers;

    public string ConvertToJson()
    {
      return JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);
    }
  }
}