using System.Collections.Generic;

namespace VilEbyCorp.CarDealership.Objects
{
  public class Car
  {

    private string _makeModel;
    private int _mileage;
    private string _interiorColor;
    private string _exteriorColor;
    private int _price;
    private static List<Car> _instances = new List<Car> {};
    private static int _counter = 0;
    private int _id;

    public Car(string makeModel, int mileage, string interiorColor, string exteriorColor, int price)
    {
      SetMakeModel(makeModel);
      SetMileage(mileage);
      SetInteriorColor(interiorColor);
      SetExteriorColor(exteriorColor);
      SetPrice(price);
      SetCounter();
      _instances.Add(this);
    }

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetMileage(int newMileage)
    {
      _mileage = newMileage;
    }

    public int GetMileage()
    {
      return _mileage;
    }

    public void SetInteriorColor(string newColor)
    {
      _interiorColor = newColor;
    }

    public string GetInteriorColor()
    {
      return _interiorColor;
    }

    public void SetExteriorColor(string newColor)
    {
      _exteriorColor = newColor;
    }

    public string GetExteriorColor()
    {
      return _exteriorColor;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetPrice()
    {
      return _price;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void SetCounter()
    {
      _id = GetCounter();
      _counter++;
    }

    public int GetId(){
      return _id;
    }

    public static int GetCounter()
    {
      return _counter;
    }

    public static void PurchaseCar(int input)
    {
      _instances.RemoveAt(input);
    }
  }
}
