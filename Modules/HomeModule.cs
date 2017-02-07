using Nancy;
using System.Collections.Generic;
using VilEbyCorp.CarDealership.Objects;

namespace VilEbyCorp.CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        if (Car.GetCounter() == 0)
        {
          Car carOne = new Car("2016 Honda CRV", 8000, "Tan/Black", "White", 25000);
          Car carTwo = new Car("2017 Honda CRV", 4000, "Orange", "Nasty Blue", 25000);
          Car carThree = new Car("2018 Honda CRV", 0001, "Pink", "Surrealist Skyscraper", 25000);
        }
        else{}
        List<Car> carList = Car.GetAll();
        return View["index.cshtml", carList];
      };

      Post["/add-new-car"] = _ => {
        string model = Request.Form["make-model"];
        int mileage = int.Parse(Request.Form["mileage"]);
        string interiorColor = Request.Form["interior-color"];
        string exteriorColor = Request.Form["exterior-color"];
        int price = int.Parse(Request.Form["price"]);
        Car newCar = new Car(model, mileage, interiorColor, exteriorColor, price);

        List<Car> carList = Car.GetAll();
        return View["added-car.cshtml", carList];
      };

      Post["/delete-car"] = _ => {
        int carIndex = int.Parse(Request.Form["delete-button"]);
        Car.PurchaseCar(carIndex);

        List<Car> carList = Car.GetAll();
        return View["delete-car.cshtml", carList];
      };
    }
  }
}
