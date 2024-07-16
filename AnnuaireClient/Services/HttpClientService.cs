using AnnuaireModel.Dao;
using NegosudWpf.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AnnuaireClient.Services
{
    public static class HttpClientService
    {
        private const string baseAddress = "https://localhost:7139/";
        private static HttpClient? client = null;

        private static HttpClient Client
        {
            get
            {
                if (client == null)
                    client = new() { BaseAddress = new Uri(baseAddress) };
                return client;
            }
        }


        //requête GET pour récupérer un salarié spécifique en fonction de son identifiant.
        #region Salaries
        public static async Task<Salarie> GetSalarie(int salarieId)
        {
            string route = $"api/Salaries/{salarieId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Salarie>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }


        //requête GET pour récupérer tous les salariés
        public static async Task<ObservableCollection<Salarie>> GetAllSalaries()
        {
            string route = $"api/Salaries";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Salarie>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }


        //requête POST pour créer un nouveau salarié en envoyant des données JSON
        public static async Task CreateSalarie(Salarie salarie)
        {
            string route = $"api/Salaries";
            string json = JsonConvert.SerializeObject(salarie);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }


        //requête DELETE pour supprimer un salarié en fonction de son identifiant
        public static async Task DeleteSalarie(int id)
        {
            string route = $"api/Salaries/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }



        //requête PUT pour mettre à jour les informations d'un salarié spécifique
        public static async Task UpdateSalarie(Salarie salarie)
        {
            string route = $"api/Salaries/{salarie.Id}";

            string json = JsonConvert.SerializeObject(salarie);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        #endregion


        //Même méthodes que pour Salariés
        #region Sites
        public static async Task<Site> GetSite(int siteId)
        {
            string route = $"api/Sites/{siteId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Site>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Site>> GetAllSites()
        {
            string route = $"api/Sites";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Site>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateSite(Site site)
        {
            string route = $"api/Sites";
            string json = JsonConvert.SerializeObject(site);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task DeleteSite(int id)
        {
            string route = $"api/Sites/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateSite(Site site)
        {
            string route = $"api/Sites/{site.Id}";

            string json = JsonConvert.SerializeObject(site);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        #endregion




        //Même méthodes que pour Salariés

        #region Services
        public static async Task<Service> GetService(int serviceId)
        {
            string route = $"api/Services/{serviceId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Service>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Service>> GetAllServices()
        {
            string route = $"api/Services";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Service>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateService(Service service)
        {
            string route = $"api/Services";
            string json = JsonConvert.SerializeObject(service);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task DeleteService(int id)
        {
            string route = $"api/Services/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateService(Service service)
        {
            string route = $"api/Services/{service.Id}";

            string json = JsonConvert.SerializeObject(service);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        #endregion


        //requête POST pour se connecter avec un email prédéfinie
        public static async Task<bool> Login(string pwd)
        {
            string route = "login?useCookies=true&useSessionCookies=true";
            var jsonString = JsonConvert.SerializeObject(new LoginUser
            {
                Email = "florianbelkadi@gmail.com",
                Password = pwd
            });

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(route, httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}
