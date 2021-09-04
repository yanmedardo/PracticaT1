using System;
using System.Collections.Generic;
using System.Text;
using PracticaT1;

namespace PracticaT1.Tests
{
    class GanadorPiedraPapelTijera
    {

  //     "1.PIEDRA"
		//"2. PAPEL"
		//"3. TIJERAS"
        public void Caso01PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "1";
            Computador.Elije = "1"; //La pc o maquina u/otro  judor
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Empate", result);
        }

        public void Caso02PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "1";
            Computador.Elije = "3";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Pierde", result);
        }

        public void Caso03PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "1";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Empate", result);
        }
        public void Caso04PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "2";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("gana", result);
        }

        public void Caso05PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "3";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Ganó", result);
        }
        public void Caso06PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "3";
            Computador.Elije = "3";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Empate", result);
        }
        public void Caso07PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "3";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Ganó", result);
        }
        public void Caso08PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = "3";
            Computador.Elije = "2";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Perdió", result);
        }
        public void Caso09PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = " "; 
            Computador.Elije = " ";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Elijaopcion", result);
        }
        public void Caso10PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = " ";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Usuaio no elijio opcion", result);
        }
        public void Caso11PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = " 1";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Empate", result);
        }
        public void Caso12PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = " 2";
            Computador.Elije = "1";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Perdió", result);
        }
        public void Caso13PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = " 1";
            Computador.Elije = "3";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Perdió", result);
        }
        public void Caso14PPT()
        {
            var Ganador = new Ganador(new List<Jugador>());
            Jugador.Elije = " ";
            Computador.Elije = "3";
            var result = ganador.VerGanador(Jugador, Computador);
            Assert.AreEqual("Usuario no elijio opcion", result);
        }
    }
