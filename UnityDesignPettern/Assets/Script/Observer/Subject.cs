using UnityEngine;

namespace Observer
{
    public class Subject : MonoBehaviour
    {
        #region SingletonPettern
        private static Subject instance;
        public static Subject Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType(typeof(Subject)) as Subject;
                }
                return instance;
            }
        }
        #endregion

        #region ObserverPettern

        //Observer에게 상태 변화 전달
        public delegate void EventListener();

        /*이벤트는 클래스내에 특정한 일(event)이 있어났음을 외부의 이벤트 가입자(subscriber) 들에게 알려주는 기능을 한다.
        C#에서 이벤트는 event라는 키워드를 사용하여 표시하며, 클래스 내에서 일종의 필드처럼 정의된다.

        이벤트에 가입하는 외부 가입자 측에서는 이벤트가 발생했을 때 어떤 명령들을 실행할 지를 지정해 주는데, 
        이를 이벤트 핸들러라 한다.이벤트에 가입하기 위해서는 += 연산자를 사용하여 이벤트핸들러를 이벤트에 추가한다.
        반대로 이벤트핸들러를 삭제하기 위해서는 -= 연산자를 사용한다. 하나의 이벤트에는 여러 개의 이벤트핸들러들을 추가할 수 있으며, 
        이벤트가 발생되면 추가된 이벤트핸들러들을 모두 차례로 호출한다.*/

        public event EventListener clickevent;

        public void Click()
        {
            this.clickevent?.Invoke();
            //Invoke() 컨트롤의 내부 창 핸들이 있는 스레드에서 대리자를 실행합니다.
            //멤버 액세스(?.) 또는 인덱스(?[]) 작업을 수행하기 전에 Null에서 왼쪽 피연산자의 값을 테스트합니다. 왼쪽 피연산자가 null로 계산하는 경우 null을 반환합니다.
        }

        #endregion
    }
}
