using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundriesScaler : MonoBehaviour
{
    public SpriteRenderer background;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }
    void LateUpdate()
    {
        float limitX = (background.size.x * background.gameObject.transform.localScale.x) - (2 * cam.orthographicSize * cam.aspect);
        float limitY = (background.size.y * background.gameObject.transform.localScale.y) - cam.orthographicSize * 2;
        transform.localScale = new Vector3(limitX, limitY, 1);
    }
}
