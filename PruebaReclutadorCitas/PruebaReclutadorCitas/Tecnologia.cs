//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaReclutadorCitas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tecnologia
    {
        public short IdTecnologia { get; set; }
        public Nullable<short> IdHerramienta { get; set; }
        public string NombreTecnologia { get; set; }
    
        public virtual Herramienta Herramienta { get; set; }
    }
}
