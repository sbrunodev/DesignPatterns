using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} Handled request {1}", this.GetType().Name, request);
            }
            else if (sucessor != null)
            {
                sucessor.HandlerRequest(request);
            }
        }
    }
}
