using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Dto
{
    public class ThreeDto
    {
        public int ID;

        public string entityName;

        public string Entity_Name;

        public int Age { get; set; }

        private decimal Height = 1;

        public string Sex { get; private set; }

        public decimal Weight;

        public decimal PrefixHandPostfix { get; set; }

        public List<ThreeDto> Children { get; set; }
    }
}
