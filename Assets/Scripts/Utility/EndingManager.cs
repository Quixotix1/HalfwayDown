using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    [SerializeField] private float totalSceneTime;

    private void Start()
    {
        Invoke(nameof(SwitchToMainMenu), totalSceneTime);
    }

    private void SwitchToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
