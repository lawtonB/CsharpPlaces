using Nancy;
using Places.Objects;
using System.Collections.Generic;

namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View["add_new_place.cshmtl"];
      Post["/show_instances"] = _ => {
        Place newPlace = new Place (Request.Form["new-place"],Request.Form["new-picture"],Request.Form["new-population"]);
        List<Place> instances = new List<Place>() {};
        instances.Save(newPlace);
        
        return View["show_instances", instances];
      };
      Post["/places_cleared"] = _ => {
        instances.ClearAll();
        return View["show_places", instances];
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
