using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clase___Laboratorio___25_05_2024.Models
{
    internal class Consola
    {
        public int ID_consola { get; set; }
        public string Nombre_consola { get; set; }
        public string Compania { get; set; }
        public DateTime Anio_lanzamiento { get; set; }
        public int Generacion { get; set; }
        public Consola() { }

        // Constructor con parámetros
        public Consola(int id, string nombre_consola, string compania, DateTime anio_lanzamiento, int generacion)
        {
            ID_consola = id;
            Nombre_consola = nombre_consola;
            Compania = compania;
            Anio_lanzamiento = anio_lanzamiento;
            Generacion = generacion;
        }



        
    }
}
