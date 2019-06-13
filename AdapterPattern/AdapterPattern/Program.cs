using System;

using AdapterPattern.MakeBelieveExternalProvider;

namespace AdapterPattern
{
  internal class Program
  {
    private static void Main()
    {
      var xmlManufacturerDataIn = new UncleZebsWildAndCrazyManufacturerListing_API();
      var adapter = new ManufacturerXmlToJsonAdapter(xmlManufacturerDataIn);

      Console.WriteLine(adapter.RetrieveManufacturersAsJson());
      Console.ReadLine();
    }
  }
}