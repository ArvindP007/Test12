using CallingWebAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CallingWebAPI2.Controllers
{
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:44313/api");
        HttpClient client;
        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult Index()
        {
            List<UserViewModel> modelList = new List<UserViewModel>();
            HttpResponseMessage response= client.GetAsync("https://localhost:44313/api/Students").Result;
            if (response.IsSuccessStatusCode)
            {
                string data= response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<UserViewModel>>(data);
            }
            return View(modelList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8,"application/json");
            HttpResponseMessage response = client.PostAsync("https://localhost:44313/api/Students",content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
                return View();
        }

        public ActionResult Edit(int id)
        {
            UserViewModel student = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Students/Id?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<UserViewModel>();
                    readTask.Wait();

                    student = readTask.Result;
                }
            }
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(UserViewModel model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<UserViewModel>("Students/Id?id=" + model.Id.ToString(), model);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
                return View(model);
        }
        public ActionResult delete(UserViewModel model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/");
                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Students/Id?id=" + model.Id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}

/*
 public ActionResult delete(int id)
        {
            UserViewModel student = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Students/Id?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<UserViewModel>();
                    readTask.Wait();

                    student = readTask.Result;
                }
            }
            return View(student);
        }
*/
