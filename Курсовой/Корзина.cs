namespace Курсовой
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Корзина
    {
        [Key]
        [StringLength(50)]
        public string НазваниеБлюда { get; set; }

        public decimal? Количество { get; set; }

        [Column(TypeName = "money")]
        public decimal? Цена { get; set; }

        [StringLength(10)]
        public string Оплачено { get; set; }

        [StringLength(10)]
        public string Неоплачено { get; set; }
    }
}
