using System;

namespace ImagesProcess.Exceptions
{
    class AspectRatiosDoesntMatch : Exception
    {
        public AspectRatiosDoesntMatch()
        {
        }

        public AspectRatiosDoesntMatch(string message)
        : base(message)
        {
        }

        public AspectRatiosDoesntMatch(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
