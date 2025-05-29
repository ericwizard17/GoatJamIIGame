using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentDay = 1;
    public int maxDays = 14;
    public bool isDaytime = true;

    void Start()
    {
        StartDay();
    }

    void StartDay()
    {
        isDaytime = true;
        // Kaz� zaman�, enerji kazan�l�r
    }

    void StartNight()
    {
        isDaytime = false;
        // F�rt�na ba�lar, gemiye d�n�lmeli
    }

    public void EndDay()
    {
        currentDay++;
        if (currentDay > maxDays)
        {
            WinGame();
        }
        else
        {
            StartDay();
        }
    }

    void WinGame()
    {
        // Oyunu kazanma sahnesi
    }

    public void LoseGame()
    {
        // Oyunu kaybetme sahnesi
    }
}

