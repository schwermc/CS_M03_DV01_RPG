using UnityEngine;

public class CameraController : MonoBehaviour
{

    void Update()
    {
        // does the player exist?
        if (PlayerController.me != null && !PlayerController.me.dead)
        {
            Debug.Log("Hello There");
            Vector3 targetPos = PlayerController.me.transform.position;
            targetPos.z = -10;
            transform.position = targetPos;
        }
    }
}
