using ImagesProcess.Adapters;
using System;
using ImagesProcess.Exceptions;


namespace ImagesProcess.Resize
{
    class Context
    {
        protected BaseResize strategy;

        public void SetStrategy(BaseResize strategy)
        {
            this.strategy = strategy;
        }

        public void Process()
        {
                        
                this.strategy.Process();
            
        }
    }
}
