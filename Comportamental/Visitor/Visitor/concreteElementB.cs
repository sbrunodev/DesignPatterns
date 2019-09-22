namespace Visitor
{
    public class concreteElementB : Element
    {
        public override void Aceept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationA()
        {

        }
    }
}