using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject donutOnTheStove;
    private Camera cam;
    private bool holding = false;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                holding = true;
            }
        }

        if (Input.GetMouseButtonUp(0) && holding)
        {
            holding = false;
            if (donutOnTheStove != null)
            {
                donutOnTheStove.SetActive(true);
            }
            Destroy(gameObject);
        }

        if (holding)
        {
            transform.position = mousePos;
        }
    }

    public void StartDragging()
    {
        holding = true;
    }
}
