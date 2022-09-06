using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete.CustomAnnotations
{
    public class DateAttribute: ValidationAttribute
    {
        public DateAttribute()
        {
        }

        public override bool IsValid(object value)
        {
            var dt = (DateTime)value;
            if (dt >= DateTime.Now.AddYears(-10) && dt <= DateTime.Now.AddYears(10))
            {
                return true;
            }

            return false;
        }
    }
}
