using AracIhale.UI.Models;
using AracIhale.UI.Models.VM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI
{
    public class APIGateway
    {
        private string url = "http://localhost:36989/api/Ihale";
        private string ihaleTeklifUrl = "http://localhost:36989/api/IhaleTeklif";
        private HttpClient httpClient = new HttpClient();
        public async Task<List<IhaleListesi>> ListIhale()
        {
            List<IhaleListesi> ihale = new List<IhaleListesi>();
            if (url.Trim().Substring(0, 5).ToLower() == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var datacol = JsonConvert.DeserializeObject<List<IhaleListesi>>(result);
                    if (datacol != null)
                    {
                        ihale = datacol;
                    }
                }
                else
                {

                    string result = await response.Content.ReadAsStringAsync();
                    throw new Exception("Error: " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally { }

            return ihale;
        }
        public IhaleListesi CreateIhale(IhaleListesi ihale)
        {
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string json = JsonConvert.SerializeObject(ihale);

            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json")).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<IhaleListesi>(result);
                    if (data != null)
                        ihale = data;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error: " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return ihale;
        }

        public async Task<List<BireyselAracTeklif>> ListIhaleTeklif()
        {
            List<BireyselAracTeklif> ihale = new List<BireyselAracTeklif>();
            if (ihaleTeklifUrl.Trim().Substring(0, 5).ToLower() == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(ihaleTeklifUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var datacol = JsonConvert.DeserializeObject<List<BireyselAracTeklif>>(result);
                    if (datacol != null)
                    {
                        ihale = datacol;
                    }
                }
                else
                {

                    string result = await response.Content.ReadAsStringAsync();
                    throw new Exception("Error: " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally { }

            return ihale;
        }
        private async Task<string> KullaniciAdiniBulAsync(int kullaniciID)
        {
            string apiUrl = "http://localhost:36989/api/Login";

            using (HttpClient client = new HttpClient())
            {
                string endpoint = $"{apiUrl}/{kullaniciID}";
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Kullanici user = JsonConvert.DeserializeObject<Kullanici>(json);
                    return user.KullaniciAdi;
                }
            }

            return string.Empty;
        }

        //public async Task<bool> CreateIhale(IhaleListesi ihale)
        //{
        //    var apiUrl = "http://localhost:36989/api/Ihale";
        //    var content = new StringContent(JsonConvert.SerializeObject(ihale), Encoding.UTF8, "application/json");

        //    var response = await httpClient.PostAsync(apiUrl, content);

        //    return response.IsSuccessStatusCode;
        //}
        public async Task<bool> CreateIhaleTeklif(BireyselAracTeklif ihale)
        {
            var apiUrl = "http://localhost:36989/api/IhaleTeklif";
            var content = new StringContent(JsonConvert.SerializeObject(ihale), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(apiUrl, content);

            return response.IsSuccessStatusCode;
        }
        public async Task<IhaleListesi> GetIhaleById(int IhaleID)
        {
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url + IhaleID);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<IhaleListesi>(result);
                    return data;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    throw new Exception("Error: " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        
        public async Task<bool> DeleteIhaleTeklif(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"{ihaleTeklifUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
        public async Task<IhaleListesi> GetIhale(int id)
        {
            var apiUrl = "http://localhost:36989/api/Ihale/" + id;

            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ihale = JsonConvert.DeserializeObject<IhaleListesi>(content);
                return ihale;
            }

            return null;
        }
        public async Task<BireyselAracTeklif> GetIhaleTeklif(int id)
        {
            var apiUrl = "http://localhost:36989/api/Ihale/" + id;

            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ihaleTeklif = JsonConvert.DeserializeObject<BireyselAracTeklif>(content);
                return ihaleTeklif;
            }

            return null;
        }
        public async Task<bool> UpdateIhale(IhaleListesi ihale)
        {
            var apiUrl = "http://localhost:36989/api/Ihale/" + ihale.IhaleID;
            var content = new StringContent(JsonConvert.SerializeObject(ihale), Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(apiUrl, content);

            return response.IsSuccessStatusCode;
        }


        public async Task<bool> DeleteIhale(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"{url}/{id}");
            return response.IsSuccessStatusCode;
        }


    }
    }


