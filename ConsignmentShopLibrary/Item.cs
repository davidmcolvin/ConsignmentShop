using System;
using System.Collections.Generic;
using System.Text;
using static ConsignmentShopLibrary.EnumUtility.ConsignmentShopLibraryEnums;

namespace ConsignmentShopLibrary
{
  public class Item
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public ItemStatus Status { get; set; }
    public Vendor Owner { get; set; }

    public string Display
    {
      get { return string.Format( "{0} - ${1}", Title, Price ); }
    }

  }
}
