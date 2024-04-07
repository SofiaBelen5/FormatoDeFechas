namespace FormateoDeFecha.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                // Definir la fecha de nacimiento
                DateTime miNacimiento = new DateTime(1990, 3, 3); // Cambia esta fecha por la tuya

                // Formatear la fecha según el formato deseado
                string fechaFormateada = $"Mi cumple es el {ObtenerDiaSemana(miNacimiento)} {miNacimiento.Day:00}/{ObtenerNombreMes(miNacimiento)} de {miNacimiento.Year}";

                // Verificar si la fecha formateada es correcta
                Assert.Equal("Mi cumple es el sábado 03/marzo de 1990", fechaFormateada);
            }

            // Método para obtener el nombre del día de la semana
            private string ObtenerDiaSemana(DateTime fecha)
            {
                return fecha.ToString("dddd");
            }

            // Método para obtener el nombre del mes
            private string ObtenerNombreMes(DateTime fecha)
            {
                return fecha.ToString("MMMM");
            }
        }

    }
