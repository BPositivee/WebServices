//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADMINISTRADOR
    {
        public decimal ADMINISTRADOR_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public decimal ROLES_ROLES_ID { get; set; }
    
        public virtual ROLES ROLES { get; set; }
    }
}
