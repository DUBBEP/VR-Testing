using UnityEngine;
using UnityEngine.UI;

public class ForceUI : MonoBehaviour
{
    private Toggle toggle;
    private Button button;

    private void Start()
    {
        if (GetComponent<Button>() != null)
        {
            button = GetComponent<Button>();
        }

        if (GetComponent<Toggle>() != null)
        {
            toggle = GetComponent<Toggle>();
        }
    }

    public void Toggle()
    {
        if (toggle != null)
        {
            toggle.isOn = !toggle.isOn;
        }
    }

    public void Button()
    {
        button.onClick.Invoke();
    }
}