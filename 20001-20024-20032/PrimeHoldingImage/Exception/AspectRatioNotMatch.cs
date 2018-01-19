using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exception
{
    class AspectRatioNotMatch : GenericException
    {
        public AspectRatioNotMatch()
        {

        }

        public AspectRatioNotMatch(string message) : base(message)
        {

        }

        public AspectRatioNotMatch(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}
