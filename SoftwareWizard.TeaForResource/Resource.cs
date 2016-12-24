using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareWizard.TeaForResource
{
    public class Resource
    {
        public string Name { get; set; }

        public BlockingCollection<ResourceElement> ResourceElements { get; set; }
    }
}
