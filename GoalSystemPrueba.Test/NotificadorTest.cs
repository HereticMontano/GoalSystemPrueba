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
            bool result = not.NotificarEliminaciones("Cuadro");
          
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotificarVencimiento()
        {
            Notificador not = new Notificador("http://www.ejemplo.com");
            bool result = not.NotificarVencimiento("Cuadro");

            Assert.IsFalse(result);
        }
    }
}
