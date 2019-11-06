using GoalSystemPrueba.Provider.Entity;
using System.Collections.Generic;

namespace GoalSystemPrueba.Provider.Interface
{
    public interface IInventarioProvider
    {
        List<Elemento> All();

        void AgregarElemento(Elemento elemento);

        int EliminarPorNombre(string nombre);
    }
}
