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
    public partial class Hole
    {
        public Hole()
        {
            this.EachHoles = new HashSet<EachHole>();
        }
    
        public long ID_holes { get; set; }
        public long ID_survey { get; set; }
        public int Num_snapshot { get; set; }
        public int Holes_amount { get; set; }
        public double Min_hole_size { get; set; }
        public double Max_hole_size { get; set; }
        public double Mean_hole_size { get; set; }
    
        public virtual ICollection<EachHole> EachHoles { get; set; }
        public virtual Survey Survey { get; set; }
    }
}
