using UnityEngine;

public class KillTarget : MonoBehaviour
{
    public GameObject target;
    public ParticleSystem hitEffect;
    public GameObject killEffect;
    public float timeToSelect = 3.0f;
    public int score;

    Transform cam;
    private float countDown;

    void Start()
    {
        cam = Camera.main.transform;
        score = 0;
        countDown = timeToSelect;
    }
    void Update()
    {
        Debug.Log("Script is Running");
        bool isHitting = false;
        Ray ray = new Ray(cam.position, cam.rotation *
            Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Raycast Hit something");

            Debug.Log("Raycast hit " + hit.collider.gameObject.name);

            if (hit.collider.gameObject == target)
            {

                Debug.Log("Raycast hit target");
                isHitting = true;
            }
        }

        if (isHitting)
        {
            if (countDown > 0.0f)
            {
                Debug.Log(countDown);
                // on target 
                countDown -= Time.deltaTime;
                // print (countDown); 
                hitEffect.transform.position = hit.point;
                if (hitEffect.isStopped)
                {
                    hitEffect.Play();
                }
            }
            else
            {
                // killed 
                Instantiate(killEffect, target.transform.position,
                   target.transform.rotation);
                score += 1;
                countDown = timeToSelect;
                SetRandomPosition();
            }
        }
        else
        {
            // reset 
            countDown = timeToSelect;
            hitEffect.Stop();
        }
    }
    void SetRandomPosition()
    {
        float x = Random.Range(-50.0f, 50.0f);
        float z = Random.Range(-50.0f, 50.0f);
        target.transform.position = new Vector3(x, 0.0f, z);
    }
}