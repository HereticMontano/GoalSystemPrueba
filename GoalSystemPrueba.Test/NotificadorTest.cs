using GoalSystemPrueba.Notifica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace GoalSystemPrueba.Test
{
    [TestClass]
    public class NotificadorTest
    {
        [TestMethod]
        public void NotificarEliminacion()
        {
            Notificador not = new Notificador("http://www.ejemplo.com");
            Task<bool> t = not.NotificarEliminaciones("Cuadro");
          
            Assert.IsFalse(t.Result);
        }

        public void NotificarVencimiento()
        {
            Notificador not = new Notificador("http://www.ejemplo.com");
            Task<bool> t = not.NotificarVencimiento("Cuadro");

            Assert.IsFalse(t.Result);
        }
    }
}
