using System.Collections;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countdownText;
    [SerializeField]
    private AudioSource pingAudio;
    [SerializeField]
    private DropperManager dropperManager;
    public void StartCountdown()
    {
        StartCoroutine(CountDownSequence());
    }

    IEnumerator CountDownSequence()
    {
        for (int i = 3; i >= 0; --i)
        {
            countdownText.text = i.ToString();
            pingAudio.Play();
            yield return new WaitForSeconds(1);
        }
        dropperManager.DropAllBalls();
    }
}
