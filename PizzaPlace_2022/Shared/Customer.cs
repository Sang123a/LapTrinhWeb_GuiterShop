using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace_2022.Shared {
    public class Customer {
        public int Id { get; set; }
        [Required(ErrorMessage = "Hãy điền họ tên")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Hãy điền địa chỉ nhà")]
        public string Street { get; set; } = default!;
        [Required(ErrorMessage = "Hãy điền thành phố")]
        public string City { get; set; } = default!;
    }
}
