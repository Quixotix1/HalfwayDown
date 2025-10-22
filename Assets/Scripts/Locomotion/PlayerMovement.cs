using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject camAnchor;
    [SerializeField] private AudioSource footsteps;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // TO-DO: may want to remove/experiment with removing strafing

        if (vertical != 0 | horizontal != 0)
        {
            footsteps.mute = false;
        }
        else
        {
            footsteps.mute = true;
        }

        Vector3 forward = Vector3.Normalize(new Vector3(camAnchor.transform.forward.x, 0f, camAnchor.transform.forward.z));
        Vector3 right = Vector3.Normalize(new Vector3(camAnchor.transform.right.x, 0f, camAnchor.transform.right.z));

        Vector3 motion = forward * vertical + right * horizontal; // this took embarrassingly long to figure out

        transform.position += motion;
    }
}
