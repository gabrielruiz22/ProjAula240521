//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjAula240521
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CLIENTE()
        {
            this.TB_SERVICO = new HashSet<TB_SERVICO>();
        }
    
        public int ID { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SERVICO> TB_SERVICO { get; set; }
    }
}
