using UnityEngine;
using UnityEngine.UI;
public class Bautura_dulciuri : MonoBehaviour
{
    public static Bautura_dulciuri Instance;

    public int nivelCurent = 0;
    public string requestedSuc = "";
    public string SucAles = "";
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
    public static void CreateIfNeeded()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("GogoasaManager");
            go.AddComponent<Bautura_dulciuri>();
        }
    }

    public void SetLevel(int level)
    {
        nivelCurent = level;

        // Setăm glazura cerută în funcție de nivel
        switch (level)
        {
            case 1:
                requestedSuc = "cola";
                break;
            case 2:
                requestedSuc = "nestea";
                break;
            case 3:
                requestedSuc = "vanilie";
                break;
            default:
                requestedSuc = "ciocolata";
                break;
        }

        SucAles = "";
    }
}
