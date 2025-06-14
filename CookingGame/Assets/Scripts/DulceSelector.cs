using UnityEngine;
using UnityEngine.UI;
public class DulceSelector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button AcadeaButton;
    public Button CaramelButton;
    public Button AltButton;

    void Start()
    {
        AcadeaButton.onClick.AddListener(() => SelecteazaDulce("Acadea"));
        CaramelButton.onClick.AddListener(() => SelecteazaDulce("Caramel"));
        AltButton.onClick.AddListener(() => SelecteazaDulce("ceva"));
    }

    void SelecteazaDulce(string nume)
    {
        Gogoasa.Instance.DulceAles = nume;
        Debug.Log("Ai ales glazura: " + nume);
    }
}
