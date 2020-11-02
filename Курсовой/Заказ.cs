namespace Курсовой
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [Key]
        public int КодЗаказа { get; set; }

        public decimal? СтоимостьЗаказа { get; set; }

        public TimeSpan? СрокВыполнения { get; set; }

        public int? КодСотрудника { get; set; }

        [StringLength(10)]
        public string НаименованиеПродукта { get; set; }

        public decimal? Калории { get; set; }

        [StringLength(50)]
        public string Продукт { get; set; }

        public virtual Клиент Клиент { get; set; }

        public virtual Продукты Продукты { get; set; }
    }
}
