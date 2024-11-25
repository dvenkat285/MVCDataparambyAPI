using Microsoft.AspNetCore.Mvc;
using MVCDataparambyAPI.Models;
using Newtonsoft.Json;
using System.Text;

namespace MVCDataparambyAPI.Controllers
{
    public class DataparamController : Controller
    {
        private string url = "https://localhost:44378/api/Dataparam/";
        private HttpClient client = new HttpClient();

       
        [HttpGet]
        [ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            List<Dataparam> dataparams = new List<Dataparam>();
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Dataparam>>(result);
                if(data != null)
                {
                    dataparams = data;
                }
            }
            return View(dataparams);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Dataparam data)
        {
            string dataparam = JsonConvert.SerializeObject(data);
            StringContent content = new StringContent(dataparam, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["insert_message"] = "Data Added...";
                return RedirectToAction("Index", "Dataparam");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int Did)
        {
            Dataparam dataparam = new Dataparam();
            HttpResponseMessage response = client.GetAsync(url + Did).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Dataparam>(result);
                if (data != null)
                {
                    dataparam = data;
                }
            }
            return View(dataparam);
        }
        [HttpPost]
        public IActionResult Edit(Dataparam data)
        {
            string dataparam = JsonConvert.SerializeObject(data);
            StringContent content = new StringContent(dataparam, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url + data.did, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["update_message"] = "Data Updated...";
                return RedirectToAction("Index", "Dataparam");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int Did)
        {
            Dataparam dataparam = new Dataparam();
            HttpResponseMessage response = client.GetAsync(url + Did).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Dataparam>(result);
                if (data != null)
                {
                    dataparam = data;
                }
            }
            return View(dataparam);
        }
        [HttpGet]
        public IActionResult Delete(int Did)
        {
            Dataparam dataparam = new Dataparam();
            HttpResponseMessage response = client.GetAsync(url + Did).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Dataparam>(result);
                if (data != null)
                {
                    dataparam = data;
                }
            }
            return View(dataparam);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Did)
        {
            HttpResponseMessage response = client.DeleteAsync(url + Did).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["delete_message"] = "Data Deleted...";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
