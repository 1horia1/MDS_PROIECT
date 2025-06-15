using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level1 : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10;
    public Button level11;
    public Button level12;
    public Button level13;
    public Button level14;
    public Button level15;
    public Button level16;
    public Button level17;
    public Button level18;
    public Button level19;
    public Button level20;
    private void Start()
    {
        level1.onClick.AddListener(() => IncarcaLevel1());
        level2.onClick.AddListener(() => IncarcaLevel2());
        level3.onClick.AddListener(() => IncarcaLevel3());
        level4.onClick.AddListener(() => IncarcaLevel4());
        level5.onClick.AddListener(() => IncarcaLevel4());
        level6.onClick.AddListener(() => IncarcaLevel4());
        level7.onClick.AddListener(() => IncarcaLevel4());
        level8.onClick.AddListener(() => IncarcaLevel4());
        level9.onClick.AddListener(() => IncarcaLevel4());
        level10.onClick.AddListener(() => IncarcaLevel4());
        level11.onClick.AddListener(() => IncarcaLevel4());
        level12.onClick.AddListener(() => IncarcaLevel4());
        level13.onClick.AddListener(() => IncarcaLevel4());
        level14.onClick.AddListener(() => IncarcaLevel4());
        level15.onClick.AddListener(() => IncarcaLevel4());



    }
    public void IncarcaLevel1()
    {
        Debug.Log("Apelare Level1");
        Gogoasa gogoasa = Gogoasa.CreateIfNeeded();
        Bautura_dulciuri dul = Bautura_dulciuri.CreateIfNeeded();
        gogoasa.SetLevel(1); // setează că suntem în Level 1
        dul.SetLevel(1);

        SceneManager.LoadScene("OrderPickupScene"); // încarcă scena levelului
    }
    public void IncarcaLevel2()
    {
        Debug.Log("Apelare Level2");
        Gogoasa gogoasa = Gogoasa.CreateIfNeeded();
        Bautura_dulciuri dul = Bautura_dulciuri.CreateIfNeeded();
        gogoasa.SetLevel(2); // setează că suntem în Level 1
        dul.SetLevel(2);

        SceneManager.LoadScene("OrderPickupScene"); // încarcă scena levelului
    }
    public void IncarcaLevel3()
    {
        Debug.Log("Apelare Level2");
        Gogoasa gogoasa = Gogoasa.CreateIfNeeded();
        Bautura_dulciuri dul = Bautura_dulciuri.CreateIfNeeded();
        gogoasa.SetLevel(3); // setează că suntem în Level 1
        dul.SetLevel(3);

        SceneManager.LoadScene("OrderPickupScene"); // încarcă scena levelului
    }
    public void IncarcaLevel4()
    {
        Debug.Log("Apelare Level2");
        Gogoasa gogoasa = Gogoasa.CreateIfNeeded();
        Bautura_dulciuri dul = Bautura_dulciuri.CreateIfNeeded();
        gogoasa.SetLevel(4); // setează că suntem în Level 1
        dul.SetLevel(4);

        SceneManager.LoadScene("OrderPickupScene"); // încarcă scena levelului
    }



}
