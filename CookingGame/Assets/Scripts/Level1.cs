using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public void IncarcaLevel1()
    {
        Gogoasa.CreateIfNeeded();
        Gogoasa.Instance.SetLevel(1); // setează că suntem în Level 1
        SceneManager.LoadScene("OrderPickupScene"); // încarcă scena levelului
    }
}
