//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fsHost.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientService
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdService { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Services Services { get; set; }
    }
}
