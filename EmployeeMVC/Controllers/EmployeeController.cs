using Microsoft.AspNetCore.Mvc;
using EmployeeMVC.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "http://localhost:5045/api/employee"; // Ganti dengan URL API Anda

        public EmployeeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: Employee (Read)
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            if (!response.IsSuccessStatusCode) return View(new List<Employee>());

            var json = await response.Content.ReadAsStringAsync();
            var employees = JsonSerializer.Deserialize<List<Employee>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(employees);
        }

        // GET: Employee/Create (Menampilkan Form)
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create (Menambahkan Data)
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            var json = JsonSerializer.Serialize(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_apiUrl, content);
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(employee);
        }

        // GET: Employee/Edit/{id} (Menampilkan Form Edit)
        public async Task<IActionResult> Edit(string id)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var employee = JsonSerializer.Deserialize<Employee>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(employee);
        }

        // POST: Employee/Edit/{id} (Mengupdate Data)
        [HttpPost]
        public async Task<IActionResult> Edit(string id, Employee employee)
        {
            var json = JsonSerializer.Serialize(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{_apiUrl}/{id}", content);
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(employee);
        }

        // GET: Employee/Delete/{id} (Menampilkan Konfirmasi Hapus)
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var employee = JsonSerializer.Deserialize<Employee>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(employee);
        }

        // POST: Employee/Delete/{id} (Menghapus Data)
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(string id)
            {
                var response = await _httpClient.DeleteAsync($"{_apiUrl}/{id}");
                if (response.IsSuccessStatusCode)
                    return RedirectToAction("Index");

                return NotFound();
            }

    }
}
