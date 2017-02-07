namespace VilEbyCorp.CarDealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _mileage;
    private string _interiorColor;
    private string _exteriorColor;
    private int _price;

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
  }
}
