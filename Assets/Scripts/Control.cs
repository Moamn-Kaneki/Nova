using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void EgyptScene()
    {
        SceneManager.LoadScene("Egypt");
    }
    public void TreeTempSimScene()
    {
        SceneManager.LoadScene("TreeTempSim");
    }
    public void ClimateVideo()
    {
        SceneManager.LoadScene("ClimateChange");
    }
}