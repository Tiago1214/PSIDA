//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace da_projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Morada
    {
        public int Id { get; set; }
        public string pais { get; set; }
        public string rua { get; set; }
        public string cidade { get; set; }
        public string codpostal { get; set; }

        public override string ToString()
        {
            return this.rua + "(" + this.Id + "), " + this.cidade + "(" + this.codpostal + ")" + ", " + this.pais;
        }
    }

    
}
