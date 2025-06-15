using UnityEngine;
using UnityEngine.UI;
public class prajituricaScript : MonoBehaviour
{
    public Button capsuni;
    public Button portocale;
    public Button ciocolata;
    public Button zmeura;
    public Button roz;
    public Button caise;
    public Button afine;
    public Button merisoare;


    void Start()
    {
        capsuni.onClick.AddListener(() => SelecteazaDulce("capsuni"));
        portocale.onClick.AddListener(() => SelecteazaDulce("portocale"));
        ciocolata.onClick.AddListener(() => SelecteazaDulce("ciocolata"));
        zmeura.onClick.AddListener(() => SelecteazaDulce("zmeura"));
        roz.onClick.AddListener(() => SelecteazaDulce("roz"));
        caise.onClick.AddListener(() => SelecteazaDulce("caise"));
        afine.onClick.AddListener(() => SelecteazaDulce("afine"));
        merisoare.onClick.AddListener(() => SelecteazaDulce("merisoare"));

    }

    void SelecteazaDulce(string nume)
    {
        Bautura_dulciuri.Instance.DulceAles = nume;
        Debug.Log("Ai ales glazura: " + nume);
    }
}
