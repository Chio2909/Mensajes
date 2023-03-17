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
    public class UserVM
    {
        public ObservableCollection<User> userList { get; set; }

        public UserVM()
        {
            GetUser();
        }
        public async void GetUser()
        {
            userList = new ObservableCollection<User>();

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://nglapi.000webhostapp.com/user.php");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "application/json");

            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<User>>(content);
                foreach (var result in resultado)
                {
                   userList.Add(new User
                    {
                        id = result.id,
                        nombre = result.nombre
                    
                    });
                }
            }
        }

    }

    }


            //  public async void LoginUser()
            //  {  
            //user use = new user
            //{
            //    nombre = txtuser.text
            //};

            //uri requesturi = new uri("https://nglapi.000webhostapp.com/user.php"); //aqui deben colocar su url
            //var client = new httpclient();
            //var json = jsonconvert.serializeobject(use);
            //var contentjson = new stringcontent(json, encoding.utf8, "application/json");
            //var response = await client.postasync(requesturi, contentjson);
            //if (response.statuscode == httpstatuscode.ok)
            //{
            //    await navigation.pushasync(new play());
            //}
            //else
            //{
            //    await displayalert("mensaje", "datos invalidos", "ok");
            //}

            // }

