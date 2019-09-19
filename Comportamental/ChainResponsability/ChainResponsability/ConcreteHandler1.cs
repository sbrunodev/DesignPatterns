using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Console.WriteLine("{0} Handled request {1}", this.GetType().Name, request);
            }else if(sucessor != null)
            {
                sucessor.HandlerRequest(request);
            }
        }
    }
}
