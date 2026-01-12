namespace shoes.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Sku { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string UnitOfMeasurement { get; set; }

        public double Price { get; set; }

        public int SupplierId { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(150)]
        public string Category { get; set; }

        public double Discount { get; set; }

        public int Stock { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Photo { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
