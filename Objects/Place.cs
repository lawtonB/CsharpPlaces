using System;
using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _cityName;
    private string _picture;
    private int _population;

    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName, string picture, int population)
    {
      _cityName = cityName;
      _picture = picture;
      _population = population;
    }
    public string GetCityName()
    {
      return _cityName;
    }
    public void SetCityName(string cityName)
    {
      _cityName = cityName;
    }
    public string GetPicture()
    {
      return _picture;
    }
    public void SetPicture(string picture)
    {
      _picture = picture;
    }
    public int GetPopulation()
    {
      return _population;
    }
    public void SetPopulation(int population)
    {
      _population = population;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
