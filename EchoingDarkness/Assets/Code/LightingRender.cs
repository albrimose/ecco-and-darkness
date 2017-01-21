using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class LightingRender : MonoBehaviour {
    protected int width;
    protected int height;
    protected RenderTexture target;
    protected Camera camComponent;
    public ScreenOverlay overlay;
    // Use this for initialization
    void Start () {
        camComponent = GetComponent<Camera>();
        target = new RenderTexture(Screen.width, Screen.height, 0);
        width = Screen.width;
        height = Screen.height;
        target.name = "TextureFromCamera_" + gameObject.name;
        target.Create();
        camComponent.targetTexture = target;
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

        if (overlay != null)
        {
            overlay.texture = target;
        }
        
    }
}
