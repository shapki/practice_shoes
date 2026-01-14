namespace shoes.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        [Required]
        [StringLength(150)]
        public string Login { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        // { PKGH
        public bool IsAdmin()
        {
            return this.Role == "Администратор";
        }

        public bool IsManager()
        {
            return this.Role == "Менеджер";
        }

        public bool IsAuthUser()
        {
            return this.Role == "Авторизированный клиент";
        }
        // } PKGH
    }
}
