﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4_Variant_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelEntities : DbContext
    {
        private static ModelEntities _DContext;
        public ModelEntities()
            : base("name=ModelEntities")
        {
        }
        public static ModelEntities GetContext()
        {
            if (_DContext == null)
            {
                _DContext = new ModelEntities();
            }
            return _DContext;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Импорт_материала> Импорт_материала { get; set; }
        public virtual DbSet<ИсторияИзмКолМатериала> ИсторияИзмКолМатериала { get; set; }
        public virtual DbSet<Материал> Материал { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
    }
}
