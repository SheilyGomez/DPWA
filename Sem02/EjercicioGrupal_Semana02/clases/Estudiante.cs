using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioGrupal_Semana02.clases
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public double Nota1Materia1 { get; set; }
        public double Nota1Materia2 { get; set; }
        public double Nota2Materia1 { get; set; }
        public double Nota2Materia2 { get; set; }

        public Estudiante(string nombre, double nota1Materia1, double nota1Materia2, double nota2Materia1, double nota2Materia2)
        {
            Nombre = nombre;
            Nota1Materia1 = nota1Materia1;
            Nota1Materia2 = nota1Materia2;
            Nota2Materia1 = nota2Materia1;
            Nota2Materia2 = nota2Materia2;
        }

        public double CalcularNotaFinalMateria1()
        {
            return (Nota1Materia1 * 0.6) + (Nota2Materia1 * 0.4);
        }

        public double CalcularNotaFinalMateria2()
        {
            return (Nota1Materia2 * 0.75) + (Nota2Materia2 * 0.25);
        }

        public string GenerarCarnet()
        {
            if (string.IsNullOrEmpty(Nombre))
                return "N/A";

            var nombreParts = Nombre.Trim().Split(' ');
            if (nombreParts.Length >= 2)
            {

                // Validacion por si no vienen todos los nombres
                string primerNombre = nombreParts[0].ToLower();

                string primerApellido = nombreParts.Length >= 3 ? nombreParts[1].ToLower() : "";

                string segundoApellido = nombreParts.Length >= 3 ? nombreParts[2].ToLower() :
                                        (nombreParts.Length == 2 ? nombreParts[1].ToLower() : "");

                return $"{primerNombre}.{primerApellido}.{segundoApellido}2021_itca";
            }

            return "N/A";
        }
    }

}