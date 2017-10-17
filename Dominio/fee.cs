using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class fee:payment
    {
        private int month;
        private int year;
        public fee()
        {

        }
        public override void pay()
        {
            paid=true;
        }
    }
}
