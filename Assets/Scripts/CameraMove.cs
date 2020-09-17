using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    Vector3 touchStart;
    public float zoomOutMin = 1;
    public float zoomOutMax = 18;
    public float zoomSpeed = 0.1f;

    [SerializeField] Transform mainCamera;
    [SerializeField] float leftLimit;
    [SerializeField] float rightLimit;
    [SerializeField] float upperLimit;
    [SerializeField] float bottomLimit;



    void Update()
    {
        /*
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, upperLimit),
            transform.position.z);
        */


        //if ((mainCamera.position.x > leftLimit && mainCamera.position.x < rightLimit) && (mainCamera.position.y < upperLimit && mainCamera.position.y > bottomLimit))
                

        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPosition = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPosition = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPosition - touchOnePrevPosition).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * zoomSpeed);

        }
        else if (Input.GetMouseButton(0))
        {

            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 _temp = Camera.main.transform.position + direction;

            if (_temp.x < leftLimit)
                _temp.x = leftLimit;
            else
                _temp.x = _temp.x;

            if (_temp.x > rightLimit)
                _temp.x = rightLimit;
            else
                _temp.x = _temp.x;

            if (_temp.y > upperLimit)
                _temp.y = upperLimit;
            else
                _temp.y = _temp.y;

            if (_temp.y < bottomLimit)
                _temp.y = bottomLimit;
            else
                _temp.y = _temp.y;

            //_temp.x = _temp.x < leftLimit ? leftLimit : _temp.x;   
            //_temp.x = _temp.x < rightLimit ? rightLimit : _temp.x;
            //_temp.y = _temp.y < upperLimit ? upperLimit : _temp.y;
            //_temp.y = _temp.y > bottomLimit ? bottomLimit : _temp.y;
            //same for right, upper, bottom

            Camera.main.transform.position = _temp;   //new
            
            //Camera.main.transform.position += direction;    old

        }



 


        zoom(Input.GetAxis("Mouse ScrollWheel"));
    }
    void zoom(float increment)
        {
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
        }

}

