using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow3D : MonoBehaviour
{
    [SerializeField] float speed = 8.0f;
    [SerializeField] float distanceFromCamera = 5.0f;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distanceFromCamera;

        Vector3 mouseScreenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 position = Vector3.Lerp(transform.position, mouseScreenToWorld, 1.0f - Mathf.Exp(-speed * Time.deltaTime));

        transform.position = position;
    }
}
