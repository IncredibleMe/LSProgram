using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSProgram
{
    class Oplitis
    {
        public static int staticAM = 1;
        public string AM { get; set; }
        public string Onoma { get; set; }
        public string Epwnimo { get; set; }
        public string Swma { get; set; }
        public bool Enoplos { get; set; }


        public Oplitis()
        {
            this.AM = staticAM++.ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(AM)}={AM}, {nameof(Onoma)}={Onoma}, {nameof(Epwnimo)}={Epwnimo}, {nameof(Swma)}={Swma}, {nameof(Enoplos)}={Enoplos}}}";
        }
    }
}
