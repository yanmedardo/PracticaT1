using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PracticaT1;


namespace PracticaT1.Tests
{
    public class EnteroPositivo
    {
        [Test]
        public void SumaParesCaso01()
        {
            var EnterPos = new EnteroPositivo();
            var result = au.Entero_Positivo(new int[] { 1, 2, 3, 4,5, 6,7,8,9 });

            Assert.AreEqual(14, result);
        }

    }
}
