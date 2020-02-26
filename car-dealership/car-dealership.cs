using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthBuying(int maxPrice, int maxMileage)
  {
    return (Price <= maxPrice && Miles <= maxMileage);
  }
}


// public class Program
// {
//   public static void Main()
//   {
//     Car volkswagen = new Car();
//     volkswagen.MakeModel = "1974 Volkswagen Thing";
//     volkswagen.Price = 1100;
//     volkswagen.Miles = 368792;

//     Car yugo = new Car();
//     yugo.MakeModel = "1980 Yugo Koral";
//     yugo.Price = 700;
//     yugo.Miles = 56000;

//     Car ford = new Car();
//     ford.MakeModel = "1988 Ford Country Squire";
//     ford.Price = 1400;
//     ford.Miles = 239001;

//     Car amc = new Car();
//     amc.MakeModel = "1976 AMC Pacer";
//     amc.Price = 400;
//     amc.Miles = 198000;

//     List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

//     Console.WriteLine("Enter maximum price: ");
//     string stringMaxPrice = Console.ReadLine();
//     int maxPrice = int.Parse(stringMaxPrice);

//     List<Car> CarsMatchingSearch = new List<Car>(0);

//     foreach (Car automobile in Cars)
//     {
//       if (automobile.WorthBuying(maxPrice))
//       {
//         CarsMatchingSearch.Add(automobile);
//       }
//     }

//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }

public class Program
{
    public static void Main()
    {
        Car bmw = new Car();
        bmw.MakeModel = "2020 BMW 3 Series";
        bmw.Price = 20000;
        bmw.Miles = 10;

        Car tacoma = new Car();
        tacoma.MakeModel = "2020 Toyota Tacoma";
        tacoma.Price = 25000;
        tacoma.Miles = 1000;

        Car mustang = new Car();
        mustang.MakeModel = "2020 Ford Mustang";
        mustang.Price = 15000;
        mustang.Miles = 100;

        Car prius = new Car();
        prius.MakeModel = "2020 Toyota Prius";
        prius.Price = 10000;
        prius.Miles = 500; 

        List<Car> Cars = new List<Car>() { bmw, tacoma, mustang, prius };

        Console.WriteLine("What is your budget");
        string stringmaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringmaxPrice);
        Console.WriteLine("What is your mileage");
        string stringmaxMileage = Console.ReadLine();
        int maxMileage = int.Parse(stringmaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMileage))
      {
        CarsMatchingSearch.Add(automobile);
      } 
    }

    if(CarsMatchingSearch.Count == 0) {
        Console.WriteLine("No cars, sorry.");
    }
    else {
        foreach(Car automobile in CarsMatchingSearch)
        {
        Console.WriteLine(automobile.MakeModel);
        }
    }

  }
}