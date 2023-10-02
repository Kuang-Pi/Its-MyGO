using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    /*This Script is used for making an object following an existing object with a certain delay. 
     * This script will try to disable the collider of this object. 
     */
    public GameObject targetObject;
    public int delay;
    private Rigidbody2D _rb;
    private Queue<Vector3> _futurePaths;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        _futurePaths = new Queue<Vector3>();
        _futurePaths.Enqueue(targetObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_futurePaths.Count);
        if ((targetObject.GetComponent<Transform>().position - _futurePaths.Peek()).magnitude > 0.3f)
        {
            _futurePaths.Enqueue(targetObject.GetComponent<Transform>().position);
        }
        
        if (_futurePaths.Count > delay)
        {
            _rb.AddForce((_futurePaths.Dequeue() - this.transform.position).normalized);
        }
    }
}
