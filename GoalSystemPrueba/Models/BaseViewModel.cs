namespace GoalSystemPrueba.Models
{
    /// <summary>
    /// Modelo base para todas las vistas
    /// </summary>
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            Title = "GoalSystem Prueba";
        }

        public string Title { get; set; }
    }
}