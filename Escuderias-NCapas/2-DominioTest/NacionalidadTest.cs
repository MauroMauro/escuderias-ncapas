using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DominioTest
{
    public class NacionalidadTest
    {
        [Fact]
        public void Nacionalidad_ConMasDeCuatroCaracteres_InstanciaNacionalidad()
        {
            //Arrange
            String nombreNacionalidad = "Británica";

            //Act
            Nacionalidad NacionalidadInstanciada = new Nacionalidad(nombreNacionalidad);

            //Assert
            Assert.Equal(NacionalidadInstanciada.Valor(), nombreNacionalidad);
        }
    }
}
