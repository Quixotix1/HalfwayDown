using UnityEngine;

public class StateChecker : MonoBehaviour
{
    [SerializeField] private GameObject therapyDoor;

    void Start()
    {
        if (EndingTracker.endingReached)
            therapyDoor.SetActive(true);
    }
}
