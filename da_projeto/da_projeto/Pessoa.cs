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

    public partial class Pessoa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int telemovel { get; set; }

        public virtual Morada Morada { get; set; }
    }
}
