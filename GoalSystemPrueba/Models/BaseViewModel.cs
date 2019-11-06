namespace GoalSystemPrueba.Models
{
    /// <summary>
    /// Modelo base para todas las vistas
    /// </summary>
    public class BaseViewModel
    {
        public string Title { get; set; }

        public BaseViewModel()
        {
            Title = "GoalSystem Prueba";
        }
    }
}