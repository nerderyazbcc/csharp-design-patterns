using Newtonsoft.Json;

using PatternsSampleDemo.Entities;

using System.Collections.Generic;

namespace PatternsSampleDemo
{
  public class JsonConverter
  {
    readonly IEnumerable<Manufacturer> _manufacturers;

    public JsonConverter(IEnumerable<Manufacturer> manufacturers) => _manufacturers = manufacturers;

    public string ConvertToJson() => JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);
  }
}