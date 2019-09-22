namespace Visitor
{
    public class concreteElementA : Element
    {
        public override void Aceept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {

        }
    }
}