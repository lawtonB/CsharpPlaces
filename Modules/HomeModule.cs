using System;
using Nancy;
using Places.Objects;
using System.Collections.Generic;

namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View["add_new_place.cshtml"];

      Post["/place_added"] = _ => {
        int intPopulation = int.Parse(Request.Form["new-population"]);
        Place newPlace = new Place (Request.Form["new-place"], Request.Form["new-picture"], intPopulation);
        newPlace.Save();
        Console.WriteLine(newPlace.GetPopulation());
        return View["place_added.cshtml", newPlace];
      };

      Post["/show_instances"] = _ => {
        List<Place> instances = Place.GetAll();
        return View["/show_instances.cshtml", instances];
      };
      Post["/places_cleared"] = _ => {
        // List<Place> instances = Place.GetAll();
        Place.ClearAll();
        return View["show_places.cshtml"];
      };







      // Get["/"] = _ => View["add_new_task.cshtml"];
      // Get["/view_all_tasks"] = _ => {
      //   List<string> allTasks = Task.GetAll();
      //   return View["view_all_tasks.cshtml", allTasks];
      // };
      // Post["/tasks_cleared"] = _ => {
      //   Task.ClearAll();
      //   return View["tasks_cleared.cshtml"];
      // };
      // Post["/task_added"] = _ => {
      //   Task newTask = new Task (Request.Form["new-task"]);
      //   newTask.Save();
      //   return View["task_added.cshtml", newTask];
      // };
    }
  }
}
