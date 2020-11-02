namespace Курсовой
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Корзина> Корзина { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<Продукты> Продукты { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.СтоимостьЗаказа)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Заказ>()
                .Property(e => e.НаименованиеПродукта)
                .IsFixedLength();

            modelBuilder.Entity<Заказ>()
                .Property(e => e.Калории)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Заказ>()
                .HasOptional(e => e.Клиент)
                .WithRequired(e => e.Заказ);

            modelBuilder.Entity<Заказ>()
                .HasOptional(e => e.Продукты)
                .WithRequired(e => e.Заказ);

            modelBuilder.Entity<Корзина>()
                .Property(e => e.Количество)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Корзина>()
                .Property(e => e.Цена)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Корзина>()
                .Property(e => e.Оплачено)
                .IsFixedLength();

            modelBuilder.Entity<Корзина>()
                .Property(e => e.Неоплачено)
                .IsFixedLength();

            modelBuilder.Entity<Поставщики>()
                .HasOptional(e => e.Продукты)
                .WithRequired(e => e.Поставщики);

            modelBuilder.Entity<Продукты>()
                .Property(e => e.КоличествоПродукта)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Продукты>()
                .Property(e => e.СрокГодности)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Продукты>()
                .Property(e => e.СтоимостьПродукта)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Зарплата)
                .HasPrecision(19, 4);
        }
    }
}
