using System;
using System.Collections.Generic;
using System.Text;

namespace BD_Escuela.Clases
{
    internal class Sesion
    {
        public static int UsrId { get; set; }
        public static string Usuario { get; set; }
        public static string Rol { get; set; }
        public static string Permisos { get; set; }

        public static string Token {  get; set; }


        // Métodos para verificar permisos fácilmente
        public static bool PuedeConsultar => !string.IsNullOrEmpty(Permisos);
        public static bool PuedeInsertar => Permisos == "0000001F";
        public static bool PuedeModificar => Permisos == "0000001F" || Permisos == "0000001D";
        public static bool PuedeEliminar => Permisos == "0000001F";

        public static void Limpiar()
        {
            UsrId = 0;
            Usuario = string.Empty;
            Rol = string.Empty;
            Permisos = string.Empty;
        }
    }
}
