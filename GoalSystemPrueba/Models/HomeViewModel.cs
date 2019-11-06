using GoalSystemPrueba.Enum;
using GoalSystemPrueba.Models.Api;
using GoalSystemPrueba.Provider.Entity;
using System.Collections.Generic;

namespace GoalSystemPrueba.Models
{
    public class HomeViewModel : BaseViewModel
    {
        public List<ElementoModel> Datos;
        public HomeViewModel(List<Elemento> elementos)
        {
            Datos = new List<ElementoModel>();
            foreach (var item in elementos)
            {
                Datos.Add(new ElementoModel { Nombre = item.Nombre, FechaCaducidad = item.FechaCaducidad, Tipo = (TipoElementoEnum)item.Tipo });
            }
        }
    }
}