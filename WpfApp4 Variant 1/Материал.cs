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
    
    public partial class Материал
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Материал()
        {
            this.ИсторияИзмКолМатериала = new HashSet<ИсторияИзмКолМатериала>();
        }
    
        public int ID_Материала { get; set; }
        public string Наименование_материала { get; set; }
        public string Тип_материала { get; set; }
        public byte[] Изображение { get; set; }
        public Nullable<decimal> Цена { get; set; }
        public Nullable<int> Количество_на_складе { get; set; }
        public Nullable<int> Минимальное_количество { get; set; }
        public Nullable<int> Количество_в_упаковке { get; set; }
        public string Единица_измерения { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ИсторияИзмКолМатериала> ИсторияИзмКолМатериала { get; set; }
    }
}
