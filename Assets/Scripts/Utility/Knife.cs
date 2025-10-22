using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private GameObject mirror;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetButton("Interact"))
            {
                mirror.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
