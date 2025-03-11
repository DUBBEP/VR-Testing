using UnityEngine;

public class DropperManager : MonoBehaviour
{
    private BallDropper[] ballsInScene;

    void Start()
    {
        ballsInScene = FindObjectsOfType<BallDropper>();
    }

    public void DropAllBalls()
    {
        foreach (BallDropper ball in ballsInScene)
            ball.Drop();
    }
}
