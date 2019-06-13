using System;
using System.Linq;

using AdapterPattern.Entities;
using AdapterPattern.Interfaces;
using AdapterPattern.MakeBelieveExternalProvider;

namespace AdapterPattern
{
  public class ManufacturerXmlToJsonAdapter : IManufacturerXmlToJsonAdapter
  {
    private readonly UncleZebsWildAndCrazyManufacturerListing_API _manufacturerEndpoint;

    public ManufacturerXmlToJsonAdapter(UncleZebsWildAndCrazyManufacturerListing_API ManufacturerEndpoint) => 
                                              _manufacturerEndpoint = ManufacturerEndpoint;

    public string RetrieveManufacturersAsJson()
    {
      var manufacturers = _manufacturerEndpoint.XML              .Element("Manufacturers")
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