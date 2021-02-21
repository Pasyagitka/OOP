using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Controls
{
    class IndexAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string index = value.ToString();
                if (index.Length == 6 && index.All(char.IsDigit))
                    return true;
                else
                    this.ErrorMessage = "Индекс - шесть цифр";
            }
            return false;
        }
    }
}
