using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timePassed;
    public GameObject player;
    public TextMeshProUGUI textMeshProUGUI;
    private Camera theCamera; // The component

    private Color character_using_color;
    private Color background_using_color;

    private GameObject[] surfaces;

    private bool changed = false;
    // Start is called before the first frame update
    void Start()
    {
        timePassed = 0f;
        theCamera = Camera.main.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        Debug.Log(timePassed);

        // Time swap
        if (timePassed >= 51.0f && !changed && timePassed < 51.35f)
        {
            Swap(false);
        }
        if (timePassed >= 51.35f && !changed && timePassed < 51.7f)
        {
            Swap(true);
        }

        if (timePassed >= 51.7f && !changed && timePassed < 51.88f)
        {
            Swap(false);
        }
        if (timePassed >= 51.88f && !changed && timePassed < 52.06f)
        {
            Swap(true);
        }

        if (timePassed >= 52.06f && !changed && timePassed < 52.22f)
        {
            Swap(false);
        }
        if (timePassed >= 52.22f && !changed && timePassed < 52.38f)
        {
            Swap(true);
        }

        if (timePassed >= 52.38f && !changed && timePassed < 52.51f)
        {
            Swap(false);
        }
        if (timePassed >= 52.51f && !changed && timePassed < 52.64f)
        {
            Swap(true);
        }

        if (timePassed >= 52.64f && !changed)
        {
            Swap(false);
            changed = true;
        }
    }

    private void Swap(bool _color)
    {
        if (_color) {
            character_using_color = Color.white;
            background_using_color = Color.black;
        }
        else
        {
            character_using_color = Color.black;
            background_using_color = Color.white;
        }
        
        surfaces = GameObject.FindGameObjectsWithTag("Surface");
        foreach (GameObject surface in surfaces)
        {
            surface.GetComponent<SpriteRenderer>().color = character_using_color;
        }

        player.GetComponent<SpriteRenderer>().color = character_using_color;
        theCamera.backgroundColor = this.background_using_color;
        textMeshProUGUI.color = character_using_color;
    }
}
