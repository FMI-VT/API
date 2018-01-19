using System;

namespace ImagesProcess.Exceptions
{
    class DestFileNotWritable : Exception
    {
        public DestFileNotWritable()
        {
        }

        public DestFileNotWritable(string message)
        : base(message)
        {
        }

        public DestFileNotWritable(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
