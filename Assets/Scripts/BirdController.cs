using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float animationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().speed = animationSpeed;
    }

    void OnGUI()
    {
        if (GUILayout.Button("Increase Flapping Speed"))
            animationSpeed += 0.5f;

        if (GUILayout.Button("Decrease Flapping Speed"))
            animationSpeed -= 0.5f;
    }
}
