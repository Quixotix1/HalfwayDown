using UnityEngine;

public class SunRotate : MonoBehaviour
{
    [SerializeField] private float startingAngle;
    [SerializeField] private float speed;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(startingAngle, -30f, 0f);
        startingAngle += Time.deltaTime * speed;
    }
}
