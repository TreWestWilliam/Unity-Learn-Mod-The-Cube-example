using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float r;
    public float g;

    public float startRandom;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        
        Material material = Renderer.material;

        startRandom = Random.Range(0.0f, 100.0f);

        r = Mathf.Abs((Mathf.Sin((float)Time.frameCount +startRandom / 1000)));
        g = Mathf.Abs((Mathf.Cos((float)Time.frameCount + startRandom / 1000)));

        material.color = new Color(r, g, 0.3f, 0.4f);
    }
    
    void Update()
    {
        r = Mathf.Abs((Mathf.Sin((float)Time.frameCount / 1000)));
        g = Mathf.Abs((Mathf.Cos((float)Time.frameCount / 1000)));
        Renderer.material.color = new Color(r, g, 0.3f, 0.4f);
        transform.Rotate(10.0f * Time.deltaTime, 5.1f*Time.deltaTime, 0.0f);
    }
}
