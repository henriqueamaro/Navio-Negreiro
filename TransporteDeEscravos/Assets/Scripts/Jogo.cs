using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Jogo : MonoBehaviour
{
    public int pontos;
    public Text pontosText;

    public int vidas = 3;
    public Text vidaText;

    public GameObject inimigo;
    public float tempoCriacaoInimigo = 5f;

    public GameObject Algema;
    public float tempoCriacaoAlgema = 5f;

    public GameObject Cadeado;
    public float tempoCriacaoCadeado = 5f;

    public GameObject Barril;
    public float tempoCriacaoBarril = 5f;

    private float tempo;
    private float tempo2;
    private float tempo3;
    private float tempo4;



    public void CarregaIntroducao()
    {
        SceneManager.LoadScene("Introducao");
    }

    public void CarregarFase1()
    {
        PlayerPrefs.SetInt("pontos", 0);
        PlayerPrefs.SetInt("vidas",vidas);
        SceneManager.LoadScene("Fase1");
    }


    public void EncerrarJogo()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("VIDA1");
        if (PlayerPrefs.HasKey("pontos"))
        {
            AtualizarPontos();
            pontos = PlayerPrefs.GetInt("pontos");
        }

        if (PlayerPrefs.HasKey("vidas"))
        {
            AtualizarVida();
            vidas = PlayerPrefs.GetInt("vidas");
        }

        tempo = Time.time;
        tempo2 = Time.time;
        tempo3 = Time.time;
        tempo4 = Time.time;
    }

    public void AtualizarVida()
    {
        Debug.Log("VIDA2");
       if(vidas < 0)
        {
            SceneManager.LoadScene("GameOver");

        }
        else
        {
            vidaText.text = "VIDAS: " + PlayerPrefs.GetInt("vidas");
        }
    }

    public void AumentarVida()
    {
        vidas++;
        PlayerPrefs.SetInt("vidas", vidas);
        AtualizarVida();
    }

    public void DiminuirVida()
    {
        vidas--;
        PlayerPrefs.SetInt("vidas", vidas);
        AtualizarVida();
    }



    public void AdicionarPontos()
    {
        pontos++;
        PlayerPrefs.SetInt("pontos", pontos);
        AtualizarPontos();
    }

    public void PerderPontos()
    {
        pontos--;
        PlayerPrefs.SetInt("pontos", pontos);
        AtualizarPontos();
    }

    public void AtualizarPontos()
    {
        pontosText.text = "Pontos: " + PlayerPrefs.GetInt("pontos");
    }
    // Update is called once per frame
    void Update()
    {
        CriaInimigos();

        CriaCadeado();

        CriaAlgema();

        CriaBarril();
    }

    void CriaInimigos()
    {
        if(Time.time >= tempo + tempoCriacaoInimigo)
        {
            tempo = Time.time;
            Instantiate(inimigo, new Vector2(16, -2.40f), Quaternion.identity);
        }
    }

    void CriaCadeado()
    {
        if (Time.time >= tempo2 + tempoCriacaoCadeado)
        {
            tempo2 = Time.time;
            Instantiate(Cadeado, new Vector2(22, -1.72f), Quaternion.identity);
        }
    }

    void CriaAlgema()
    {
        if (Time.time >= tempo3 + tempoCriacaoAlgema)
        {
            tempo3 = Time.time;
            Instantiate(Algema, new Vector2(18, -2.50f), Quaternion.identity);
        }
    }

    void CriaBarril()
    {
        if (Time.time >= tempo4 + tempoCriacaoBarril)
        {
            tempo4 = Time.time;
            Instantiate(Barril, new Vector2(10, -1.75f), Quaternion.identity);
        }
    }
}
