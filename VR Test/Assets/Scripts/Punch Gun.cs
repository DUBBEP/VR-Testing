using UnityEngine;

public class PunchGun : MonoBehaviour
{
    [SerializeField]
    private float extendMagnitude;
    private bool extendActive;

    [SerializeField]
    private Transform targetTransform;


    private void Update()
    {
        if (extendActive)
        {
            Extend();
        }
        else if (targetTransform.localScale.x > 1)
        {
            Retract();
        }
        else if (targetTransform.localScale.x < 1)
        {
            targetTransform.localScale = Vector3.one;
        }
    }

    public void ActivateExtention()
    {
        extendActive = true;
    }

    public void DeactivateExtention()
    {
        extendActive = false;
    }

    private void Extend()
    {
        targetTransform.localScale += new Vector3(1, 0, 0) * extendMagnitude * 10 * Time.deltaTime;
    }

    private void Retract()
    {
        targetTransform.localScale -= new Vector3(1, 0, 0) * extendMagnitude * 30 * Time.deltaTime;
    }

    private void ResetScale()
    {
        targetTransform.localScale = Vector3.one;
    }

}
