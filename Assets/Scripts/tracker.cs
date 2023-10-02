using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracker : MonoBehaviour
{
    private Vector3 previosPosition;
    // Start is called before the first frame update
    void Start()
    {
        previosPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Horinzontal Speed: " + ((transform.position.x - previosPosition.x)/Time.deltaTime).ToString());
        Debug.Log("Vertical Speed: " + ((transform.position.y - previosPosition.y) / Time.deltaTime).ToString());
        previosPosition = transform.position;
    }
}
