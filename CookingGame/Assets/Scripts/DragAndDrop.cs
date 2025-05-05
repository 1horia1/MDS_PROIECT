using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Camera cam;
    bool holding;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (holding)
        {
            Vector2 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = pos;
        }
    }

    void OnMouseDown()
    {
        holding = true;
    }

    void OnMouseUp()
    {
        holding = false;
    }

    public void StartDragging()
    {
        holding = true;
    }
}
