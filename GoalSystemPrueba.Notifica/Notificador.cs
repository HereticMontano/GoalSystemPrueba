using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoalSystemPrueba.Notifica
{
    public class Notificador
    {
        public Uri Domain;

        public Notificador(string domain)
        {
            Domain = new Uri(domain);
        }

        public async Task<bool> NotificarEliminaciones(string elemento)
        {
            using (var client = GenerarCliente())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Informacion/Eliminacion", new { ElementoEliminado = elemento });

                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> NotificarVencimiento(string elemento)
        {
            using (var client = GenerarCliente())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Informacion/Vencimiento", new { ElementoVencido = elemento });

                return response.IsSuccessStatusCode;
            }
        }

        private HttpClient GenerarCliente()
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = Domain;

            return cliente;
        }
    }
}
