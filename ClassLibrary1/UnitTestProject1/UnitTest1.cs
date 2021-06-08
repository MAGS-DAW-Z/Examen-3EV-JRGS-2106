using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;
//MAGS2021
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);
            double total = 0;
            double media = 0;
            for (int i = 0; i < notas.Count; i++)
            {
                total = total + notas[i];
            }
            media = total / notas.Count;
            double mediaEsperada = media;
            int susE = 3;
            int aprE = 1;
            int notE = 2;
            int sbrE = 1;
        }
        [TestMethod]
        [ExpectedException(typeof[ExcepcionNoHayNotas]){

            }
    }
}
