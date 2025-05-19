
using UnityEngine;
using UnityEngine.UI;

public class BarLoading : MonoBehaviour
{
    public GameObject leftDonut;
    public GameObject rightDonut;

    public Image bar1Background;
    public Image bar1;
    public Image bar2Background;
    public Image bar2;

    private SpriteRenderer leftRenderer;
    private SpriteRenderer rightRenderer;

    private float timeRemainingBar1 = -1f;
    private float timeRemainingBar2 = -1f;
    private readonly float maxTime = 15f;

    void Start()
    {
        leftRenderer = leftDonut.GetComponent<SpriteRenderer>();
        rightRenderer = rightDonut.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (leftDonut.activeInHierarchy && timeRemainingBar1 < 0f)
        {
            bar1Background.enabled = true;
            bar1.enabled = true;
            timeRemainingBar1 = 0f;
            bar1.fillAmount = 0f;
        }

        if (rightDonut.activeInHierarchy && timeRemainingBar2 < 0f)
        {
            bar2Background.enabled = true;
            bar2.enabled = true;
            timeRemainingBar2 = 0f;
            bar2.fillAmount = 0f;
        }

        if (timeRemainingBar1 >= 0f && timeRemainingBar1 < maxTime)
        {
            timeRemainingBar1 += Time.deltaTime;
            bar1.fillAmount = timeRemainingBar1 / maxTime;

            float t = timeRemainingBar1 / maxTime;
            leftRenderer.color = Color.Lerp(Color.white, new Color(0.5f, 0.2f, 0.1f), t);
        }

        if (timeRemainingBar2 >= 0f && timeRemainingBar2 < maxTime)
        {
            timeRemainingBar2 += Time.deltaTime;
            bar2.fillAmount = timeRemainingBar2 / maxTime;

            float t = timeRemainingBar2 / maxTime;
            rightRenderer.color = Color.Lerp(Color.white, new Color(0.5f, 0.2f, 0.1f), t); 
        }
    }
}
