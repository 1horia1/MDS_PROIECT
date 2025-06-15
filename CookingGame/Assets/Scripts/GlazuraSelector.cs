using UnityEngine;
using UnityEngine.UI;

public class GlazuraSelector : MonoBehaviour
{
    public Button ciocolataButton;
    public Button capsuniButton;
    public Button afineButton;
    public Button fisticButton;
    public Button Ceva;


    void Start()
    {
        ciocolataButton.onClick.AddListener(() => SelecteazaGlazura("ciocolata"));
        capsuniButton.onClick.AddListener(() => SelecteazaGlazura("capsuni"));
        Ceva.onClick.AddListener(() => SelecteazaGlazura("Ceva"));
        afineButton.onClick.AddListener(() => SelecteazaGlazura("afine"));
        fisticButton.onClick.AddListener(() => SelecteazaGlazura("fistic"));
    }

    void SelecteazaGlazura(string nume)
    {
        Gogoasa.Instance.glazuraAleasa = nume;
        Debug.Log("Ai ales glazura: " + nume);
    }
}
