using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow : MonoBehaviour
{
    private GameObject play;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        play = GameObject.Find("play");
        offset = transform.position-play.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + play.transform.position;
        float mouse = Input.GetAxis("Mouse ScrollWheel");
        float fangda = Camera.main.fieldOfView -= mouse * 8;
        fangda= Mathf.Clamp(fangda, 5, 50);
        Camera.main.fieldOfView = fangda;
    }
}
