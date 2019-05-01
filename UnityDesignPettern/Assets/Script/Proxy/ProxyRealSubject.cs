using UnityEngine;

namespace Proxy
{
    public class ProxyRealSubject : ProxySubject
    {
        public void alotofMemoryMethod()
        {
            Debug.Log("굉장히 많은 양의 메모리를 차지하는 메소드");
        }

        public void DoAction()
        {
            Debug.Log("ProxyRealSubject DoAction");
        }
    }
}
