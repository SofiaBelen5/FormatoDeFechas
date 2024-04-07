namespace FormateoDeFecha.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                // Definir la fecha de nacimiento
                DateTime miNacimiento = new DateTime(1990, 3, 3); // Cambia esta fecha por la tuya

                // Formatear la fecha seg�n el formato deseado
                string fechaFormateada = $"Mi cumple es el {ObtenerDiaSemana(miNacimiento)} {miNacimiento.Day:00}/{ObtenerNombreMes(miNacimiento)} de {miNacimiento.Year}";

                // Verificar si la fecha formateada es correcta
                Assert.Equal("Mi cumple es el s�bado 03/marzo de 1990", fechaFormateada);
            }

            // M�todo para obtener el nombre del d�a de la semana
            private string ObtenerDiaSemana(DateTime fecha)
            {
                return fecha.ToString("dddd");
            }

            // M�todo para obtener el nombre del mes
            private string ObtenerNombreMes(DateTime fecha)
            {
                return fecha.ToString("MMMM");
            }
        }

    }
