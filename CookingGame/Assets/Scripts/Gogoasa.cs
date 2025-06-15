using UnityEngine;
using UnityEngine.UI;
public class Gogoasa : MonoBehaviour
{
    public static Gogoasa Instance;

    public int nivelCurent =0;
    public string requestedGlazura = "";
    public string glazuraAleasa = "";
    public string requestDulce = "";
    public string DulceAles = "";


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Instance = this;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public static Gogoasa CreateIfNeeded()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("GogoasaManager");
            go.AddComponent<Bautura_dulciuri>();
            DontDestroyOnLoad(go);
            // Instance se setează în Awake imediat
        }
        return Instance;
    }

    public void SetLevel(int level)
    {
        nivelCurent = level;

        // Setăm glazura cerută în funcție de nivel
        switch (level)
        {
            case 1:
                requestedGlazura = "ciocolata";
                requestDulce = "Acadea";
                break;
            case 2:
                requestedGlazura = "capsuni";
                requestDulce = "Caramel";
                break;
            case 3:
                requestedGlazura = "fistic";
                requestDulce = "cookies";
                break;
            default:
                requestedGlazura = "ciocolata";
                requestDulce = "fistic";
                break;
        }

        glazuraAleasa = "";
    }
}
