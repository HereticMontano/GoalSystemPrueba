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
            var ts = not.NotificarEliminacionesAsync("Cuadro");
            Task.WaitAll(ts);

            Assert.IsFalse(ts.Result);
        }

        [TestMethod]
        public void NotificarVencimiento()
        {
            Notificador not = new Notificador("http://www.ejemplo.com");
            var ts = not.NotificarVencimientoAsync("Cuadro");
            Task.WaitAll(ts);

            Assert.IsFalse(ts.Result);
        }
    }
}
