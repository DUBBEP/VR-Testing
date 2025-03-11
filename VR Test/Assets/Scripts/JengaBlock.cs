using UnityEngine;

public class JengaBlock : MonoBehaviour
{
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gun"))
        {
            Vector3 randomDir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

            GetComponent<Rigidbody>().AddForce(randomDir * 1000, ForceMode.Impulse);
            GetComponent<Rigidbody>().AddExplosionForce(10000, transform.position, 1.5f);
            audio.Play();
        }
    }
}
