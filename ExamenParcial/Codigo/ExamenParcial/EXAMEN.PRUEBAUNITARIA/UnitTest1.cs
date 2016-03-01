using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EXAMEN.NEGOCIO;

namespace EXAMEN.PRUEBAUNITARIA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Entero ObjetoEntero = new Entero();
            int resultado;
            resultado = ObjetoEntero.Multiplicar(5,60);
            Assert.AreEqual(resultado,300);
        }
        [TestMethod]
        public void TestMethod2() 
        {
            Entero ObjetoEntero = new Entero();
            int resultado;
            resultado = ObjetoEntero.Dividir(25, 2);
            Assert.AreEqual(resultado,12);
        }
        [TestMethod]
        public void TestMethod3() 
        {
            Entero ObjetoEntero = new Entero();
            int resultado;
            resultado = ObjetoEntero.Suma(20, 10);
            Assert.AreEqual(resultado,30);
        }
        [TestMethod]
        public void TestMethod4() 
        {
            Entero ObjetoEntero = new Entero();
            int resultado;
            resultado = ObjetoEntero.Resta(10,20);
            Assert.AreEqual(resultado,-10);
        }
        [TestMethod]
        public void TestMethod5() 
        {/// numero=12546 resultado=146
            Entero numero = new Entero(12546);
            int resultado;
            resultado = numero.EliminarPrimos();
            Assert.AreEqual(resultado,146);
        }
        [TestMethod]
        public void TestMethod6() 
        {//numero=23467  resultado=76432
            Entero numero = new Entero(23467);
            int resultado;
            resultado = numero.InvertirNumero();
            Assert.AreEqual(resultado,76432);
        }
        [TestMethod]
        public void Factorial()
        {
            Entero numero = new Entero(0);
            Assert.AreEqual(1, numero.Factorial());
        }
    }
    
}
