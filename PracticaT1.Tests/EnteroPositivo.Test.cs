using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PracticaT1;


namespace PracticaT1.Tests
{
    public class EnteroPositivo
    {
        //[Test]
        //public void Caso01EnterosPositivos()
        //{
        //    var EnterPos = new EnteroPositivo();
        //    var result = EnterPos.Entero_Positivo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        //    Assert.AreEqual(9, result);
        //}


        public void Caso01EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(18);

            Assert.AreEqual("XVIII", resultado);

        }
        public void Caso02EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(-1);

            Assert.AreEqual("-I", resultado);

        }
        public void Caso03EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(0);

            Assert.AreEqual(" ", resultado);

        }
        public void Caso04EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(10);

            Assert.AreEqual("X", resultado);

        }
        public void Caso05EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(100);

            Assert.AreEqual("C", resultado);

        }
        public void Caso06EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(100);

            Assert.AreEqual("CC", resultado);

        }

        public void Caso07EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(900);

            Assert.AreEqual("CM", resultado);

        }
        public void Caso08EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(-1,-2,-3,-4,-5);

            Assert.AreEqual("-I,-II,-III,-IV,-V", resultado);

        }
        public void Caso09EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(-100);

            Assert.AreEqual("-C", resultado);

        }
        public void Caso10EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(80);

            Assert.AreEqual("LXXX", resultado);

        }
        public void Caso11EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(30);

            Assert.AreEqual("XXX", resultado);

        }
        public void Caso12EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(300);

            Assert.AreEqual("CCC", resultado);

        }
        public void Caso13EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(700);

            Assert.AreEqual("DCC", resultado);

        }
        public void Caso14EnterosPositivos_Romano()
        {
            EnteroPositivo util = new EnteroPositivo();

            var resultado = util.Convertir_Romano(1000);

            Assert.AreEqual("M", resultado);

        }

    }
}
