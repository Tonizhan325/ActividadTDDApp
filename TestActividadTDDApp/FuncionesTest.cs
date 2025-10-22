using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void Es_Menor_A_0()
        {
            long result = Funciones.CalcularFactorial(-2);
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void Es_Igual_A_0()
        {
            long result = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Es_Mayor_A_0()
        {
            long result = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void NoEstaVacia()
        {
            bool result = Funciones.EsContrasenyaValida("");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NoEsNull()
        {
            bool result = Funciones.EsContrasenyaValida(null);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TieneLongitud()
        {
            bool result = Funciones.EsContrasenyaValida("123456");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ContieneAlmohadilla()
        {
            bool result = Funciones.EsContrasenyaValida("123456789");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EstaBien()
        {
            bool result = Funciones.EsContrasenyaValida("12345678#");
            Assert.IsTrue(result);
        }
    }
}
