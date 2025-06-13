using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // nu distruge la schimbarea scenei
        }
        else
        {
            Destroy(gameObject); // dacă exista deja, il distruge pe cel nou
        }
    }
}
