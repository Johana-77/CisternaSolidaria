using System.Collections.Generic;

namespace CisternaSolidaria
{
    // Clase estatica para compartir los datos entre todas las ventanas.
    public static class Datos
    {
        // Nombre de la estudiante (aparece en el titulo de todas las ventanas)
        public const string NOMBRE_ESTUDIANTE = "Johana Candida Granado Huarcaya";

        public const string NOMBRE_APP = "Cisterna Solidaria";

        // Capacidad de un camion cisterna en litros
        public const int CAPACIDAD_CISTERNA = 10000;

        // ESTRUCTURA DE DATOS: cola (Queue). La cisterna entrega el agua
        // en orden de llegada: el primero que pidio es el primero en recibir.
        public static Queue<Solicitud> Cola = new Queue<Solicitud>();

        // Usuario que inicio sesion
        public static string Usuario = "";

        // Zonas del sur de Cochabamba donde trabaja la cisterna
        public static string[] Zonas = { "Distrito 7", "Distrito 8", "Distrito 9", "Distrito 14", "Distrito 15" };

        // Titulo de cada ventana: siempre lleva el nombre de la estudiante
        public static string TituloVentana(string seccion)
        {
            return NOMBRE_APP + " - " + seccion + " - " + NOMBRE_ESTUDIANTE;
        }
    }
}
