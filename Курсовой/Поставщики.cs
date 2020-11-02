namespace Курсовой
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщики
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int НомерПоставщика { get; set; }

        [StringLength(100)]
        public string ФИОпоставщика { get; set; }

        [StringLength(50)]
        public string НаименованиеФирмы { get; set; }

        [StringLength(50)]
        public string Телефон { get; set; }

        [StringLength(50)]
        public string АдресФирмы { get; set; }

        public int? НомерТовара { get; set; }

        [Column(TypeName = "date")]
        public DateTime? СрокДоставки { get; set; }

        public virtual Продукты Продукты { get; set; }
    }
}
