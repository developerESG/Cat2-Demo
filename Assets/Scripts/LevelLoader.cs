using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelLoader : MonoBehaviour
{
    public GameObject loadingSrceen;
    public Slider slider;
    private float Timer = 0f;

    void Start()
    {
        //StartCoroutine(LoadAsynchroniously(1));
    }

    void Update()
    {
        Timer += Time.deltaTime;
        slider.value = Timer;
        if (Timer >= 1f) { 
            Debug.Log("scene loaded");
            SceneManager.LoadScene(1);
        }

    }
    IEnumerator LoadAsynchroniously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingSrceen.SetActive(true);

            while (operation.isDone == false)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
            yield return null;
            }
        }
    }


