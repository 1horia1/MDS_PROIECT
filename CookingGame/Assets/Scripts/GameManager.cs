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
        string ceruta = Gogoasa.Instance?.requestedGlazura ?? "";
        string ceruta1 = Gogoasa.Instance?.requestDulce ?? "";
        string ceruta3 = Bautura_dulciuri.Instance?.requestedSuc ?? "";
        string ceruta4 = Bautura_dulciuri.Instance?.requestDulce ?? "";

        textCerință.text = "Fă o gogoașă cu glazură de " + ceruta + " ceva dulce de tipul " + ceruta1 + ", băutură: " + ceruta3 + " și dulce: " + ceruta4;

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
