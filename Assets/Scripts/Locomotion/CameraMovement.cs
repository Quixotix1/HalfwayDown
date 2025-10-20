using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject cameraTarget;
    
    private void LateUpdate()
    {
        transform.position = cameraTarget.transform.position;
        transform.rotation = cameraTarget.transform.rotation;
    }
}
