//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MM.Biblioteca.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBFUNCIONARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBFUNCIONARIO()
        {
            this.TBEMPRESTIMO = new HashSet<TBEMPRESTIMO>();
        }
    
        public int IDFUNCIONARIO { get; set; }
        public string NOME { get; set; }
        public string TELEFONE { get; set; }
        public string CPF { get; set; }
        public string RUA { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string SENHA { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBEMPRESTIMO> TBEMPRESTIMO { get; set; }
    }
}
