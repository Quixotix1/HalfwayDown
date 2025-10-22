using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private GameObject mirror;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Interact"))
            {
                mirror.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
