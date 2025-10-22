using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private int gameIndex;
    [SerializeField] private Image overlay;

    [SerializeField] private GameObject creditsButton;
    [SerializeField] private GameObject creditsMenu;

    [SerializeField] private float transitionTime;
    [SerializeField] private float darkTime;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        overlay.gameObject.SetActive(false);

        if (EndingTracker.endingReached)
            creditsButton.SetActive(true);
        else 
            creditsButton.SetActive(false);
    }

    public void StartGame()
    {
        StartCoroutine(SetScene(false, gameIndex));
    }

    public void ExitGame()
    {
        StartCoroutine(SetScene(true, null));
    }

    public void ToggleCredits()
    {
        creditsMenu.SetActive(!creditsMenu.activeInHierarchy);
    }

    private IEnumerator SetScene(bool quit, int? scene)
    {
        overlay.gameObject.SetActive(true);
        overlay.color = new Color(0, 0, 0, 0);

        float elapsed = 0f;

        while (elapsed <= transitionTime)
        {
            elapsed += Time.deltaTime;
            overlay.color = new Color(0, 0, 0, elapsed / transitionTime);
            yield return null;
        }

        yield return new WaitForSeconds(darkTime);

        if (quit) 
            Application.Quit();

        if (scene != null)
            SceneManager.LoadScene(gameIndex);
    }
}
