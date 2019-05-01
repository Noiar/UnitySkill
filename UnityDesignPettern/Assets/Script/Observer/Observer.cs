using UnityEngine;

namespace Observer
{
    public class Observer : MonoBehaviour
    {
        //Subject의 상태 변화 관찰

        private void OnEnable()
        {
            Debug.Log("Subject의 이벤트에 click()함수 추가");
            Subject.Instance.clickevent += this.click;
        }

        private void OnDisable()
        {
            Debug.Log("Subject의 이벤트에 click()함수 제거");
            Subject.Instance.clickevent -= this.click;
        }

        public void click()
        {
            Debug.Log("클릭 함수");
        }
    }
}
