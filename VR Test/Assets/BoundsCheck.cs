using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    [SerializeField]
    GameObject loseScreen;
    [SerializeField]
    GameObject spookyAudio1;
    [SerializeField]
    GameObject spookyAudio2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle") == true)
        {
            SetRandomPosition();
        }
        else if (other.gameObject.CompareTag("Lose") == true)
        {
            SetLoseScreen();
        }
    }

    void SetLoseScreen()
    {
        loseScreen.SetActive(true);
        spookyAudio1.SetActive(false);
        spookyAudio2.SetActive(false);
    }

    void SetRandomPosition()
    {
        float x = Random.Range(-50.0f, 50.0f);
        float z = Random.Range(-50.0f, 50.0f);
        transform.position = new Vector3(x, 0.0f, z);
    }
}
