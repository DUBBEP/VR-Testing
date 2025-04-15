using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUtilities : MonoBehaviour
{
    public void SwitchScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}
