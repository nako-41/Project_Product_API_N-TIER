using EntitiesLayer.Concrete.CustomAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class ProductMetaData
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]

        [Required, MinLength(3, ErrorMessage = "{0} en az 3 karakter olmalıdır"),
            MaxLength(20, ErrorMessage = "{0} en fazla 20 karakter olmalıdır")]
        public string? Name { get; set; }
        [StringLength(50)]
        [Required, MinLength(2, ErrorMessage = "{0} en az 2 karakter olmalıdır"),
            MaxLength(10, ErrorMessage = "{0} en fazla 10 karakter olmalıdır")]
        public string? Code { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]\d{0,10}$", ErrorMessage = "{0} 0'dan büyük olmalı.")]
        public int Price { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]\d{0,2}$", ErrorMessage = "{0} dan büyük olmalı")]
        public int TaxRate { get; set; }

        [Required]
        public bool Availability { get; set; }
        [Date(ErrorMessage = "Girilen tarih aralığında olmalıdır + / - bugünden 10 yıl sonra")]
        [DataType(DataType.Date)]
        public DateTime AddDate { get; set; } = DateTime.Now.Date;
        [Date(ErrorMessage = "Girilen tarih aralığında olmalıdır  + / - bugünden 10 yıl sonra")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; } = DateTime.Now.Date;

    }
}
