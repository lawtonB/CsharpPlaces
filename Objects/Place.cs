using System;
using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _cityName { get; set; }
    private string _picture { get; set; }
    private int _population { get; set; }

    private static List<string> _instances = new List<string> {};

    public Place (string cityName, string picture, int population)
    {
      _cityName = cityName;
    }
    public string GetCityName()
    {
      return _cityName;
    }
    public void SetCityName(string cityName)
    {
      _cityName = cityName;
    }
    public Place (string picture)
    {
      _picture =  picture;
    }
    public string GetPicture()
    {
      return _picture;
    }
    public void SetPicture(string picture)
    {
      _picture = picture;
    }
    public Place (int population)
    {
      _population = population;
    }
    public int GetPopulation()
    {
      return _population;
    }
    public void SetPopulation(int population)
    {
      _population = population;
    }
    public static List<string> GetAll()
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
