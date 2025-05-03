using UnityEngine;

public class Walk : MonoBehaviour
{
    public float viteza = 200f;
    private float pozitieFinalaX;
    private bool sAoprit = false;

    void Start()
    {
        Vector3 worldPoz = Camera.main.ViewportToWorldPoint(new Vector3(0.25f, 0.5f, Mathf.Abs(Camera.main.transform.position.z)));
        pozitieFinalaX = worldPoz.x;
    }

    void Update()
    {
        if (!sAoprit && transform.position.x > pozitieFinalaX)
        {
            float pas = viteza * Time.deltaTime;
            float distanta = transform.position.x - pozitieFinalaX;

            if (pas > distanta)
                pas = distanta;

            transform.Translate(Vector3.left * pas);
        }
        else if (!sAoprit)
        {
            sAoprit = true;

            transform.rotation = Quaternion.identity;

            foreach (Transform child in transform)
            {
                child.localRotation = Quaternion.identity;
            }

        }
    }
}
