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
        //public List<IhaleListesi> ListIhale()
        //{
        //    List<IhaleListesi> ihale = new List<IhaleListesi>();
        //    if (url.Trim().Substring(0, 5).ToLower() == "https")
        //    {
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //    }

        //    try
        //    {
        //        HttpResponseMessage response = httpClient.GetAsync(url).Result;
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string result = response.Content.ReadAsStringAsync().Result;
        //            var datacol = JsonConvert.DeserializeObject<List<IhaleListesi>>(result);
        //            if (datacol != null)
        //            {
        //                ihale = datacol;
        //            }
        //        }
        //        else
        //        {

        //            string result = response.Content.ReadAsStringAsync().Result;
        //            throw new Exception("Error: " + result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error: " + ex.Message);
        //    }
        //    finally { }

        //    return ihale;
        //}
        //    public IhaleListesi CreateIhale(IhaleListesi ihale)
        //    {
        //        if (url.Trim().Substring(0, 5).ToLower() == "https")

        //            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //        string json = JsonConvert.SerializeObject(ihale);

        //        try
        //        {
        //            HttpResponseMessage response = httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json")).Result;
        //            if (response.IsSuccessStatusCode)
        //            {
        //                string result = response.Content.ReadAsStringAsync().Result;
        //                var data = JsonConvert.DeserializeObject<IhaleListesi>(result);
        //                if (data != null)

        //                    ihale = data;

        //            }
        //            else
        //            {

        //                string result = response.Content.ReadAsStringAsync().Result;
        //                throw new Exception("Error: " + result);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error: " + ex.Message);
        //        }
        //        finally { }

        //        return ihale;
        //    }
       }
    }


