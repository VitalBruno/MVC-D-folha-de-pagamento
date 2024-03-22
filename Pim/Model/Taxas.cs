using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Model
{
    internal class Taxas
    {
        public bool Ferias;
        public double INSS { get; set; }
        public double FGTS { get; set; }
        public double VA { get; set; }
        public double VR { get; set; }
        public double VT { get; set; }

    }
}