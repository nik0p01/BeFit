using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit3
{
    public class Clerk
    {
        public int Id { get; }
        public int[] Dependencies { get; }


        public Clerk(int id, ICollection<int> dependencies)
        {
            Id = id;
            Dependencies = dependencies.ToArray();
        }
    }
}
