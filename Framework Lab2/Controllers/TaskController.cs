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
        public string createdBy {  get; set; }
    }
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return Content("Aceasta este o listă de sarcini");
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Store()
        {
            return View();
        }
        public IActionResult Show()
        {
            Task task = new Task { id = 1, title = "Titlul sarcinii", description = "Descriere sarcina", dateCreated = DateTime.Now.ToString(), dateUpdated = DateTime.Now.ToString(), action = 1, state = 0, priority = 2, createdBy = "Dorogan Vadim"};
            return View(task);
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Destroy()
        {
            return View();
        }
        // Adăugați validarea parametrilor rutei id pentru sarcini. Asigurați-vă că parametrul id este un număr întreg pozitiv. Utilizați metoda where pentru a limita valorile parametrului id.
        public IActionResult IdValidate(int id)
        {
            if(id != 0)return Content($"ID-ul = {id}");
            else return Content($"Nu exista id");
        }
    }
}
