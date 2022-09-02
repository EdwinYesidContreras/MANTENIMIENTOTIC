using System;
using Dominio;

namespace Dominio
{
    public class Usuario
    {
        public int UsuarioId {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string TipoDeUsuario {get; set;}
        public string Contrasena {get; set;}
        public int Identificacion {get; set;}
    }
}
