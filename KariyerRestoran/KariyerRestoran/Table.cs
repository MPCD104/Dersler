using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerRestoran
{
    public class Table
    {
        public Table()
        {
            Order = new List<Order>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool IsActive { get; set; }

        public List<Order> Order { get; set; }

        public bool TableTaken()
        {
            return Order.Any();
        }
    }
}
