using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider bar;
    public Gradient gradient;
    public Image fill;
    int followers;
    float t = 0;

    //public void SetMaxGoal(int followers)
    //{
    //    bar.maxValue = followers;
    //    fill.color = gradient.Evaluate(1f);
    //}

    //public void SetFollowers(int progress)
    //{
    //    bar.value = progress;
    //    fill.color = gradient.Evaluate(bar.normalizedValue);
    //}

    private void Start()
    {
        bar.maxValue = 5;
        bar.value = t;
    }

    private void Update()
    {

        t += Time.deltaTime;

        if (t < 5)
        {
            bar.value = t;
        }

    }


}
