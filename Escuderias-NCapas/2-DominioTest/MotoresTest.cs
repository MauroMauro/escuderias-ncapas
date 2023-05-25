using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DominioTest
{
    public class MotoresTest
    {
        [Fact]
        public void Motores_ConMasDeCuatroCaracteres_InstanciaMotores()
        {
            //Arrange
            String nombreMotor = "Mercedes";

            //Act
            Motores motorInstanciado = new Motores(nombreMotor);

            //Assert
            Assert.Equal(motorInstanciado.Valor(), nombreMotor);
        }
    }
    
}
