namespace Курсовой
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ТабельныйНомер { get; set; }

        [StringLength(100)]
        public string ФИО { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ДатаРождения { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }

        [StringLength(50)]
        public string Номер { get; set; }

        [Column(TypeName = "money")]
        public decimal? Зарплата { get; set; }
    }
}
