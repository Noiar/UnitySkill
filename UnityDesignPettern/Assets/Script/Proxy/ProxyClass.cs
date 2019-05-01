namespace Proxy
{
    public class ProxyClass : ProxySubject
    {
        private ProxySubject subject;

        public void DoAction()
        {
            if (this.subject == null)
                this.subject = new ProxyRealSubject();

            this.subject.DoAction();
        }
    }
}
