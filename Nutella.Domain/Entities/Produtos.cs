using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutella.Infrastructure.Entities
{
    internal class Produtos
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }


        public required double Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
