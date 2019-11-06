using GoalSystemPrueba.Provider.Entity;

namespace GoalSystemPrueba.Provider.Interface
{
    public interface IInventarioProvider : IBaseProvider<Elemento, string>
    {
        Elemento GetMasAntiguo();
    }
}
