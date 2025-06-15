using UnityEngine;
using UnityEngine.UI;
public class DulceSelector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button AcadeaButton;
    public Button CaramelButton;
    public Button Ciocolata;
    public Button cookies;
    public Button bomboana;
    public Button fistic;
    public Button portocala;
    public Button zmereu;
    public Button bombonica1;

    void Start()
    {
        AcadeaButton.onClick.AddListener(() => SelecteazaDulce("Acadea"));
        CaramelButton.onClick.AddListener(() => SelecteazaDulce("Caramel"));
        Ciocolata.onClick.AddListener(() => SelecteazaDulce("Ciocolata"));
        cookies.onClick.AddListener(() => SelecteazaDulce("cookies"));
        bomboana.onClick.AddListener(() => SelecteazaDulce("bomboana"));
        fistic.onClick.AddListener(() => SelecteazaDulce("fistic"));
        portocala.onClick.AddListener(() => SelecteazaDulce("portocala"));
        zmereu.onClick.AddListener(() => SelecteazaDulce("zmeura"));
        bombonica1.onClick.AddListener(() => SelecteazaDulce("bombonica1"));

    }

    void SelecteazaDulce(string nume)
    {
        Gogoasa.Instance.DulceAles = nume;
        Debug.Log("Ai ales glazura: " + nume);
    }
}
