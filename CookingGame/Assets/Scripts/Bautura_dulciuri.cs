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
    public static Bautura_dulciuri CreateIfNeeded()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("BauturaManager");
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
                requestedSuc = "Cola";
                requestDulce = "portocale";
                break;
            case 2:
                requestedSuc = "Nestea";
                requestDulce = "ciocolata";
                break;
            case 3:
                requestedSuc = "Limonada";
                requestDulce = "ciocolata";
                break;
            default:
                requestedSuc = "Nestea";
                requestDulce = "afine";
                break;
        }

        SucAles = "";
    }
}
