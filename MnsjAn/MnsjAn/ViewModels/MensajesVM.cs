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
   public class MensajesVM
    {
        public ObservableCollection<Mensajes> mensajesList { get; set; }

        public MensajesVM()
        {
            GetMensaje();
        }
        public async void GetMensaje()
        {
            mensajesList = new ObservableCollection<Mensajes>();

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://nglapi.000webhostapp.com/mensajes.php");

            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "application/json");

            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Mensajes>>(content);
                foreach (var result in resultado)
                {
                    mensajesList.Add(new Mensajes
                    {
                        id = result.id,
                        descripcion = result.descripcion,
                        tipo_id = result.tipo_id,
                        usuario_id = result.usuario_id,
                    });
                }
            }
        }
            }
}
