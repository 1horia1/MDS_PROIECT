using UnityEngine;
using UnityEngine.UI;

public class GlazuraSelector : MonoBehaviour
{
    public Button ciocolataButton;
    public Button capsuniButton;
    public Button vanilieButton;

    void Start()
    {
        ciocolataButton.onClick.AddListener(() => SelecteazaGlazura("ciocolata"));
        capsuniButton.onClick.AddListener(() => SelecteazaGlazura("capsuni"));
        vanilieButton.onClick.AddListener(() => SelecteazaGlazura("vanilie"));
    }

    void SelecteazaGlazura(string nume)
    {
        Gogoasa.Instance.glazuraAleasa = nume;
        Debug.Log("Ai ales glazura: " + nume);
    }
}
