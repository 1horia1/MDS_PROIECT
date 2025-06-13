using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickAndReplace : MonoBehaviour
{
    private string scenaNoua = "Kitchen2Scene"; // numele scenei care contine noul obiect
    private string numeObiectNou = "Canvas/Donuts/Clean Donut"; // path relativ in ierarhie

    private Color culoareOriginala;

    void OnMouseDown()
    {
        // Salvăm culoarea sprite-ului curent înainte de distrugere
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
            culoareOriginala = sr.color;

        // Ascultăm când scena nouă este încărcată
        SceneManager.sceneLoaded += OnSceneLoaded;

        // Încărcăm scena aditiv
        SceneManager.LoadScene(scenaNoua, LoadSceneMode.Additive);

        // Distrugem obiectul curent
        Destroy(gameObject);
    }

    void OnSceneLoaded(Scene scena, LoadSceneMode mod)
    {
        if (scena.name == scenaNoua)
        {
            GameObject obj = GameObject.Find(numeObiectNou);
            if (obj != null)
            {
                obj.SetActive(true);

                // Copiem culoarea
                SpriteRenderer newSr = obj.GetComponent<SpriteRenderer>();
                if (newSr != null)
                    newSr.color = culoareOriginala;
            }

            // Dezabonăm metoda, altfel se va apela la fiecare scenă viitoare
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
}
