namespace Курсовой
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиент
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодКлиента { get; set; }

        public int? НомерЧека { get; set; }

        public virtual Заказ Заказ { get; set; }
    }
}
