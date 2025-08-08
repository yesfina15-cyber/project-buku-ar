using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Buku : MonoBehaviour
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

    public void unduh()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1JQ-uMPk7BsE7LMoPFPXhhzR7Lso6qWid?usp=sharing");
    }

    public void kembali()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void kembalibuku2()
    {
        SceneManager.LoadScene("Buku");
    }

    public void selanjutnya()
    {
        SceneManager.LoadScene("Buku2");
    }

    public void ep1() { SceneManager.LoadScene("BukuHal01"); }
    public void ep2() { SceneManager.LoadScene("BukuHal03"); }
    public void ep3() { SceneManager.LoadScene("BukuHal05"); }
    public void ep4() { SceneManager.LoadScene("BukuHal08"); }
    public void ep5() { SceneManager.LoadScene("BukuHal11"); }
    public void ep6() { SceneManager.LoadScene("BukuHal14"); }
    public void ep7() { SceneManager.LoadScene("BukuHal16"); }

    public void hal1kembali() { SceneManager.LoadScene("Buku"); }
    public void hal1selanjutnya() { SceneManager.LoadScene("BukuHal02"); }
    public void hal2kembali() { SceneManager.LoadScene("BukuHal01"); }
    public void hal2selanjutnya() { SceneManager.LoadScene("BukuHal03"); }
    public void hal3kembali() { SceneManager.LoadScene("BukuHal02"); }
    public void hal3selanjutnya() { SceneManager.LoadScene("BukuHal04"); }
    public void hal4kembali() { SceneManager.LoadScene("BukuHal03"); }
    public void hal4selanjutnya() { SceneManager.LoadScene("BukuHal05"); }
    public void hal5kembali() { SceneManager.LoadScene("BukuHal04"); }
    public void hal5selanjutnya() { SceneManager.LoadScene("BukuHal06"); }
    public void hal6kembali() { SceneManager.LoadScene("BukuHal05"); }
    public void hal6selanjutnya() { SceneManager.LoadScene("BukuHal07"); }
    public void hal7kembali() { SceneManager.LoadScene("BukuHal06"); }
    public void hal7selanjutnya() { SceneManager.LoadScene("BukuHal08"); }
    public void hal8kembali() { SceneManager.LoadScene("BukuHal07"); }
    public void hal8selanjutnya() { SceneManager.LoadScene("BukuHal09"); }
    public void hal9kembali() { SceneManager.LoadScene("BukuHal08"); }
    public void hal9selanjutnya() { SceneManager.LoadScene("BukuHal10"); }
    public void hal10kembali() { SceneManager.LoadScene("BukuHal09"); }
    public void hal10selanjutnya() { SceneManager.LoadScene("BukuHal11"); }
    public void hal11kembali() { SceneManager.LoadScene("BukuHal10"); }
    public void hal11selanjutnya() { SceneManager.LoadScene("BukuHal12"); }
    public void hal12kembali() { SceneManager.LoadScene("BukuHal11"); }
    public void hal12selanjutnya() { SceneManager.LoadScene("BukuHal13"); }
    public void hal13kembali() { SceneManager.LoadScene("BukuHal12"); }
    public void hal13selanjutnya() { SceneManager.LoadScene("BukuHal14"); }
    public void hal14kembali() { SceneManager.LoadScene("BukuHal13"); }
    public void hal14selanjutnya() { SceneManager.LoadScene("BukuHal15"); }
    public void hal15kembali() { SceneManager.LoadScene("BukuHal14"); }
    public void hal15selanjutnya() { SceneManager.LoadScene("BukuHal16"); }
    public void hal16kembali() { SceneManager.LoadScene("BukuHal15"); }
    public void hal16selanjutnya() { SceneManager.LoadScene("BukuHal17"); }
    public void hal17kembali() { SceneManager.LoadScene("BukuHal16"); }
    public void hal17selanjutnya() { SceneManager.LoadScene("BukuHal18"); }
    public void hal18kembali() { SceneManager.LoadScene("BukuHal17"); }
    public void hal18selanjutnya() { SceneManager.LoadScene("BukuHal01"); }
}
