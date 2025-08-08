using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void buku()
    {
        SceneManager.LoadScene("Buku");
    }

    public void ar()
    {
         SceneManager.LoadScene("Panduan");
    }

    public void link_wisata()
    {
        SceneManager.LoadScene("Wisata");
    }

    public void link_cerita()
    {
        SceneManager.LoadScene("Buku");
    }

    public void ep1()
    {
        SceneManager.LoadScene("BukuHal01");
    }

    public void ep2()
    {
        SceneManager.LoadScene("BukuHal03");
    }

    public void ep3()
    {
        SceneManager.LoadScene("BukuHal05");
    }
}
