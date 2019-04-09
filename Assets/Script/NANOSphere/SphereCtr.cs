﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(MeshRenderer))]
public class SphereCtr : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public Color color0;
    public bool setColor;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
        float speed = Random.Range(0f, 0.5f);

        float tiling = Random.Range(1f, 4f);
        

        meshRenderer.material.SetFloat("_Speed", speed);
        meshRenderer.material.SetVector("_Tiling", new Vector2(tiling,tiling));

        if (setColor) {
            meshRenderer.material.SetColor("_Color0", color0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
