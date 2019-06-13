using System;
using System.Linq;
using System.Xml.Linq;

namespace AdapterPattern.MakeBelieveExternalProvider
{
  public class UncleZebsWildAndCrazyManufacturerListing_API
  {
    public XDocument XML
    {
      get
      {
        var xDocument = new XDocument();
        var xElement = new XElement("Manufacturers");
        var xAttributes = CrazyZebsInternalManufacturerRepo.GetData()
            .Select(m => new XElement("Manufacturer",
                                new XAttribute("City", m.City),
                                new XAttribute("Name", m.Name),
                                new XAttribute("Year", m.Year)));

        xElement.Add(xAttributes);
        xDocument.Add(xElement);

        Console.WriteLine("This is your friendly external API returning your data in good ol' vintage XMl format\n" +
                            "Enjoy!");
        Console.WriteLine(xDocument);
        Console.ReadLine();

        return xDocument;
      }
    }
  }
}