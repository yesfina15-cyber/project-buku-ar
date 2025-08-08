using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Panduan : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void start()
    {
        SceneManager.LoadScene("Kameraar");
    }

    public void download()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1oFgoSYlkzHRDT2W1mUZF73_2GfKC8ken?usp=sharing");
    }
}
