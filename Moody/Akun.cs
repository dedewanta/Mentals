namespace Moody
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Akun")]
    public partial class Akun
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        public int Umur { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public int? Poin { get; set; }

        [StringLength(50)]
        public string Kondisi { get; set; }
    }
}
