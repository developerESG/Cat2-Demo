using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelLoader : MonoBehaviour
{
    public GameObject loadingSrceen;
    public Slider slider;

    void Start()
    {
        StartCoroutine(LoadAsynchroniously(1));
    }
    IEnumerator LoadAsynchroniously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingSrceen.SetActive(true);
        while (operation.isDone == false)
        {
            //yield return new WaitForSeconds(10f);
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;//new WaitForSeconds(3);
        }
    }
}
