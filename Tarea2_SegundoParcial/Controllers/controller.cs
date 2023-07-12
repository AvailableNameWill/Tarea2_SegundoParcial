using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tarea2_SegundoParcial.Config;
using Tarea2_SegundoParcial.Models;

namespace Tarea2_SegundoParcial.Controllers
{
    public class controller{
        public async static Task<List<Models.Clase>> getAll(){
            List<Models.Clase> clas = new List<Models.Clase>();

            using (HttpClient client = new HttpClient()) {
                HttpResponseMessage response = null;

                response = await client.GetAsync(config.apiGet1);
                if (response.IsSuccessStatusCode){
                    var result = response.Content.ReadAsStringAsync().Result;
                    clas = JsonConvert.DeserializeObject<List<Models.Clase>>(result);
                }
                return clas;
            }
        }

        public async static Task<Models.Clase> getById(string id){
            Clase clase = new Models.Clase();

            using(HttpClient client = new HttpClient()){
                HttpResponseMessage response = null;

                Config.config.postNum = id;
                response = await client.GetAsync(Config.config.getApi2(id));
                if (response.IsSuccessStatusCode){
                    var result = response.Content.ReadAsStringAsync().Result;
                    clase = JsonConvert.DeserializeObject<Clase>(result);
                }

                return clase;
            }
        }
    }
}
