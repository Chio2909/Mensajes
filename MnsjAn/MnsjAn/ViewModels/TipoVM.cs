using MnsjAn.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Text;

namespace MnsjAn.ViewModels
{
    public class TipoVM
    {
        public ObservableCollection<Tipo> tipoList { get; set; }

        public TipoVM()
        {
            GetTipo();
        }
        public async void GetTipo()
        {
            tipoList = new ObservableCollection<Tipo>();

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://nglapi.000webhostapp.com/tipo.php");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "application/json");

            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Tipo>>(content);
                foreach (var result in resultado)
                {
                    tipoList.Add(new Tipo
                    {
                        id = result.id,
                        mensaje = result.mensaje,
                        siglas = result.siglas,
                        enlace = result.enlace

                    });
                }
            }
        }
    }
}
