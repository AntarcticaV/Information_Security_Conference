//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Information_Security_Conference.Entity
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Information_Security_Conference.FindImage;


    public partial class Action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Action()
        {
            this.Event_actions = new HashSet<Event_actions>();
        }
    
        public int IDAction { get; set; }
        public int IDEvent { get; set; }
        public string Action1 { get; set; }
        public System.DateTime Date { get; set; }
        public int Days { get; set; }
        public int City { get; set; }
        public string Logo { get; set; }
        public int IDOrganizer { get; set; }
        public Nullable<int> Winner { get; set; }
    
        public virtual Cities Cities { get; set; }
        public virtual Event Event { get; set; }
        public virtual Organizatory Organizatory { get; set; }
        public virtual Uchastniki Uchastniki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event_actions> Event_actions { get; set; }

        public string Path {
            get
            {
                var dir = Directory.GetFiles(
                    "C:\\Учеба\\Разработка програмных модулей\\Вариант 1\\Сессия 1\\Мероприятия_import", "*.*g");
                var search = new SearchFile();
                return search.SearchPath(dir, Logo);
            } }
    }
}
