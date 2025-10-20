using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float cameraXMin, cameraXMax;
    [SerializeField] private float cameraSensitivity;

    float xRot, yRot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        xRot = transform.localEulerAngles.x;
        yRot = transform.localEulerAngles.y;
    }

    private void Update()
    {
        yRot += Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
        xRot -= Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;

        xRot = Mathf.Clamp(xRot, cameraXMin, cameraXMax);

        transform.localEulerAngles = new Vector3(xRot, yRot, 0f);
    }
}
