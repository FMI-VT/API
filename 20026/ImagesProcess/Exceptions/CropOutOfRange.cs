using System;

namespace ImagesProcess.Exceptions
{
    public class CropOutOfRange : Exception
    {
        public CropOutOfRange()
        {
        }

        public CropOutOfRange(string message)
        : base(message)
        {
        }

        public CropOutOfRange(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
