using System.Collections.Generic;
using UnityEngine;

public class GlazuraTranslate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Renderer gogoasaRenderer; // Rendererul obiectului gogoașă
    public Material ciocolataMat;
    public Material capsuniMat;
    public Material vanilieMat;

    private Dictionary<string, Material> glazuri;

    void Start()
    {
        // Inițializezi dicționarul
        glazuri = new Dictionary<string, Material>()
        {
            { "ciocolata", ciocolataMat },
            { "capsuni", capsuniMat },
            { "vanilie", vanilieMat }
        };

        // Aplici glazura aleasă (din singleton-ul Gogoasa)
        AplicaGlazura(Gogoasa.Instance.glazuraAleasa);
    }

    public void AplicaGlazura(string numeGlazura)
    {
        if (glazuri.ContainsKey(numeGlazura))
        {
            gogoasaRenderer.material = glazuri[numeGlazura];
        }
        else
        {
            Debug.LogWarning("Glazura necunoscuta: " + numeGlazura);
        }
    }
}
