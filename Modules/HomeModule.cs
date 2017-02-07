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
        Car myCar = new Car();
        myCar.SetMakeModel("2016 Honda CRV");
        return View["index.cshtml", myCar];
      };
    }
  }
}
