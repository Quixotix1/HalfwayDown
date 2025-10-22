using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] private int endingIndex;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Interact"))
            {
                EndingTracker.endingReached = true;
                SceneManager.LoadScene(endingIndex);
            }
        }
    }
}
