namespace Airlines.Business.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActivity")]
    public partial class UserActivity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan LogInTime { get; set; }

        public TimeSpan? LogOutTime { get; set; }

        public TimeSpan? TimeSpend { get; set; }

        [StringLength(300)]
        public string Reason { get; set; }

        public Guid Confidence { get; set; }

        public virtual User User { get; set; }
    }
}
