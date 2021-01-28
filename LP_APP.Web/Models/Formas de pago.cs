using System;

namespace LP_APP.Web.Models
{
    public class Formas_de_pago
    {
        public string Formas_de_pago { get; set; }
    }

    [Required]
    private string numero_targeta;

    [Required]
    private string ccv;

    [Required]
    private int edad;

    private string carrito;

    [Required]
    public string direccion_email;

    public DbSet<Owner> Formas_de_pago { get; set; }

    public string Forma_de_Pago(string targeta_cliente)
    {
        numero_targeta + ccv = targeta_cliente
        return targeta_cliente
    }
}
