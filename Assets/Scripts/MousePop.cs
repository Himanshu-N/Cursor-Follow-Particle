using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePop : MonoBehaviour
{
    [SerializeField] Camera uiCam;
    RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector3 worldPos = uiCam.ScreenToWorldPoint(mousePos);
        rectTransform.position = new Vector3(worldPos.x, worldPos.y, 2f); //2f for preventing near clipping from UI camera
    }
}
