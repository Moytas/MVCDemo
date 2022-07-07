using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class InfoController : Controller
    {
        //List<ModelClass> models = new List<ModelClass>(){
        //    new ModelClass(){ Id = 1, Name = "a"},
        //    new ModelClass(){ Id = 2, Name = "b"},
        //    new ModelClass(){ Id = 3, Name = "c"},
        //    new ModelClass(){ Id=4, Name = "d"}
        //};
        public IActionResult Show()
        {
            DBManager db = new DBManager();
            List<ModelClass> _list = new List<ModelClass>();
            foreach(var element in db.DBElements)
            {
                _list.Add(element);
            }
            return View(_list);
        }

        public IActionResult CreateList()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult EditListItem()
        {
            return View();
        }

        public IActionResult EmptyView()
        {
            return View();
        }
    }
}
