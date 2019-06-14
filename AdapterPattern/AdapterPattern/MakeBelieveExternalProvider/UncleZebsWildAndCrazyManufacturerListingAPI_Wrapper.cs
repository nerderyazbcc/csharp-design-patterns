using PatternsSampleDemo.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PatternsSampleDemo.MakeBelieveExternalProvider
{
  public class UncleZebsWildAndCrazyManufacturerListingAPIWrapper : ISomeXMLStandardForManufacturerListings
  {
    public XDocument GetXML()
    {
      var xDocument = new XDocument();
      var xElement = new XElement("Manufacturers");
      IEnumerable<XElement> xAttributes = CrazyZebsInternalManufacturerRepo.GetData()
          .Select(m => new XElement("Manufacturer",
                              new XAttribute("City", m.City),
                              new XAttribute("Name", m.Name),
                              new XAttribute("Year", m.Year)));

      xElement.Add(xAttributes);
      xDocument.Add(xElement);

      Console.WriteLine("This is your friendly external API returning your data in good ol' vintage XMl format!\n" +
                          "Enjoy!");
      Console.WriteLine(xDocument);
      _ = Console.ReadLine();

      return xDocument;
    }
  }
}