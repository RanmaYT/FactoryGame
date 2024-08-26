using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] AudioSource clickAudio;

    int index;
    public void PlayButton()
    {
        index = 1;
        StartCoroutine(LoadCooldown());
    }

    public void GuideButton()
    {
        index = 2;
        StartCoroutine(LoadCooldown());
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    IEnumerator LoadCooldown()
    {
        clickAudio.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(index);
    }
}
