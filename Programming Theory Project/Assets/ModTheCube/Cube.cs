using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.9f, 0.75f, 0.42f, 1f);
    }
    
    void Update()
    {
        transform.Rotate(0.0f, 10.0f * Time.deltaTime, 0.0f);
    }
}
