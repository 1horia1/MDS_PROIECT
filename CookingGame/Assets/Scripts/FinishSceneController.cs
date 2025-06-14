using UnityEngine;
using UnityEngine.UI;

public class FinishSceneController : MonoBehaviour
{
    public Text rezultatText; // UI Text care va afișa mesajul

    void Start()
    {
        string glazuraCeruta = Gogoasa.Instance.requestedGlazura;
        string glazuraAleasa = Gogoasa.Instance.glazuraAleasa;
        string dulceCerut = Gogoasa.Instance.requestDulce;
        string dulceAles = Gogoasa.Instance.DulceAles; 

        if (glazuraCeruta == glazuraAleasa)
        {
            if (dulceAles == dulceCerut)
            {
                rezultatText.text = "100%";
            }
            else
                rezultatText.text = "50%";
        }
        else
        {
            if (dulceAles == dulceCerut)
            {
                rezultatText.text = "50%";
            }
            else
                rezultatText.text = "0%";

           
        }
    }
}
