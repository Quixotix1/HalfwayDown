using System.Collections;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private string[] lines;

    [SerializeField] private float entryTime, readingTime, exitTime;
    
    private void OnEnable()
    {
        text.alpha = 0f;

        StartCoroutine(PlayLines());
    }

    private IEnumerator PlayLines()
    {
        int currentLine = 0;

        float currentVisibility;

        while (currentLine < lines.Length)
        {
            text.text = lines[currentLine];

            float entryElapsed = 0f;

            while (entryElapsed <= entryTime)
            {
                entryElapsed += Time.deltaTime;
                currentVisibility = Mathf.Clamp01(entryElapsed / entryTime);

                text.alpha = currentVisibility;

                yield return null;
            }

            yield return new WaitForSeconds(readingTime);

            float exitElapsed = exitTime;

            while (exitElapsed >= 0f)
            {
                exitElapsed -= Time.deltaTime;
                currentVisibility = Mathf.Clamp01(exitElapsed / exitTime);

                text.alpha = currentVisibility;

                yield return null;
            }

            currentLine++;
            yield return null;
        }
    }
}
