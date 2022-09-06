using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    [MetadataType(typeof(ProductMetaData))]
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int Price { get; set; }
        public int TaxRate { get; set; }
        public bool Availability { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now.Date;
        public DateTime UpdateDate { get; set; } = DateTime.Now.Date;


    }
}
