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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.Pagamento = new HashSet<Pagamento>();
            this.ItemMenu = new HashSet<ItemMenu>();
        }
    
        public int Id { get; set; }
        public decimal valortotal { get; set; }
        public int ClienteId { get; set; }
        public int TrabalhadorId { get; set; }
        public int RestauranteId { get; set; }
        public int EstadoId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Trabalhador Trabalhador { get; set; }
        public virtual Restaurante Restaurante { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagamento> Pagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemMenu> ItemMenu { get; set; }
    }
}
