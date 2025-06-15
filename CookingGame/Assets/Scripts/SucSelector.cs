using UnityEngine;
using UnityEngine.UI;
public class SucSelector : MonoBehaviour
{
    public Button ColaSuc;
    public Button Nestea;
    public Button  cafea;
    public Button limonada;
    public Button cocktail;
    public Button cocktail2;

    void Start()
    {
        ColaSuc.onClick.AddListener(() => SelecteazaDulce("Cola"));
        Nestea.onClick.AddListener(() => SelecteazaDulce("Nestea"));
        cafea.onClick.AddListener(() => SelecteazaDulce("Cafea"));
        limonada.onClick.AddListener(() => SelecteazaDulce("Limonada"));
        cocktail.onClick.AddListener(() => SelecteazaDulce("Cocktail"));
        cocktail2.onClick.AddListener(() => SelecteazaDulce("Cocktail2"));
    }

    void SelecteazaDulce(string nume)
    {
        Bautura_dulciuri.Instance.SucAles = nume;
        Debug.Log("Ai ales glazura: " + nume);
    }
}
