using UnityEngine;

public class BallDropper : MonoBehaviour
{
    public void Drop()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
