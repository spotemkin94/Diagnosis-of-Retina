//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiagnosisOfRetinal
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Patient
    {
        public Patient()
        {
            this.Surveys = new HashSet<Survey>();
        }
    
        public long ID { get; set; }
        public long Card_number { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Adres { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public Nullable<decimal> Phone { get; set; }
    
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}