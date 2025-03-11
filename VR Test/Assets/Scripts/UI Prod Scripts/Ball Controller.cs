using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private RectTransform controllerReticle;

    private Vector3 reticleScale;

    private void Start()
    {
        reticleScale = controllerReticle.localScale;
    }

    public void ReticleHighlightScale()
    {
        controllerReticle.localScale = reticleScale * 2f;
    }

    public void ReticleDefaultScale()
    {
        controllerReticle.localScale = reticleScale;
    }


    public void FixToPanel()
    {
        controllerReticle.anchoredPosition = new Vector3(Mathf.Clamp(controllerReticle.position.x, -80, 80), 
                                                Mathf.Clamp(controllerReticle.position.y, -80, 80), -1);
    }

    public Vector3 GetDirectionVector()
    {
        return new Vector3(controllerReticle.anchoredPosition.x, 0, controllerReticle.anchoredPosition.y);
    }
}
