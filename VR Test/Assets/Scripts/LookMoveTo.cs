using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;
    private Transform cam;

    public Transform infoBubble;
    private TextMeshProUGUI infoText;

    private void Start()
    {
        cam = Camera.main.transform;
        if (infoBubble != null)
        {
            infoText = GetComponentInChildren<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        cam = Camera.main.transform;
        Ray ray;
        RaycastHit[] hits;
        GameObject hitObject;

        Debug.DrawRay(cam.position, cam.rotation *
           Vector3.forward * 100.0f);

        ray = new Ray(cam.position, cam.rotation *
           Vector3.forward);
        hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject;
            if (hitObject == ground)
            {
                if (infoBubble != null)
                {
                    infoText.text = "X:" + hit.point.x.ToString("F2") +
                                    ", " +
                                    "Z:" + hit.point.z.ToString("F2");

                    infoBubble.LookAt(cam.position);
                    infoBubble.Rotate(0, 180f, 0);
                }
                transform.position = hit.point;
            }
        }
    }
}