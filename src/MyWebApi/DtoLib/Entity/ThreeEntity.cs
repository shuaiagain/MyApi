using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Entity
{
    public class ThreeEntity
    {
        public int Id;

        public string EntityName;

        public int Age { get; set; }

        public decimal Height { get; set; }

        private string sex;
        public string Sex
        {
            get { return sex; }
            private set { sex = value; }
        }

        public decimal Weight;

        public decimal Hand { get; set; }
    }

}
