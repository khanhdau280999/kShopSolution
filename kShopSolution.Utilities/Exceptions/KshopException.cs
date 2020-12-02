using System;
using System.Collections.Generic;
using System.Text;

namespace kShopSolution.Utilities.Exceptions
{
    public class KshopException : Exception
    {
        public KshopException()
        {
        }

        public KshopException(string message)
            : base(message)
        {
        }

        public KshopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
