namespace Курсовой
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Продукты
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int НомерПродукта { get; set; }

        [StringLength(50)]
        public string НазваниеПродукта { get; set; }

        public decimal? КоличествоПродукта { get; set; }

        public decimal? СрокГодности { get; set; }

        [Column(TypeName = "money")]
        public decimal? СтоимостьПродукта { get; set; }

        public int? КодЗаказа { get; set; }

        public virtual Заказ Заказ { get; set; }

        public virtual Поставщики Поставщики { get; set; }
    }
}
