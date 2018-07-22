namespace Udemy.EntityFrameworkRepositoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personeller")]
    public partial class Personeller
    {
        [Key]
        public Guid PersonelID { get; set; }

        [StringLength(30)]
        public string Isim { get; set; }

        [StringLength(30)]
        public string Soyisim { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }
    }
}
