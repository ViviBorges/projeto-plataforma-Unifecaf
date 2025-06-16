using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;

    private TextMeshProUGUI scoreText;

    void Awake()
    {
        // Garante que o GameManager não seja duplicado entre cenas
        if (FindObjectsOfType<GameManager>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        TryFindScoreText(); // tenta encontrar o texto ao iniciar
    }

    void Update()
    {
        // Se o Text não estiver carregado ainda, tenta novamente (útil ao trocar de cena)
        if (scoreText == null)
        {
            TryFindScoreText();
            return;
        }

        scoreText.text = score.ToString();
    }

    void TryFindScoreText()
    {
        GameObject textObj = GameObject.Find("ScoreText");
        if (textObj != null)
        {
            scoreText = textObj.GetComponent<TextMeshProUGUI>();
        }
    }
}
