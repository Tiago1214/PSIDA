
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

    public partial class Estado
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estado()
        {

            this.Pedidoes = new HashSet<Pedido>();

        }


        public int Id { get; set; }

        public string estado { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Pedido> Pedidoes { get; set; }

        public override string ToString()
        {
            return this.estado;
        }

    }

}
