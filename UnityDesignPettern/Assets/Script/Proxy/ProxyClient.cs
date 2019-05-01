using UnityEngine;

namespace Proxy
{
    public class ProxyClient : MonoBehaviour
    {
        ProxySubject subject = new ProxyClass();

        private void Start()
        {
            subject.DoAction();
        }
    }
}
