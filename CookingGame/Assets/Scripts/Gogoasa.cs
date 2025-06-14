using UnityEngine;
using UnityEngine.UI;
public class Gogoasa : MonoBehaviour
{
    public static Gogoasa Instance;

    public int nivelCurent = 0;
    public string requestedGlazura = "";
    public string glazuraAleasa = "";
    public string requestDulce = "";
    public string DulceAles = "";


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public static void CreateIfNeeded()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("GogoasaManager");
            go.AddComponent<Gogoasa>();
        }
    }

    public void SetLevel(int level)
    {
        nivelCurent = level;

        // Setăm glazura cerută în funcție de nivel
        switch (level)
        {
            case 1:
                requestedGlazura = "ciocolata";
                break;
            case 2:
                requestedGlazura = "capsuni";
                break;
            case 3:
                requestedGlazura = "vanilie";
                break;
            default:
                requestedGlazura = "ciocolata";
                break;
        }

        glazuraAleasa = "";
    }
}
