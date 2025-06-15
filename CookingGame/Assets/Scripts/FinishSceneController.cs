using UnityEngine;
using UnityEngine.UI;

public class FinishSceneController : MonoBehaviour
{
    public Text rezultatText; // UI Text care va afișa mesajul
    public Text rezultatText2;

    void Start()
    {
        string glazuraCeruta = Gogoasa.Instance.requestedGlazura;
        string glazuraAleasa = Gogoasa.Instance.glazuraAleasa;
        string dulceCerut = Gogoasa.Instance.requestDulce;
        string dulceAles = Gogoasa.Instance.DulceAles;
        string sucCerut = Bautura_dulciuri.Instance.requestedSuc;
        string sucAles = Bautura_dulciuri.Instance.SucAles;
        string altdulceales = Bautura_dulciuri.Instance.DulceAles;
        string altdulcecerut = Bautura_dulciuri.Instance.requestDulce;

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
        if (sucCerut == sucAles)
        {
            if (altdulceales == altdulcecerut)
            { rezultatText2.text = "100%"; }
            else { rezultatText2.text = "50%"; } 
                
        }
        else

        {
            if (altdulceales == altdulcecerut)
            { rezultatText2.text = "50%"; }
            else { rezultatText2.text = "0%"; }
        }
        
    }
}
