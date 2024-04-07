using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormateoDeFecha
{
    public class Fecha
    {
        // Método estático que acepta una fecha de nacimiento y devuelve el formato de fecha deseado
        public static string ObtenerFormatoCumple(DateTime fechaNacimiento)
        {
            // Construir la cadena de formato utilizando la fecha de nacimiento proporcionada
            string fechaFormateada = $"Mi cumple es el {ObtenerDiaSemana(fechaNacimiento)} {fechaNacimiento.Day:00}/{ObtenerNombreMes(fechaNacimiento)} de {fechaNacimiento.Year}";

            // Devolver la cadena de formato
            return fechaFormateada;
        }
        // Método auxiliar privado que devuelve el nombre del día de la semana
        private static string ObtenerDiaSemana(DateTime fecha)
        {
            // Convertir la fecha en el nombre del día de la semana y devolverlo
            return fecha.ToString("dddd");
        }
        // Método auxiliar privado que devuelve el nombre del mes
        private static string ObtenerNombreMes(DateTime fecha)
        {
            // Convertir la fecha en el nombre del mes y devolverlo
            return fecha.ToString("MMMM");
        }
    }

}
