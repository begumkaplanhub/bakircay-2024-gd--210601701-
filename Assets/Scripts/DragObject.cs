using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 offset;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnMouseDown()
    {
        offset = transform.position - GetWorldPosition(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        transform.position = GetWorldPosition(Input.mousePosition) + offset;
    }

    private Vector3 GetWorldPosition(Vector3 screenPosition)
    {
        screenPosition.z = mainCamera.WorldToScreenPoint(transform.position).z;
        return mainCamera.ScreenToWorldPoint(screenPosition);
    }
}
