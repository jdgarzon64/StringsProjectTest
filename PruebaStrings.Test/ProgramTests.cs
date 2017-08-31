using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace PruebaStrings.Test
{
    [TestClass]
    public class ProgramTests
    {
        String a = "Hola Soy Una Frase";
        int b = 123456789;
        
        [TestMethod]
        public void TestMethod1()
        {
            //si retorna true es que la prueba ha pasado ya que si es letra
            var resultado = CambiarLetras.esLetra(a);
            Assert.IsTrue(resultado);
            //si retorna false es que no ha pasado prueba  ya que es un int
        }
        [TestMethod]
        public void TestMethod2()
        {
            //si retorna true es que la prueba ha pasado ya que si es letra
            var resultado = CambiarLetras.esLetra(b);
            Assert.IsTrue(resultado);
            //si retorna false es que no ha pasado prueba  ya que es un int
            
        }
    }
}
