using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    new Pizza(1, "Guitar Acoustic", 100.99M, Spiciness.GuitarClassic),
                    new Pizza(2, "Guitar Classic", 110.99M, Spiciness.GuitarAucostic),
                    new Pizza(3, "Ukulele", 75.99M, Spiciness.Ukulele)
                }
             });
    }
}

