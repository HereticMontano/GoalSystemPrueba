using GoalSystemPrueba.Notifica;
using System.Configuration;

namespace GoalSystemPrueba.Singleton
{
    public static class NotificadorSingleton
    {
        private static Notificador _notificador;
        public static Notificador GetInstance
        {
            get
            {
                if (_notificador == null)
                {
                    _notificador = new Notificador("http://www.ejemplo.com");
                }
                return _notificador;
            }
        }
    }
}