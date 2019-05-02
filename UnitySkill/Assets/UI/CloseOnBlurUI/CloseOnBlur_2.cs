using UnityEngine.EventSystems;
using UnityEngine;

public class CloseOnBlur_2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    bool mouseHover;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseHover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseHover = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && !mouseHover)
        {
            gameObject.SetActive(false);
        }
    }
}
