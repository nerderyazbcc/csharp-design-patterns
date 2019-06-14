using PatternsSampleDemo.Entities;
using PatternsSampleDemo.Interfaces;
using PatternsSampleDemo.MakeBelieveExternalProvider;

using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternsSampleDemo
{
  public class ManufacturerXmlToJsonAdapter : IManufacturerXmlToJsonAdapter
  {
    private readonly UncleZebsWildAndCrazyManufacturerListingAPIWrapper _manufacturerEndpoint;

    public ManufacturerXmlToJsonAdapter(UncleZebsWildAndCrazyManufacturerListingAPIWrapper ManufacturerEndpoint) =>
                                              _manufacturerEndpoint = ManufacturerEndpoint;

    public string RetrieveManufacturersAsJson()
    {
      IEnumerable<Manufacturer> manufacturers = _manufacturerEndpoint.GetXML().Element("Manufacturers")
              .Elements("Manufacturer")
              .Select(m => new Manufacturer
              {
                City = m.Attribute("City").Value,
                Name = m.Attribute("Name").Value,
                Year = Convert.ToInt32(m.Attribute("Year").Value)
              });

      return new JsonConverter(manufacturers)
          .ConvertToJson();
    }
  }
}