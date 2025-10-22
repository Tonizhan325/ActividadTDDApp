using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public long Es_Menor_A_0()
        {
            long result = Funciones.CalcularFactorial(-2);
            Assert.AreEqual(-1, result);
        }

        public long Es_Igual_A_0()
        {
            long result = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, result);
        }

        public long Es_Mayor_A_0()
        {
            long result = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120, result);
        }
    }
}
