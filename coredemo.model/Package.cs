using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coredemo.model
{
    public class Package
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
