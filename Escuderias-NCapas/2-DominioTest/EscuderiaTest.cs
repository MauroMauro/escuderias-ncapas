using _2_Dominio;
using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DominioTest
{
    public class EscuderiaTest
    {
        [Fact]
        public void Escuderia_SeInstanciaEscuderia_RetornoDeDatosCorrecto()
        {
            //Arrange
            Escuderia redBull = new Escuderia(
            Guid.NewGuid(),
            "Red Bull",
            "Austríaca",
            2005,
            "Honda"
            );

            String infoEsperada =  "La escudería Red Bull, de nacionalidad Austríaca fué fundada en 2005, utiliza motores Honda";


            //Act

            //Assert
            Assert.Equal(redBull.obtenerDatos(), infoEsperada);
        }


        [Fact]
        public void Escuderia_SeIngresanDatosInvalidos_NoRetornaDatos()
        {
            //Arrange
            
            //Act

            //Assert
            Assert.Throws<System.Exception>(() => new Escuderia(
            Guid.NewGuid(),
            "Red Bull",
            "Austríaca",
            2025,
            "Honda"
            ));

        }


    }
}
