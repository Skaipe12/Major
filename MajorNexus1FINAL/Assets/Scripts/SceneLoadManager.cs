using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{

    public float transitionTime = 2f;
    private Animator transitionAnimator;
    public GameObject canvasSceneLoadManager;
    public GameObject escena;

    private IEnumerator Start()
    {
        transitionAnimator = GetComponentInChildren<Animator>();
        yield return new WaitForSeconds(1);
        escena.SetActive(true);
        canvasSceneLoadManager.SetActive(false);
    }

    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextSceneIndex));
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        transitionAnimator.SetTrigger("StartTransition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);

    }
}
