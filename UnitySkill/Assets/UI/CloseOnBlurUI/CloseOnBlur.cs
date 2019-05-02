using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOnBlur : MonoBehaviour
{

    bool mouseHover;

    public void SetHover(bool hover)
    {
        mouseHover = hover;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && !mouseHover)
        {
            gameObject.SetActive(false);
        }
    }
}
