using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using System.Collections;

public class SceneLoadTest
{
    [UnityTest]
    public IEnumerator Scena_Level1_SeIncarca_CuSucces()
    {
        string scena = "DayEndingScene"; 

        var asyncLoad = SceneManager.LoadSceneAsync(scena);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        Assert.AreEqual(scena, SceneManager.GetActiveScene().name);
    }
}
