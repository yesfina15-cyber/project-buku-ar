using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Wisata : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void buku()
    {
        SceneManager.LoadScene("Buku");
    }

    public void wisata()
    {
        SceneManager.LoadScene("Wisata");
    }

    public void ar()
    {
        Application.OpenURL("Panduan");
    }

    public void selanjutnya()
    {
        SceneManager.LoadScene("Wisata2");
    }

    public void kembali()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void kembali2()
    {
        SceneManager.LoadScene("Wisata");
    }

    public void lokasi()
    {
        SceneManager.LoadScene("Lokasi");
    }

    public void batu1_3()
    {
        SceneManager.LoadScene("batu1");
    }

    public void batu4_6()
    {
        SceneManager.LoadScene("batu2");
    }

    public void batu7_9()
    {   
        SceneManager.LoadScene("batu3");
    }

    public void batu10_12()
    {
        SceneManager.LoadScene("batu4");
    }
}
