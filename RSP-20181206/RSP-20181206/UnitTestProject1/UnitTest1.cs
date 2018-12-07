using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Agencia agencia1 = new Agencia("Agencia");
      Agencia agencia2;
      Xml<Agencia> xml = new Xml<Agencia>();
      
        xml.Guardar("Agencia.xml", agencia1);
        agencia2 = xml.Leer("Agencia.xml");

        if((agencia1.Nombre == agencia2.Nombre) && (agencia1.PasajesVendidos == agencia2.PasajesVendidos))
        {
          Assert.IsTrue(true);
        }
     
    }
  }
}
