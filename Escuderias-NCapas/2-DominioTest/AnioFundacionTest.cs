using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DominioTest
{
    public class AnioFundacionTest
    {
        [Fact]
        public void AnioFundacion_ConAnioDentroDelRango_InstanciaAnioFundacion()
        {
            //Arrange
            int anio = 1968;

            //Act
            AnioFundacion anioInstanciado = new AnioFundacion(anio);

           
            //Assert
            Assert.Equal(anioInstanciado.Valor(), anio);
        }
    }
}
