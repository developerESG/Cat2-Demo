using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
//using UnityEditorInternal;

public class GuestController : MonoBehaviour

{
    public SkeletonAnimation skeletonAnimation;
    public AnimationReferenceAsset walk;
    public AnimationReferenceAsset tap;
    public string currentState;
    public float movement;
    public float speed;
    private float timer = 0.0f;
    private float timeWhenTaped = 0.0f;

    void Start()
    {
        currentState = "walk";
        SetCharacterState(currentState);
    }

    void Update()
    {
        timer += Time.deltaTime;
    }

    public void SetAnimation(AnimationReferenceAsset animation, bool loop, float timeScale)
    {
        skeletonAnimation.state.SetAnimation(0, animation, loop).TimeScale = timeScale;
    }

    public void SetCharacterState(string state)
    {
        if (state.Equals("walk"))
        {
            SetAnimation(walk, true, 1f);
        }
        else if (state.Equals("tap"))
        {
            SetAnimation(tap, true, 1f);
        }
    }


    private void OnMouseDown()
    {
        timeWhenTaped = timer;
        timeWhenTaped += 2f;
        SetCharacterState("tap");
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        SetCharacterState("walk");
    }
}
