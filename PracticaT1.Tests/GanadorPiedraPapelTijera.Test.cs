using System;
using System.Collections.Generic;
using System.Text;
using PracticaT1;

namespace PracticaT1.Tests
{
    class GanadorPiedraPapelTijera
    {


        public void Caso01PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador1.Elije = "1";
            Jugador2.Elije = "2";
            var result = ganador.VerGanador(Jugador1, Jugador2);
            Assert.AreEqual("Empate", result);
        }
    }
