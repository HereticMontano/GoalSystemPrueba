using System.Collections.Generic;

namespace GoalSystemPrueba.Provider.Interface
{
    public interface IBaseProvider<T,I>
    {
        List<T> All();

        T GetById(I id);

        void Agregar(T elemento);

        int Eliminar(I id);
    }
}
