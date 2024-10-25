using Microsoft.AspNetCore.Mvc;

namespace Framework_Lab2.Controllers
{
    class Task
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string dateCreated { get; set; }
        public string dateUpdated { get; set; }
        
        //1 - editare, 2 - stergere
        public int action { get; set; }
        
        //1 - finalizată, 0 - nu este finalizată
        public int state {  get; set; }
        
        //1 - scăzută, 2 - medie, 3 - ridicată
        public int priority {  get; set; }
        public string createdBy { get; set; }
    };
    //[Route("Tasks")]
    public class TaskController : Controller
    {
        List<Task> tasklist = new List<Task>();
        
        //[HttpGet]
        public IActionResult Index()
        {
            tasklist.Add(new Task { id = 1, title = "Titlul sarcinii1", description = "Descriere sarcina1", dateCreated = DateTime.Now.ToString(), dateUpdated = DateTime.Now.ToString(), action = 1, state = 0, priority = 2, createdBy = "Dorogan Vadim" });
            tasklist.Add(new Task { id = 2, title = "Titlul sarcinii2", description = "Descriere sarcina2", dateCreated = DateTime.Now.ToString(), dateUpdated = DateTime.Now.ToString(), action = 1, state = 1, priority = 3, createdBy = "Dorogan Vadim" });
            tasklist.Add(new Task { id = 3, title = "Titlul sarcinii3", description = "Descriere sarcina3", dateCreated = DateTime.Now.ToString(), dateUpdated = DateTime.Now.ToString(), action = 1, state = 0, priority = 1, createdBy = "Dorogan Vadim" });
            tasklist.Add(new Task { id = 4, title = "Titlul sarcinii4", description = "Descriere sarcina4", dateCreated = DateTime.Now.ToString(), dateUpdated = DateTime.Now.ToString(), action = 2, state = 1, priority = 2, createdBy = "Dorogan Vadim" });
            //return Content("Aceasta este o listă de sarcini");
            return View(tasklist);
        }
        //[HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }
        //[HttpGet("store")]
        public IActionResult Store()
        {
            return View();
        }
        //[HttpGet("show")]
        public IActionResult Show()
        {
            Task task = new Task { id = 1, title = "Titlul sarcinii", description = "Descriere sarcina", dateCreated = DateTime.Now.ToString(), dateUpdated = DateTime.Now.ToString(), action = 1, state = 0, priority = 2, createdBy = "Dorogan Vadim"};
            return View(task);
        }
        //[HttpGet("edit")]
        public IActionResult Edit()
        {
            return View();
        }
        //[HttpGet("update")]
        public IActionResult Update()
        {
            return View();
        }
        //[HttpGet("destroy")]
        public IActionResult Destroy()
        {
            return View();
        }
        
        //[HttpGet("IdValidate/{id?}")]
        public IActionResult IdValidate(int? id)
        {
            if(id != 0)return Content($"ID-ul = {id}");
            else return Content($"Nu exista id");
        }
    }
}
