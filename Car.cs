using System;

namespace Dealership.Models
{
public class Car
{
  private string _makeModel;
  public string MakeModel
    {
      get 
      {
          return _makeModel;
      }
      set 
      {
          _makeModel = value;
      }
    }
  private int _price;
  private int _miles;

//DRYER VERSION WITH AUTO-IMPLEMENTED PROPERTIES (BUT WOULD NEED TO CHANGE IN THE REST OF THE PROGRAM)
  // public string MakeModel {get; set; }
  // public int Price { get; set; }
  // public int Miles { get; set; }

  public static string MakeSound(string sound)
  {
    return "Our cars sound like " + sound;
  }

  public Car(string makeModel, int price, int miles)
  {
    _makeModel = makeModel;
    _price = price;
    _miles = miles;
  }

  public string GetMakeModel()
  {
    return _makeModel;
  }

  public int GetPrice()
  {
    return _price;
  }

  public int GetMiles()
  {
    return _miles;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (_price <= maxPrice);
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
}
}

