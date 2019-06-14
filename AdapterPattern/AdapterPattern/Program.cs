using PatternsSampleDemo;
using PatternsSampleDemo.MakeBelieveExternalProvider;

using System;

namespace PatternsSample
{
  internal class Program
  {
    private static void Main()
    {
      var xmlManufacturerDataIn = new UncleZebsWildAndCrazyManufacturerListingAPIWrapper();
      var adapter = new ManufacturerXmlToJsonAdapter(xmlManufacturerDataIn);

      Console.WriteLine(adapter.RetrieveManufacturersAsJson());
      _ = Console.ReadLine();
    }
  }
}