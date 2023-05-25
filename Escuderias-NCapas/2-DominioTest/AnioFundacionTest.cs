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
        public void AnioFundacion_ConAnioFueraDeRangoAdmitido_DisparaExcepcion()
        {
            //Arrange
            int anio = 2024;

            //Act & Assert
            AnioFundacion anioInstanciado = new AnioFundacion(anio);

            try
            {
                anioInstanciado.DebeSerUnValorEntre1900yHoy(anio);
            }
            catch (Exception ex)
            {
                Assert.Equal("El año de fundación no puede ser anterior a 1900 ni posterior a el año actual", ex.Message);
                return;
            }

            Assert.True(false, "No devolvió excepción esperada");
        }


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
