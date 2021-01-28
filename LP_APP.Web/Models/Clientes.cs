using System;

namespace LP_APP.Web.Models
{
    public class Clientes
    {
        public string Clientes { get; set; }
    }

    [Required]
    public string Nombre;

    [Required]
    public string Apellido;

    [Required]
    public int edad;

    public string carrito;

    [Required]
    public string user;

    [Required]
    public string direccion_email;

    public DbSet<Owner> Clientes { get; set; }
}

