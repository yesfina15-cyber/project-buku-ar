using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Kameraar : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Panduan");
    }

    public void exit()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void satu9()
    {
         Application.OpenURL("https://web.webar-studio.com/v2/e9ec998a6d");
    }

    public void sepuluh16()
    {
         Application.OpenURL("https://projects.web-ar.studio/v2/db97a5cae8");
    }

    public void satu718()
    {
         Application.OpenURL("https://projects.web-ar.studio/v2/436135246c");
    }
}
