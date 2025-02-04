﻿using PatternsSampleDemo.Entities;

using System.Collections.Generic;

namespace PatternsSampleDemo.MakeBelieveExternalProvider
{
  public static class CrazyZebsInternalManufacturerRepo
  {
    public static List<Manufacturer> GetData() =>
       new List<Manufacturer>
       {
                new Manufacturer { City = "Italy", Name = "Alfa Romeo", Year = 2016 },
                new Manufacturer { City = "UK", Name = "Aston Martin", Year = 2018 },
                new Manufacturer { City = "USA", Name = "Dodge", Year = 2017 },
                new Manufacturer { City = "Japan", Name = "Subaru", Year = 2016 },
                new Manufacturer { City = "Germany", Name = "BMW", Year = 2015 }
       };
  }
}