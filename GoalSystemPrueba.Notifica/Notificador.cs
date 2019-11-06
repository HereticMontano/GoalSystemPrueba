using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoalSystemPrueba.Notifica
{
    /// <summary>
    /// Objeto que se encarga de la notificacion entre sistemas
    /// </summary>
    public class Notificador
    {
        public Uri Domain;

        public Notificador(string domain)
        {
            Domain = new Uri(domain);
        }

        public async Task<bool> NotificarEliminacionesAsync(string elemento)
        {
            using (var client = GenerarCliente())
            {
                //Esto va a elevar una exepcion ya que a la URL que se le informa no existe
                try
                {
                    var response = await client.PostAsJsonAsync("api/Informacion/Eliminacion", new { ElementoEliminado = elemento });

                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
        }

        public async Task<bool> NotificarVencimientoAsync(string elemento)
        {
            using (var client = GenerarCliente())
            {
                //Esto va a elevar una exepcion ya que a la URL que se le informa no existe
                try
                {
                    var response = await client.PostAsJsonAsync("api/Informacion/Vencimiento", new { ElementoVencido = elemento });

                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
        }

        private HttpClient GenerarCliente()
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = Domain;
            cliente.Timeout = TimeSpan.FromSeconds(1);            

            return cliente;
        }
    }
}
