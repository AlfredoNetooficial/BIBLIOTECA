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
    
    public partial class TBITEMEMPRESTIMO
    {
        public int IDITEMEMPRESTIMO { get; set; }
        public Nullable<int> IDEMPRESTIMO { get; set; }
        public Nullable<int> IDLIVRO { get; set; }
        public Nullable<System.DateTime> DEVOLUCAO { get; set; }
        public Nullable<int> IDPERIODICO { get; set; }
    
        public virtual TBEMPRESTIMO TBEMPRESTIMO { get; set; }
        public virtual TBLIVRO TBLIVRO { get; set; }
        public virtual TBPERIODICO TBPERIODICO { get; set; }
    }
}
