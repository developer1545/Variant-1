//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Продукция
    {
        public int ID_Продукции { get; set; }
        public int ID_Материала { get; set; }
        public int ID_Сотрудника { get; set; }
        public Nullable<int> Артикул { get; set; }
        public string Наименование { get; set; }
        public string Тип_продукта { get; set; }
        public string Описание { get; set; }
        public byte[] Изображение { get; set; }
        public Nullable<decimal> Макксимальная_стоимость_для_агента { get; set; }
        public Nullable<int> Размер_упаковки { get; set; }
        public Nullable<int> Вес_без_упаковки { get; set; }
        public byte[] Сертификат_качества_в_виде_сканированного_файла { get; set; }
        public Nullable<int> Номер_стандарта { get; set; }
        public Nullable<System.DateTime> Время_производства { get; set; }
        public Nullable<decimal> Себестоимость_производства { get; set; }
        public Nullable<int> Номер_цеха { get; set; }
        public Nullable<int> Необходимое_количество_человек_при_производстве { get; set; }
        public Nullable<int> Необходимые_материалы_для_производства { get; set; }
    
        public virtual Материал Материал { get; set; }
        public virtual Сотрудники Сотрудники { get; set; }
    }
}
