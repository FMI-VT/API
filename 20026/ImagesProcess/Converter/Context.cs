using ImagesProcess.Adapters;
using ImagesProcess.Exceptions;
using System;

namespace ImagesProcess.Converter
{
    public class Context
    {
        protected BaseConvert strategy;
        
        public void SetStrategy(BaseConvert strategy)
        {
            this.strategy = strategy;
        }

        public void Process()
        {
            try
            {
                this.strategy.Process();
            } catch (Exception e)
            {
                throw new GeneralException("Unknown error occurs", e);
            }
        }
    }
}
