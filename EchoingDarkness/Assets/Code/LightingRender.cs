﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class LightingRender : MonoBehaviour {
    protected int width;
    protected int height;
    protected RenderTexture target;
    protected Camera camComponent;
    public ScreenOverlay overlay;
    public Color TargetColor;
    public float ColorTime = 5f;
    // Use this for initialization
    void Start () {
        camComponent = GetComponent<Camera>();
        target = new RenderTexture(Screen.width, Screen.height, 0);
        width = Screen.width;
        height = Screen.height;
        target.name = "TextureFromCamera_" + gameObject.name;
        target.Create();
        camComponent.targetTexture = target;
        TargetColor = camComponent.backgroundColor;
    }
	
	// Update is called once per frame
	void Update () {
        if (width != Screen.width || height != Screen.height)
        {
            target.Release();
            Object.Destroy(target);
            target = new RenderTexture(Screen.width, Screen.height, 0);
            width = Screen.width;
            height = Screen.height;
            target.name = "TextureFromCamera_" + gameObject.name;
            target.Create();
            camComponent.targetTexture = target;
        }
        if(camComponent.backgroundColor != TargetColor)
        {
            camComponent.backgroundColor = Color.Lerp(camComponent.backgroundColor, TargetColor, Time.deltaTime * ColorTime);
        }
        if (overlay != null)
        {
            overlay.texture = target;
        }
        
    }
}
