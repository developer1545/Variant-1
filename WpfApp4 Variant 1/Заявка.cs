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
    
    public partial class Заявка
    {
        public int ID_Заявки { get; set; }
        public int ID_Агента { get; set; }
        public int ID_Менеджера { get; set; }
        public string Дата_создания_заявки { get; set; }
        public string Согласованность { get; set; }
        public string Список_продукции { get; set; }
        public string Время_производства { get; set; }
    
        public virtual Агенты Агенты { get; set; }
        public virtual Менеджеры Менеджеры { get; set; }
    }
}
