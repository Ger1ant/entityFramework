namespace Udemy.EntityFrameworkRepositoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SistemKullanici")]
    public partial class SistemKullanici
    {
        [Key]
        public Guid KullaniciId { get; set; }

        [StringLength(30)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(20)]
        public string Sifre { get; set; }
    }
}
