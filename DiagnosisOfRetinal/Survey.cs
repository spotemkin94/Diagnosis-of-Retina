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
    using ProtoBuf;
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Survey
    {
        public Survey()
        {
            this.Area_of_folds = new HashSet<Area_of_folds>();
            this.Corner_variability = new HashSet<Corner_variability>();
            this.Correlations = new HashSet<Correlation>();
            this.Critical_points = new HashSet<Critical_points>();
            this.Foldings = new HashSet<Folding>();
            this.Fourier_params = new HashSet<Fourier_params>();
            this.Foveas = new HashSet<Fovea>();
            this.Holes = new HashSet<Hole>();
            this.Snapshots = new HashSet<Snapshot>();
        }
        
        public long ID { get; set; }
        public long ID_patient { get; set; }
        public long ID_doctor { get; set; }
        public System.DateTime Date_survey { get; set; }
        public string Location { get; set; }
        public Nullable<double> Global_correlation { get; set; }
        public Nullable<int> Global_critical_points { get; set; }
        public Nullable<double> Global_max_amplitude { get; set; }
        public Nullable<double> Global_min_amplitude { get; set; }
        public Nullable<double> Global_mean_amplitude { get; set; }
        public Nullable<int> Global_n { get; set; }
        public Nullable<double> Global_angles { get; set; }
        public Nullable<double> Global_fovea_length { get; set; }
        public Nullable<double> Global_fovea_depth_top { get; set; }
        public Nullable<double> Global_fovea_depth_bot { get; set; }
        public Nullable<double> Global_fovea_coef_symmetry { get; set; }
        public Nullable<double> Global_fovea_coef_normality { get; set; }
        public Nullable<double> Global_sum_variability { get; set; }
        public Nullable<double> Global_median_variability { get; set; }
    
        public virtual ICollection<Area_of_folds> Area_of_folds { get; set; }
        public virtual ICollection<Corner_variability> Corner_variability { get; set; }
        public virtual ICollection<Correlation> Correlations { get; set; }
        public virtual ICollection<Critical_points> Critical_points { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Folding> Foldings { get; set; }
        public virtual ICollection<Fourier_params> Fourier_params { get; set; }
        public virtual ICollection<Fovea> Foveas { get; set; }
        public virtual ICollection<Hole> Holes { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Snapshot> Snapshots { get; set; }
    }
}