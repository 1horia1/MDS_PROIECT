using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject donutOnTheStove_left;
    public GameObject donutOnTheStove_right;
    public PannelScript script;
    private Camera cam;
    private bool holding = false;
    
    // zona pt gogoasa din stanga
    private static Vector3 center_left = new(-0.58f, -0.64f, -0.6882319f);
    private static Vector3 size_left = new(2, 2, 2);
    private static Bounds zone_donutleft = new(center_left, size_left);

    // zona pt gogoasa din dreapta
    private static Vector3 center_right = new(2.1f, -0.64f, -0.6882319f);
    private static Vector3 size_right = new(2, 2, 2);
    private static Bounds zone_donutright = new(center_right, size_right);


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
            if (donutOnTheStove_left != null && zone_donutleft.Contains(mousePos))
            {
                donutOnTheStove_left.SetActive(true);
                Debug.Log("Donut on left stove");
            }
            else if (donutOnTheStove_right != null && zone_donutright.Contains(mousePos))
            {
                donutOnTheStove_right.SetActive(true);
                Debug.Log("Donut on right stove");
            }
            else
            {
                script.PannelAnimator();
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
