using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GogoasaGameplayUI : MonoBehaviour
{
    public TMP_Text textCerință;
    public Image imagineModel;
    public Sprite spriteCiocolata;
    public Sprite spriteCapsuni;
    public Sprite spriteVanilie;

    void Start()
    {
        string ceruta = Gogoasa.Instance.requestedGlazura;
        string ceruta1 = Gogoasa.Instance.requestDulce;

        // Text
        textCerință.text = "Fă o gogoașă cu glazură de " + ceruta + " ceva dulce de tipul "+ ceruta1;

        // Imagine
        switch (ceruta)
        {
            case "ciocolata":
                imagineModel.sprite = spriteCiocolata;
                break;
            case "capsuni":
                imagineModel.sprite = spriteCapsuni;
                break;
            case "vanilie":
                imagineModel.sprite = spriteVanilie;
                break;
        }
    }
}
